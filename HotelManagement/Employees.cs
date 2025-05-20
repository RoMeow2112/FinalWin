using System;

namespace HotelManagement.Models
{
    public class Employees
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }  // Nhân viên, Lao công, Quản lý
        public decimal HourlyRate { get; set; }
        public string Status { get; set; }  // Đang làm, Đã nghỉ việc
        public DateTime DateHired { get; set; }

        public Employees() { }
    }
}
