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

namespace HotelManagement
{
    public partial class CustomerManagement: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private int selectedCustomerId = -1;
        public CustomerManagement()
        {
            InitializeComponent();
            LoadCustomers();
        }
        public void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT customer_id, name, CCCD, phone, email, pic FROM Customers";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewCustomer.DataSource = dt;

                    if (!dataGridViewCustomer.Columns.Contains("customer_id"))
                    {
                        MessageBox.Show("Column 'customer_id' not found in DataGridView!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dataGridViewCustomer.ReadOnly = true;
                    dataGridViewCustomer.Columns["customer_id"].HeaderText = "Customer ID";
                    dataGridViewCustomer.Columns["name"].HeaderText = "Name";
                    dataGridViewCustomer.Columns["CCCD"].HeaderText = "CCCD";
                    dataGridViewCustomer.Columns["phone"].HeaderText = "Phone";
                    dataGridViewCustomer.Columns["email"].HeaderText = "Email";
                    dataGridViewCustomer.Columns["pic"].Visible = false; // Ẩn cột pic
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when loading Customer list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCustomerImage(int customerId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT pic FROM Customers WHERE customer_id = @CustomerId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        byte[] imageData = cmd.ExecuteScalar() as byte[];
                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBoxCustomer.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBoxCustomer.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    object customerIdValue = dataGridViewCustomer.Rows[e.RowIndex].Cells["customer_id"].Value;
                    if (customerIdValue == null || customerIdValue == DBNull.Value)
                    {
                        MessageBox.Show("Customer ID is null or invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int customerId = Convert.ToInt32(customerIdValue);
                    EditCustomer editCustomer = new EditCustomer(customerId, this);
                    if (editCustomer.ShowDialog() == DialogResult.OK)
                    {
                        LoadCustomers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening EditCustomer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please double-click on a valid row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    selectedCustomerId = Convert.ToInt32(dataGridViewCustomer.Rows[e.RowIndex].Cells["customer_id"].Value);
                    LoadCustomerImage(selectedCustomerId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            if (addNewCustomer.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void pictureBoxCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (selectedCustomerId != -1 && pictureBoxCustomer.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                saveFileDialog.Title = "Save Customer Image";
                saveFileDialog.FileName = $"Customer_{selectedCustomerId}.jpg";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBoxCustomer.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No image to save or no customer selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
            pictureBoxCustomer.Image = null;
            selectedCustomerId = -1;
        }
    }
}
