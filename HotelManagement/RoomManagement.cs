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
    public partial class RoomManagement: Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-KR5CTG2;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly string logoPath = @"C:\Users\nguye\Downloads\logo.jpg";
        public RoomManagement()
        {
            InitializeComponent();
            LoadRooms();
            LoadLogo();
        }
        private void LoadLogo()
        {
            try
            {
                if (File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                    pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Logo not found at: " + logoPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when loading logo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadRooms(string status = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT room_id, room_number, room_capacity, room_price, room_status FROM Rooms";
                    if (!string.IsNullOrEmpty(status))
                    {
                        query += " WHERE room_status = @status";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(status))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewRoom.DataSource = dt;

                    dataGridViewRoom.ReadOnly = true;
                    dataGridViewRoom.Columns["room_id"].HeaderText = "ID Room";
                    dataGridViewRoom.Columns["room_number"].HeaderText = "Room Number";
                    dataGridViewRoom.Columns["room_capacity"].HeaderText = "Capacity";
                    dataGridViewRoom.Columns["room_price"].HeaderText = "Price per night";
                    dataGridViewRoom.Columns["room_status"].HeaderText = "Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when loading Room list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string status = null;
            if (radioButtonAvailable.Checked)
            {
                status = "Available";
            }
            else if (radioButtonOccupied.Checked)
            {
                status = "Occupied";
            }
            else if (radioButtonAll.Checked)
            {
                status = null;
            }

            LoadRooms(status);
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            AddNewRoom addNewRoom = new AddNewRoom();
            if (addNewRoom.ShowDialog() == DialogResult.OK)
            {
                LoadRooms();
            }
        }

        private void dataGridViewRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int roomId = Convert.ToInt32(dataGridViewRoom.Rows[e.RowIndex].Cells["room_id"].Value);
                EditRoom editRoom = new EditRoom(roomId, this);
                if (editRoom.ShowDialog() == DialogResult.OK)
                {
                    LoadRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening EditRoom: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadRooms();
        }
    }
}
