using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HotelManagement
{
    public partial class BookingDetail: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private int bookingId;
        private string bookingDetailsText = string.Empty;
        private int roomId;
        public BookingDetail(int bookingId)
        {
            InitializeComponent();
            this.bookingId = bookingId;
            LoadBookingDetails();
        }
        private void LoadBookingDetails()
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
                        JOIN Customers c ON b.customer_id = c.customer_id
                        WHERE b.booking_id = @BookingId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingId", bookingId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            StringBuilder details = new StringBuilder();
                            details.AppendLine("Booking Details");
                            details.AppendLine("---------------");
                            details.AppendLine($"Booking ID: {reader["booking_id"]}");
                            details.AppendLine($"Room Number: {reader["room_number"]}");
                            details.AppendLine($"Customer Name: {reader["customer_name"]}");
                            details.AppendLine($"Check-In: {Convert.ToDateTime(reader["check_in"]).ToString("dd/MM/yyyy")}");
                            details.AppendLine($"Check-Out: {Convert.ToDateTime(reader["check_out"]).ToString("dd/MM/yyyy")}");
                            details.AppendLine($"Total Price: {Convert.ToDecimal(reader["total_price"]).ToString("N0")}");
                            details.AppendLine($"Status: {reader["booking_status"]}");

                            bookingDetailsText = details.ToString();
                            textBoxDetails.Text = bookingDetailsText;

                            roomId = Convert.ToInt32(reader["room_id"]);
                            string status = reader["booking_status"].ToString();
                            if (status == "Paid")
                            {
                                buttonPaid.Visible = false; // Ẩn nút nếu đã thanh toán
                            }
                        }
                        else
                        {
                            MessageBox.Show("Booking not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Close();
                        }

                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPaid_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateBookingQuery = "UPDATE Booking SET booking_status = 'Paid' WHERE booking_id = @BookingId";
                    using (SqlCommand cmd = new SqlCommand(updateBookingQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingId", bookingId);
                        cmd.ExecuteNonQuery();
                    }
                    // Đặt lại trạng thái phòng thành Available
                    string updateRoomQuery = "UPDATE Rooms SET room_status = 'Available' WHERE room_id = @RoomId";
                    using (SqlCommand cmd = new SqlCommand(updateRoomQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomId", roomId);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                MessageBox.Show("Booking marked as Paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking booking as paid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(PrintPageHandler);

                // Hiển thị hộp thoại chọn máy in
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                    MessageBox.Show("Booking details printed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing booking details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(bookingDetailsText, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }
    }
}
