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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();

            cbPosition.Items.Clear();
            cbPosition.Items.AddRange(new string[] { "Tiếp tân", "Lao công" });
            cbPosition.SelectedIndex = 0;

            cbPosition.SelectedIndexChanged += cbbPosition_SelectedIndexChanged;

        }

        private Dictionary<string, decimal> salaryByPosition = new Dictionary<string, decimal>()
{
    { "Tiếp tân", 60000m },
    { "Lao công", 40000m },
};

        private void cbbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPos = cbPosition.SelectedItem?.ToString();
            if (selectedPos != null && salaryByPosition.ContainsKey(selectedPos))
            {
                numHourlyRate.Maximum = 1000000;
                numHourlyRate.Value = salaryByPosition[selectedPos];
            }
            else
            {
                numHourlyRate.Value = 0; // Hoặc giá trị mặc định khác
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees()
            {
                Name = txtName.Text.Trim(),
                Position = cbPosition.SelectedItem.ToString(),
                HourlyRate = numHourlyRate.Value,
                DateHired = dtpDateHired.Value,
                Status = "Đang làm"   // Mặc định trạng thái mới
            };

            // Gọi repository để thêm vào DB
            EmployeeRepository repo = new EmployeeRepository();
            bool success = repo.Add(emp);

            if (success)
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                this.Close();  // Đóng form thêm
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
