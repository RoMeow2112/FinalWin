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
using System.Configuration;

namespace HotelManagement
{
    public partial class AddNewRoom: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;
        public AddNewRoom()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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

                string query = "INSERT INTO Rooms (room_number, room_capacity, room_price, room_status) " + "VALUES (@RoomNumber, @Capacity, @Price, @Status); " + "SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", textBoxRoomNumber.Text);
                    command.Parameters.AddWithValue("@Capacity", numericUpDownCapacity.Value);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Status", "Available"); 

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
