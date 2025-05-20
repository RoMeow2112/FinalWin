using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Input;

namespace HotelManagement
{
    public partial class EditCustomer: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;
        private int customerId;
        private CustomerManagement customerManagement;
        private byte[] currentImageData = null;
        public EditCustomer(int customerId, CustomerManagement customerManagement)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.customerManagement = customerManagement;
            connection = new SqlConnection(connectionString);
            LoadCustomerDetails();
        }
        private void LoadCustomerDetails()
        {
            try
            {
                string query = "SELECT name, CCCD, phone, email, pic FROM Customers WHERE customer_id = @CustomerId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBoxName.Text = reader["name"]?.ToString() ?? string.Empty;
                        textBoxCccd.Text = reader["CCCD"]?.ToString() ?? string.Empty;
                        textBoxPhone.Text = reader["phone"]?.ToString() ?? string.Empty;
                        textBoxEmail.Text = reader["email"]?.ToString() ?? string.Empty;
                        currentImageData = reader["pic"] as byte[];
                    }
                    else
                    {
                        MessageBox.Show($"No customer found with ID: {customerId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
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
                    currentImageData = File.ReadAllBytes(openFileDialog.FileName);
                    MessageBox.Show("Image uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentImageData = null;
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
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

                string query = "UPDATE Customers SET name = @Name, CCCD = @CCCD, phone = @Phone, email = @Email, pic = @Pic WHERE customer_id = @CustomerId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", textBoxName.Text);
                    command.Parameters.AddWithValue("@CCCD", textBoxCccd.Text);
                    command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                    command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@Pic", currentImageData ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CustomerId", customerId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Customers WHERE customer_id = @CustomerId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", customerId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        DialogResult = DialogResult.OK;
                        Close();

                        if (customerManagement != null)
                        {
                            customerManagement.LoadCustomers();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
