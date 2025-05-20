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

namespace HotelManagement.Employee
{
    public partial class FormCleaner : Form
    {
        private int employeeId;
        private string employeeName;
        private string position;
        public FormCleaner(int empId, string empName, string empPosition)
        {
            InitializeComponent();

            employeeId = empId;
            employeeName = empName;
            position = empPosition;

            lblEmployeeInfo.Text = $"Hello {employeeName} ({position})";

            LoadUpcomingShifts();
        }

        private void LoadUpcomingShifts()
        {
            ShiftRepository repo = new ShiftRepository();
            var shifts = repo.GetUpcomingShifts(employeeId, position);
            dgvShifts.DataSource = shifts;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvShifts.CurrentRow == null)
            {
                MessageBox.Show("Please select a shift to check-in.");
                return;
            }

            int shiftId = (int)dgvShifts.CurrentRow.Cells["ShiftID"].Value;

            ShiftRepository repo = new ShiftRepository();
            bool success = repo.CheckInShift(shiftId, DateTime.Now);

            if (success)
            {
                MessageBox.Show("Check-in successful.");
                LoadUpcomingShifts();
            }
            else
            {
                MessageBox.Show("Check-in failed.");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dgvShifts.CurrentRow == null)
            {
                MessageBox.Show("Please select a shift to check-out.");
                return;
            }

            int shiftId = (int)dgvShifts.CurrentRow.Cells["ShiftID"].Value;

            ShiftRepository repo = new ShiftRepository();
            bool success = repo.CheckOutShift(shiftId, DateTime.Now);

            if (success)
            {
                MessageBox.Show("Check-out successful.");
                LoadUpcomingShifts();
            }
            else
            {
                MessageBox.Show("Check-out failed.");
            }
        }



    }
}
