using HotelManagement.EmployeeForms;
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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();

            LoadShiftsByDate(DateTime.Today);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelNhanVien.Visible = true;
            panelCaLam.Visible = false;
            panelLuong.Visible = false;
        }

        private void btnCalam_Click(object sender, EventArgs e)
        {
            panelNhanVien.Visible = false;
            panelCaLam.Visible = true;
            panelLuong.Visible = false;
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            panelNhanVien.Visible = false;
            panelCaLam.Visible = false;
            panelLuong.Visible = true;
        }

        // FormManager.cs
        private void LoadEmployees()
        {
            EmployeeRepository repo = new EmployeeRepository();
            var employees = repo.GetAll(); // Lấy toàn bộ nhân viên từ repository

            dgvEmployees.DataSource = employees; // Gán danh sách nhân viên vào DataGridView
        }

        // FormManager.cs
        private void LoadShiftsToday()
        {
            ShiftRepository repo = new ShiftRepository();
            var list = repo.GetShiftsByDate(DateTime.Today);

            dgvShifts.AutoGenerateColumns = true;   // buộc tự sinh
            dgvShifts.DataSource = null;
            dgvShifts.DataSource = list;
        }



        // FormManager.cs
        private void LoadSalariesToday()
        {
            SalaryRepository repo = new SalaryRepository();
            DateTime today = DateTime.Today;  // Lấy ngày hôm nay

            var salaries = repo.GetSalariesByDate(today);  // Get tất cả lương hôm nay
            dgvSalaries.DataSource = salaries; // Hiển thị trong DataGridView
        }


        private void FormManager_Load(object sender, EventArgs e)
        {
            LoadEmployees();  // Tải danh sách nhân viên
            LoadShiftsToday(); // Tải bảng ca làm hôm nay
            LoadSalariesToday(); // Tải bảng lương hôm nay
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAdd = new FormAddEmployee();
            formAdd.ShowDialog();

            LoadEmployees(); // Load lại danh sách nhân viên sau khi thêm
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy EmployeeID của nhân viên được chọn
            int empId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

            // Tạo và mở form sửa, truyền EmployeeID qua constructor
            FormEditEmployee formEdit = new FormEditEmployee(empId);
            formEdit.ShowDialog();

            // Sau khi đóng form sửa, load lại danh sách nhân viên
            LoadEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Please select an employee to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int empId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);
            string empName = dgvEmployees.CurrentRow.Cells["Name"].Value.ToString();

            var confirm = MessageBox.Show($"Are you sure you want to delete employee: {empName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                EmployeeRepository repo = new EmployeeRepository();
                bool success = repo.Delete(empId);
                if (success)
                {
                    MessageBox.Show("Employee deleted successfully.");
                    LoadEmployees();  // Load lại dữ liệu sau khi xóa
                }
                else
                {
                    MessageBox.Show("Failed to delete employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi thêm ca làm.");
                return;
            }

            int empId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);
            string empName = dgvEmployees.CurrentRow.Cells["Name"].Value.ToString();

            FormAddShift formAddShift = new FormAddShift(empId, empName);
            if (formAddShift.ShowDialog() == DialogResult.OK)
            {
                // Nếu muốn load lại ca làm cho nhân viên đó thì bạn gọi hàm tương ứng
                // Ví dụ LoadShiftsByEmployee(empId);
            }
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            DateTime tomorrow = currentShiftDate.AddDays(1);
            LoadShiftsByDate(tomorrow);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            DateTime yesterday = currentShiftDate.AddDays(-1);
            LoadShiftsByDate(yesterday);
        }

        private void LoadShiftsByDate(DateTime date)
        {
            ShiftRepository repo = new ShiftRepository();
            var shifts = repo.GetShiftsByDate(date);
            dgvShifts.DataSource = shifts;

            currentShiftDate = date;
            dtpShiftDate.Value = date;
        }

        private DateTime currentShiftDate = DateTime.Today;

        private void dtpShiftDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpShiftDate.Value.Date;
            LoadShiftsByDate(selectedDate);
        }

        private DateTime currentSalaryDate = DateTime.Today;

        private void LoadSalariesByDate(DateTime date)
        {
            SalaryRepository repo = new SalaryRepository();
            var salaries = repo.GetSalariesByDate(date);
            dgvSalaries.DataSource = salaries;

            currentSalaryDate = date;
            dtpSalaryDate.Value = date;
        }

        private void btnSalaryYesterday_Click(object sender, EventArgs e)
        {
            DateTime yesterday = currentSalaryDate.AddDays(-1);
            LoadSalariesByDate(yesterday);
        }
        private void btnSalaryTomorrow_Click(object sender, EventArgs e)
        {
            DateTime tomorrow = currentSalaryDate.AddDays(1);
            LoadSalariesByDate(tomorrow);
        }
        private void dtpSalaryDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpSalaryDate.Value.Date;
            LoadSalariesByDate(selectedDate);
        }
        private void DgvSalaries_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSalaries.IsCurrentCellDirty)
            {
                dgvSalaries.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void DgvSalaries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra cột IsPaid (giả sử cột có index là 6 hoặc tên "IsPaid")
            if (e.RowIndex >= 0 && dgvSalaries.Columns[e.ColumnIndex].Name == "IsPaid")
            {
                int salaryId = (int)dgvSalaries.Rows[e.RowIndex].Cells["SalaryID"].Value;
                bool isPaid = (bool)dgvSalaries.Rows[e.RowIndex].Cells["IsPaid"].Value;

                // Cập nhật database
                SalaryRepository repo = new SalaryRepository();
                bool success = repo.UpdateIsPaid(salaryId, isPaid);

                if (!success)
                {
                    MessageBox.Show("Update payment status failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
