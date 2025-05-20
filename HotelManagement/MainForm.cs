using HotelManagement.Employee;
using HotelManagement.Models;
using HotelManagement.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagement.FormLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagement
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            RoomManagement roomManagement = new RoomManagement();
            roomManagement.Show();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.Show();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            BookingBillManagement bookingBillManagement = new BookingBillManagement();
            bookingBillManagement.Show();
        }

        private void buttonFoods_Click(object sender, EventArgs e)
        {
            FoodManagement foodsManagement = new FoodManagement();
            foodsManagement.Show();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.Show();
        }

        private void buttonRevenue_Click(object sender, EventArgs e)
        {
            DailyRevenueReport dailyRevenueReport = new DailyRevenueReport();
            dailyRevenueReport.Show();
        }

        int empId = CurrentLogin.EmployeeID;
        string empName = CurrentLogin.EmployeeName;
        string role = CurrentLogin.Role;


        private void button1_Click(object sender, EventArgs e)
        {

            FormCleaner formCleaner = new FormCleaner(CurrentLogin.EmployeeID, CurrentLogin.EmployeeName, CurrentLogin.Role);
            formCleaner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegisterFace formRegisterFace = new FormRegisterFace(CurrentLogin.EmployeeID);
            formRegisterFace.Show();
        }
    }
}
