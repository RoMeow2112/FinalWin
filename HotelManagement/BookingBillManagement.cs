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
    public partial class BookingBillManagement: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public BookingBillManagement()
        {
            InitializeComponent();
            LoadBookings("All");
        }
        public void LoadBookings(string statusFilter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT b.booking_id, b.room_id, r.room_number, b.customer_id, c.name AS customer_name, b.check_in, b.check_out, b.total_price, b.booking_status
                        FROM Booking b
                        JOIN Rooms r ON b.room_id = r.room_id
                        JOIN Customers c ON b.customer_id = c.customer_id";

                    if (statusFilter == "Default")
                    {
                        query += " WHERE b.booking_status IN ('Valid', 'Overdue')";
                    }
                    else if (statusFilter == "All")
                    {
                        query += " WHERE b.booking_status IN ('Valid', 'Overdue')";
                    }
                    else
                    {
                        query += " WHERE b.booking_status = @Status";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (statusFilter != "Default" && statusFilter != "All")
                    {
                        cmd.Parameters.AddWithValue("@Status", statusFilter);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewBooking.DataSource = dt;
                    dataGridViewBooking.ReadOnly = true;
                    dataGridViewBooking.AllowUserToAddRows = false;
                    dataGridViewBooking.AllowUserToDeleteRows = false;

                    dataGridViewBooking.Columns["booking_id"].HeaderText = "Booking ID";
                    dataGridViewBooking.Columns["room_id"].HeaderText = "Room ID";
                    dataGridViewBooking.Columns["room_number"].HeaderText = "Room Number";
                    dataGridViewBooking.Columns["customer_id"].HeaderText = "Customer ID";
                    dataGridViewBooking.Columns["customer_name"].HeaderText = "Customer Name";
                    dataGridViewBooking.Columns["check_in"].HeaderText = "Check-In";
                    dataGridViewBooking.Columns["check_out"].HeaderText = "Check-Out";
                    dataGridViewBooking.Columns["total_price"].HeaderText = "Total Price";
                    dataGridViewBooking.Columns["booking_status"].HeaderText = "Status";

                    foreach (DataGridViewRow row in dataGridViewBooking.Rows)
                    {
                        if (row.Cells["booking_status"].Value?.ToString() == "Overdue")
                        {
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            try
            {
                BookingForm bookingForm = new BookingForm();
                if (bookingForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBookings("All");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening BookingForm: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string statusFilter = "All";
            if (radioButtonValid.Checked)
            {
                statusFilter = "Valid";
            }
            else if (radioButtonOverdue.Checked)
            {
                statusFilter = "Overdue";
            }
            else if (radioButtonPaid.Checked)
            {
                statusFilter = "Paid";
            }
            LoadBookings(statusFilter);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings("All");
        }

        private void dataGridViewBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int bookingId = Convert.ToInt32(dataGridViewBooking.Rows[e.RowIndex].Cells["booking_id"].Value);
                    BookingDetail bookingDetail = new BookingDetail(bookingId);
                    bookingDetail.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening BookingDetail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
