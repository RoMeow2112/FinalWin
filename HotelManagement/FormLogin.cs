using HotelManagement.Models;
using HotelManagement.Repositories;
using HotelManagement.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            UserRepository userRepo = new UserRepository();
            User user = userRepo.Login(username, password);
            EmployeeRepository employeeRepository = new EmployeeRepository();

            if (user != null)
            {
                // Cập nhật LastLogin
                userRepo.UpdateLastLogin(user.UserID);
                Employees employee = employeeRepository.GetById(user.EmployeeID);

                MessageBox.Show("Đăng nhập thành công!");

                if (user.Role == "Quản lý")
                {
                    FormManager form = new FormManager();
                    form.Show();
                }
                else if (user.Role == "Tiếp tân")
                {
                    MainForm form = new MainForm();
                    form.Show();
                }
                else if (user.Role == "Lao công")
                {
                    FormCleaner form = new FormCleaner(user.EmployeeID, employee.Name, user.Role);
                    form.Show();
                }

                // Giả sử đã lấy được user và employee từ database sau login thành công
                CurrentLogin.EmployeeID = user.EmployeeID;
                CurrentLogin.EmployeeName = employee.Name;
                CurrentLogin.Role = user.Role;

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        public static class CurrentLogin
        {
            public static int EmployeeID { get; set; }
            public static string EmployeeName { get; set; }
            public static string Role { get; set; }

            // Bạn có thể thêm các thông tin khác nếu cần
        }

    }
}
