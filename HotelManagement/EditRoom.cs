using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement
{
    public partial class EditRoom: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;
        private int roomId;
        private RoomManagement roomManagement;
        public EditRoom(int roomId, RoomManagement roomManagement)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.roomManagement = roomManagement;
            connection = new SqlConnection(connectionString);
            LoadRoomDetails();
        }
        private void LoadRoomDetails()
        {
            try
            {
                string query = "SELECT * FROM Rooms WHERE room_id = @RoomId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBoxRoomNumber.Text = reader["room_number"].ToString();
                        numericUpDownCapacity.Value = Convert.ToInt32(reader["room_capacity"]);
                        textBoxPrice.Text = reader["room_price"].ToString();
                        string status = reader["room_status"].ToString();
                        radioButtonAvailable.Checked = (status == "Available");
                        radioButtonOccupied.Checked = (status == "Occupied");
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxRoomNumber.BackColor = Color.White;
                textBoxPrice.BackColor = Color.White;

                bool hasEmptyField = false;
                if (string.IsNullOrWhiteSpace(textBoxRoomNumber.Text))
                {
                    textBoxRoomNumber.BackColor = Color.LightPink;
                    hasEmptyField = true;
                }
                if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
                {
                    textBoxPrice.BackColor = Color.LightPink;
                    hasEmptyField = true;
                }

                if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
                {
                    textBoxPrice.BackColor = Color.LightPink;
                    hasEmptyField = true;
                }

                if (hasEmptyField)
                {
                    MessageBox.Show("Please fill in all required fields with valid values!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string status = radioButtonAvailable.Checked ? "Available" : "Occupied";
                string query = "UPDATE Rooms SET room_number = @RoomNumber, room_capacity = @Capacity, " + "room_price = @Price, room_status = @Status WHERE room_id = @RoomId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", textBoxRoomNumber.Text);
                    command.Parameters.AddWithValue("@Capacity", numericUpDownCapacity.Value);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@RoomId", roomId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Deletion", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Rooms WHERE room_id = @RoomId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomId", roomId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        DialogResult = DialogResult.OK;
                        Close();

                        // Làm mới danh sách phòng trong RoomManagement
                        if (roomManagement != null)
                        {
                            roomManagement.LoadRooms("All");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
