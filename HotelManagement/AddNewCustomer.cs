using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using Microsoft.Data.SqlClient;

namespace HotelManagement
{
    public partial class AddNewCustomer: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private byte[] imageData = null;
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxName.BackColor = Color.White;
                textBoxCccd.BackColor = Color.White;
                textBoxPhone.BackColor = Color.White;
                textBoxEmail.BackColor = Color.White;

                bool hasEmptyField = false;
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    textBoxName.BackColor = Color.LightPink;
                    hasEmptyField = true;
                }
                if (string.IsNullOrWhiteSpace(textBoxCccd.Text))
                {
                    textBoxCccd.BackColor = Color.LightPink;
                    hasEmptyField = true;
                }
                if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
                {
                    textBoxPhone.BackColor = Color.LightPink;
                    hasEmptyField = true;
                }
                if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    textBoxEmail.BackColor = Color.LightPink;
                    hasEmptyField = true;
                }

                if (hasEmptyField)
                {
                    MessageBox.Show("Please fill in all required fields!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Customers (name, CCCD, phone, email, pic) VALUES (@Name, @CCCD, @Phone, @Email, @Pic)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", textBoxName.Text);
                        command.Parameters.AddWithValue("@CCCD", textBoxCccd.Text);
                        command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                        command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        // Hình ảnh vẫn có thể NULL nếu không tải lên
                        if (imageData == null)
                        {
                            command.Parameters.AddWithValue("@Pic", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Pic", imageData);
                        }

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Select Customer Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var ms = new MemoryStream(File.ReadAllBytes(openFileDialog.FileName)))
                    {
                        Image img = Image.FromStream(ms);
                        imageData = File.ReadAllBytes(openFileDialog.FileName);
                        MessageBox.Show("Image uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    imageData = null;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
