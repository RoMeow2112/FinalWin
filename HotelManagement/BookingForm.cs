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
using System.IO;

namespace HotelManagement
{
    public partial class BookingForm: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private decimal roomPricePerNight = 0;
        public BookingForm()
        {
            InitializeComponent();
            LoadRooms();
            LoadCustomers();
            ConfigureDateTimePickers();
        }
        private void LoadRooms()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT room_id, room_number, room_price FROM Rooms WHERE room_status = 'Available'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable rooms = new DataTable();
                    adapter.Fill(rooms);

                    comboBoxRoom.DataSource = rooms;
                    comboBoxRoom.DisplayMember = "room_number";
                    comboBoxRoom.ValueMember = "room_id";
                    comboBoxRoom.SelectedIndex = -1;

                    // Lưu giá phòng trước
                    comboBoxRoom.SelectedIndexChanged += (s, e) =>
                    {
                        if (comboBoxRoom.SelectedIndex >= 0)
                        {
                            DataRowView selectedRow = comboBoxRoom.SelectedItem as DataRowView;
                            roomPricePerNight = Convert.ToDecimal(selectedRow["room_price"]);
                            CalculateTotalPrice();
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT customer_id, name FROM Customers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable customers = new DataTable();
                    adapter.Fill(customers);

                    comboBoxCustomer.DataSource = customers;
                    comboBoxCustomer.DisplayMember = "name";
                    comboBoxCustomer.ValueMember = "customer_id";
                    comboBoxCustomer.SelectedIndex = -1; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDateTimePickers()
        {
            dateTimePickerCheckIn.Value = DateTime.Today;
            dateTimePickerCheckOut.Value = DateTime.Today.AddDays(1);

            dateTimePickerCheckIn.ValueChanged += (s, e) => CalculateTotalPrice();
            dateTimePickerCheckOut.ValueChanged += (s, e) => CalculateTotalPrice();
        }
        private void CalculateTotalPrice()
        {
            if (comboBoxRoom.SelectedIndex >= 0)
            {
                DateTime checkIn = dateTimePickerCheckIn.Value;
                DateTime checkOut = dateTimePickerCheckOut.Value;
                TimeSpan stayDuration = checkOut.Date - checkIn.Date;
                int numberOfDays = stayDuration.Days;

                if (numberOfDays <= 0)
                {
                    textBoxTotalPrice.Text = "0";
                    return;
                }

                decimal totalPrice = roomPricePerNight * numberOfDays;
                textBoxTotalPrice.Text = totalPrice.ToString("N0"); 
            }
            else
            {
                textBoxTotalPrice.Text = "0";
            }
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRoom.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a room!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBoxCustomer.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a customer!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime checkIn = dateTimePickerCheckIn.Value;
                DateTime checkOut = dateTimePickerCheckOut.Value;
                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out date must be after check-in date!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TimeSpan stayDuration = checkOut.Date - checkIn.Date;
                int numberOfDays = stayDuration.Days;
                decimal totalPrice = roomPricePerNight * numberOfDays;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateRoomQuery = "UPDATE Rooms SET room_status = 'Occupied' WHERE room_id = @RoomId";
                    using (SqlCommand updateCmd = new SqlCommand(updateRoomQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@RoomId", comboBoxRoom.SelectedValue);
                        updateCmd.ExecuteNonQuery();
                    }

                    string insertQuery = "INSERT INTO Booking (room_id, customer_id, check_in, check_out, total_price) " +
                                        "VALUES (@RoomId, @CustomerId, @CheckIn, @CheckOut, @TotalPrice)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@RoomId", comboBoxRoom.SelectedValue);
                        insertCmd.Parameters.AddWithValue("@CustomerId", comboBoxCustomer.SelectedValue);
                        insertCmd.Parameters.AddWithValue("@CheckIn", checkIn);
                        insertCmd.Parameters.AddWithValue("@CheckOut", checkOut);
                        insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Booking Bill Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewCustomer addNewCustomer = new AddNewCustomer();
                if (addNewCustomer.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomers();

                    // Tìm khách hàng vừa tạo dựa trên customer_id lớn nhất
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT TOP 1 customer_id FROM Customers ORDER BY customer_id DESC";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                int newCustomerId = Convert.ToInt32(result);
                                comboBoxCustomer.SelectedValue = newCustomerId;
                            }
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
