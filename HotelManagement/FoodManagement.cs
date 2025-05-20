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
    public partial class FoodManagement: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FoodManagement()
        {
            InitializeComponent();
            LoadRooms();
            LoadFoodItems();
            LoadFoods(-1);
        }
        private void LoadRooms()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT room_id, room_number FROM Rooms";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable rooms = new DataTable();
                    adapter.Fill(rooms);

                    comboBoxRoom.DataSource = rooms;
                    comboBoxRoom.DisplayMember = "room_number";
                    comboBoxRoom.ValueMember = "room_id";
                    comboBoxRoom.SelectedIndex = -1;

                    comboBoxRoom.SelectedIndexChanged += (s, e) =>
                    {
                        if (comboBoxRoom.SelectedIndex >= 0)
                        {
                            LoadFoods(Convert.ToInt32(comboBoxRoom.SelectedValue));
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFoodItems()
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

                    comboBoxFoodItem.DataSource = items;
                    comboBoxFoodItem.DisplayMember = "item";
                    comboBoxFoodItem.ValueMember = "item";
                    comboBoxFoodItem.SelectedIndex = -1;

                    if (items.Rows.Count == 0)
                    {
                        MessageBox.Show("No items found in FoodInventory. Please add items in FoodInventoryManagement first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading food items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFoods(int roomId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT food_id, item, stock_in, stock_used, 
                               (stock_in - stock_used) AS remaining_stock
                        FROM Foods";
                    if (roomId != -1)
                    {
                        query += " WHERE room_id = @RoomId";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (roomId != -1)
                    {
                        cmd.Parameters.AddWithValue("@RoomId", roomId);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewFoods.DataSource = dt;
                    dataGridViewFoods.ReadOnly = true;
                    dataGridViewFoods.AllowUserToAddRows = false;
                    dataGridViewFoods.AllowUserToDeleteRows = false;

                    dataGridViewFoods.Columns["food_id"].HeaderText = "Food ID";
                    dataGridViewFoods.Columns["item"].HeaderText = "Item";
                    dataGridViewFoods.Columns["stock_in"].HeaderText = "Stock In";
                    dataGridViewFoods.Columns["stock_used"].HeaderText = "Stock Used";
                    dataGridViewFoods.Columns["remaining_stock"].HeaderText = "Remaining Stock";

                    CheckStockWarnings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading foods: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckStockWarnings()
        {
            foreach (DataGridViewRow row in dataGridViewFoods.Rows)
            {
                decimal remainingStock = Convert.ToDecimal(row.Cells["remaining_stock"].Value);

                if (remainingStock == 0)
                {
                    labelWarning.Text = $"Out of stock, need refill! for item {row.Cells["item"].Value}!";
                    labelWarning.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }
            labelWarning.Text = "No stock issues found.";
            labelWarning.ForeColor = System.Drawing.Color.Green;
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRoom.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a room!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBoxFoodItem.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a food item!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBoxStockIn.Text, out decimal stockIn) || stockIn <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for stock in!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int roomId = Convert.ToInt32(comboBoxRoom.SelectedValue);
                string selectedItem = comboBoxFoodItem.SelectedValue.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Foods (room_id, item, stock_in, stock_used) " +
                                   "VALUES (@RoomId, @Item, @StockIn, 0)"; // food_id sẽ tự tăng
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomId", roomId);
                        cmd.Parameters.AddWithValue("@Item", selectedItem);
                        cmd.Parameters.AddWithValue("@StockIn", stockIn);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                LoadFoods(Convert.ToInt32(comboBoxRoom.SelectedValue));
                textBoxStockIn.Text = "";
                MessageBox.Show("Food item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding food item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFoods.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a food item from the list to update stock used!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBoxStockUsed.Text, out decimal newStockUsed) || newStockUsed < 0)
                {
                    MessageBox.Show("Please enter a valid positive number for stock used!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int foodId = Convert.ToInt32(dataGridViewFoods.SelectedRows[0].Cells["food_id"].Value);
                decimal currentStockIn = Convert.ToDecimal(dataGridViewFoods.SelectedRows[0].Cells["stock_in"].Value);
                decimal currentStockUsed = Convert.ToDecimal(dataGridViewFoods.SelectedRows[0].Cells["stock_used"].Value);

                decimal totalStockUsed = currentStockUsed + newStockUsed;
                if (totalStockUsed > currentStockIn)
                {
                    MessageBox.Show("Total stock used cannot exceed stock in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Foods SET stock_used = @StockUsed WHERE food_id = @FoodId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StockUsed", totalStockUsed);
                        cmd.Parameters.AddWithValue("@FoodId", foodId);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                LoadFoods(comboBoxRoom.SelectedIndex >= 0 ? Convert.ToInt32(comboBoxRoom.SelectedValue) : -1);
                textBoxStockUsed.Text = "";
                MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadFoodItems();
            LoadFoods(comboBoxRoom.SelectedIndex >= 0 ? Convert.ToInt32(comboBoxRoom.SelectedValue) : -1);
        }
    }
}
