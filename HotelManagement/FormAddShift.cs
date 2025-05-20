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

namespace HotelManagement.EmployeeForms
{
    public partial class FormAddShift : Form
    {
        private int employeeId;
        private string employeeName;

        public FormAddShift(int empId, string empName)
        {
            InitializeComponent();

            employeeId = empId;
            employeeName = empName;

            lblEmployeeName.Text = $"Add shift for: {employeeName}";

            // Thêm các ca làm vào ComboBox
            cbbShiftType.Items.AddRange(new string[] { "Morning", "Evening", "Night" });
            cbbShiftType.SelectedIndex = 0;

            // Thiết lập mặc định ngày ca làm là hôm nay
            dtpShiftDate.Value = DateTime.Today;

            // Sự kiện nút lưu
            btnSave.Click += BtnSave_Click;

            // Nút hủy
            btnCancel.Click += (s, e) => this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string selectedShiftType = cbbShiftType.SelectedItem.ToString();

            Shift shift = new Shift()
            {
                EmployeeID = employeeId,
                ShiftType = selectedShiftType,
                ShiftDate = dtpShiftDate.Value.Date,     // Lấy ngày chọn từ DateTimePicker
                ShiftStartTime = null,                    // Chưa check-in
                ShiftEndTime = null,                      // Chưa check-out
                HoursWorked = 0,
                IsSubstitute = false
            };

            ShiftRepository repo = new ShiftRepository();
            bool success = repo.Add(shift);

            if (success)
            {
                MessageBox.Show("Added shift successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add shift.");
            }
        }
    }

}
