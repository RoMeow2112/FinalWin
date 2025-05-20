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
    public partial class DailyRevenueReport: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DailyRevenueReport()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void InitializeControls()
        {
            dateTimePickerDate.Value = DateTime.Today;
        }
        private void buttonCalculateRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePickerDate.Value.Date;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Tính tổng số booking và doanh thu từ bảng Booking với booking_status = 'Paid'
                    string query = @"
                        SELECT 
                            COUNT(*) AS total_booking,
                            ISNULL(SUM(total_price), 0) AS total_revenue
                        FROM Booking
                        WHERE CAST(check_in AS DATE) = @SelectedDate
                        AND booking_status = 'Paid'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal totalBooking = Convert.ToDecimal(reader["total_booking"]);
                                decimal totalRevenue = Convert.ToDecimal(reader["total_revenue"]);

                                reader.Close();
                                string checkQuery = "SELECT COUNT(*) FROM Revenue WHERE [date] = @SelectedDate";
                                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                                {
                                    checkCmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                                    int count = (int)checkCmd.ExecuteScalar();
                                    if (count > 0)
                                    {
                                        string updateQuery = @"
                                            UPDATE Revenue
                                            SET total_booking = @TotalBooking, total_revenue = @TotalRevenue
                                            WHERE [date] = @SelectedDate";
                                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                                        {
                                            updateCmd.Parameters.AddWithValue("@TotalBooking", totalBooking);
                                            updateCmd.Parameters.AddWithValue("@TotalRevenue", totalRevenue);
                                            updateCmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                                            updateCmd.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        string insertQuery = @"
                                            INSERT INTO Revenue ([date], total_booking, total_revenue)
                                            VALUES (@SelectedDate, @TotalBooking, @TotalRevenue)";
                                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                        {
                                            insertCmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                                            insertCmd.Parameters.AddWithValue("@TotalBooking", totalBooking);
                                            insertCmd.Parameters.AddWithValue("@TotalRevenue", totalRevenue);
                                            insertCmd.ExecuteNonQuery();
                                        }
                                    }
                                }

                                labelStatus.Text = $"Revenue calculated for {selectedDate.ToShortDateString()}: {totalRevenue:C} from {totalBooking} bookings.";
                                labelStatus.ForeColor = System.Drawing.Color.Green;
                            }
                            else
                            {
                                labelStatus.Text = "No paid bookings found for the selected date.";
                                labelStatus.ForeColor = System.Drawing.Color.Orange;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Error calculating revenue: " + ex.Message;
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT revenue_id, [date], total_booking, total_revenue FROM Revenue ORDER BY [date] DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRevenue.DataSource = dt;

                    dataGridViewRevenue.Columns["revenue_id"].HeaderText = "Revenue ID";
                    dataGridViewRevenue.Columns["date"].HeaderText = "Date";
                    dataGridViewRevenue.Columns["total_booking"].HeaderText = "Total Bookings";
                    dataGridViewRevenue.Columns["total_revenue"].HeaderText = "Total Revenue";
                    dataGridViewRevenue.Columns["total_revenue"].DefaultCellStyle.Format = "C";

                    if (dt.Rows.Count == 0)
                    {
                        labelStatus.Text = "No revenue data available.";
                        labelStatus.ForeColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        labelStatus.Text = "Revenue report loaded successfully.";
                        labelStatus.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Error loading report: " + ex.Message;
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
