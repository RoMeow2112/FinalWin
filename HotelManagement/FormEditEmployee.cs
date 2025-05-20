using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelManagement.Models;
using HotelManagement.Repositories;

namespace HotelManagement.EmployeeForms
{
    public partial class FormEditEmployee : Form
    {
        private int employeeId;
        private EmployeeRepository repo = new EmployeeRepository();

        private Dictionary<string, decimal> salaryByPosition = new Dictionary<string, decimal>()
        {
            { "Tiếp tân", 60000m },
            { "Lao công", 40000m }
        };

        private List<string> statusList = new List<string>()
        {
            "Đang làm",
            "Tạm nghỉ",
            "Nghỉ việc"
        };

        public FormEditEmployee(int empId)
        {
            InitializeComponent();

            employeeId = empId;

            // Cài đặt ComboBox Position
            cbbPosition.Items.Clear();
            cbbPosition.Items.AddRange(new string[] { "Tiếp tân", "Lao công" });
            cbbPosition.SelectedIndexChanged += CbbPosition_SelectedIndexChanged;

            // Cài đặt ComboBox Status
            cbbStatus.Items.Clear();
            cbbStatus.Items.AddRange(statusList.ToArray());

            numHourlyRate.Minimum = 0;
            numHourlyRate.Maximum = 1000000;
            numHourlyRate.ReadOnly = true;
            numHourlyRate.Enabled = false; // Không cho chỉnh tay

            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            Employees emp = repo.GetById(employeeId);
            if (emp == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblEditingEmployee.Text = $"Editing employee: {emp.Name}";

            // Gán dữ liệu vào form
            // Position
            int posIndex = cbbPosition.Items.IndexOf(emp.Position);
            if (posIndex >= 0) cbbPosition.SelectedIndex = posIndex;
            else cbbPosition.SelectedIndex = 0;

            // Status
            int statusIndex = cbbStatus.Items.IndexOf(emp.Status);
            if (statusIndex >= 0) cbbStatus.SelectedIndex = statusIndex;
            else cbbStatus.SelectedIndex = 0;

            // HourlyRate theo position
            if (salaryByPosition.ContainsKey(emp.Position))
                numHourlyRate.Value = salaryByPosition[emp.Position];
            else
                numHourlyRate.Value = 0;
        }

        private void CbbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPos = cbbPosition.SelectedItem?.ToString();
            if (selectedPos != null && salaryByPosition.ContainsKey(selectedPos))
            {
                numHourlyRate.Value = salaryByPosition[selectedPos];
            }
            else
            {
                numHourlyRate.Value = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees()
            {
                EmployeeID = employeeId,
                Position = cbbPosition.SelectedItem.ToString(),
                Status = cbbStatus.SelectedItem.ToString(),
                HourlyRate = numHourlyRate.Value
            };

            bool success = repo.Update(emp);
            if (success)
            {
                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
