using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HotelManagement
{
    public partial class InventoryManagement: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public InventoryManagement()
        {
            InitializeComponent();
            LoadItems();
            LoadInventory();
        }
        private void LoadItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT item FROM FoodInventory";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable items = new DataTable();
                    adapter.Fill(items);

                    comboBoxItem.DataSource = items;
                    comboBoxItem.DisplayMember = "item";
                    comboBoxItem.ValueMember = "item";
                    comboBoxItem.SelectedIndex = -1;

                    if (items.Rows.Count == 0)
                    {
                        MessageBox.Show("No items found in inventory. Please add a new item first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInventory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT inventory_id, item, stock_available, allocated_stock, allocation_date,
                               CASE 
                                   WHEN stock_available = 0 THEN 0
                                   ELSE (stock_available - allocated_stock) / stock_available * 100
                               END AS discrepancy
                        FROM FoodInventory";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewInventory.DataSource = dt;
                    dataGridViewInventory.ReadOnly = true;
                    dataGridViewInventory.AllowUserToAddRows = false;
                    dataGridViewInventory.AllowUserToDeleteRows = false;

                    dataGridViewInventory.Columns["inventory_id"].HeaderText = "Inventory ID";
                    dataGridViewInventory.Columns["item"].HeaderText = "Item";
                    dataGridViewInventory.Columns["stock_available"].HeaderText = "Stock Available";
                    dataGridViewInventory.Columns["allocated_stock"].HeaderText = "Allocated Stock";
                    dataGridViewInventory.Columns["allocation_date"].HeaderText = "Allocation Date";
                    dataGridViewInventory.Columns["discrepancy"].HeaderText = "Discrepancy (%)";

                    CheckInventoryDiscrepancies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kiểm tra sai lệch
        private void CheckInventoryDiscrepancies() 
        {
            foreach (DataGridViewRow row in dataGridViewInventory.Rows)
            {
                decimal stockAvailable = Convert.ToDecimal(row.Cells["stock_available"].Value);
                decimal allocatedStock = Convert.ToDecimal(row.Cells["allocated_stock"].Value);
                decimal discrepancy = Convert.ToDecimal(row.Cells["discrepancy"].Value);

                if (stockAvailable > 0 && discrepancy < 0) // Sai số âm (allocated_stock vượt quá stock_available)
                {
                    labelInventoryWarning.Text = $"Warning: Allocated stock exceeds available stock for item {row.Cells["item"].Value}!";
                    labelInventoryWarning.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }
            labelInventoryWarning.Text = "No discrepancies found.";
            labelInventoryWarning.ForeColor = System.Drawing.Color.Green;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string newItem = Microsoft.VisualBasic.Interaction.InputBox("Enter new item name:", "Add New Item", "");
                if (string.IsNullOrWhiteSpace(newItem))
                {
                    MessageBox.Show("Item name cannot be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM FoodInventory WHERE item = @Item";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Item", newItem);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Item already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO FoodInventory (item, stock_available, allocated_stock) " +
                                        "VALUES (@Item, 0, 0)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Item", newItem);
                        insertCmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                LoadItems();
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxItem.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an item!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBoxStockAvailable.Text, out decimal stockToAdd) || stockToAdd <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for stock to add!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedItem = comboBoxItem.SelectedValue.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE FoodInventory SET stock_available = stock_available + @StockToAdd " +
                                   "WHERE item = @Item";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StockToAdd", stockToAdd);
                        cmd.Parameters.AddWithValue("@Item", selectedItem);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                LoadInventory();
                textBoxStockAvailable.Text = "";
                MessageBox.Show("Stock added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAllocatedStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxItem.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an item!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBoxAllocatedStock.Text, out decimal allocatedStock) || allocatedStock <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for allocated stock!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedItem = comboBoxItem.SelectedValue.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    decimal currentStockAvailable;
                    string stockQuery = "SELECT stock_available FROM FoodInventory WHERE item = @Item";
                    using (SqlCommand stockCmd = new SqlCommand(stockQuery, conn))
                    {
                        stockCmd.Parameters.AddWithValue("@Item", selectedItem);
                        currentStockAvailable = Convert.ToDecimal(stockCmd.ExecuteScalar());
                    }

                    if (allocatedStock > currentStockAvailable)
                    {
                        MessageBox.Show("Allocated stock cannot exceed available stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string updateQuery = "UPDATE FoodInventory SET allocated_stock = allocated_stock + @AllocatedStock, " +
                                        "stock_available = stock_available - @AllocatedStock, " +
                                        "allocation_date = @AllocationDate " +
                                        "WHERE item = @Item";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@AllocatedStock", allocatedStock);
                        updateCmd.Parameters.AddWithValue("@Item", selectedItem);
                        updateCmd.Parameters.AddWithValue("@AllocationDate", DateTime.Today);
                        updateCmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                LoadInventory();
                textBoxAllocatedStock.Text = "";
                MessageBox.Show("Stock allocated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error allocating stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadItems();
            LoadInventory();
        }
    }
}
