using System;

namespace HotelManagement.Models
{
    public class Salary
    {
        public int SalaryID { get; set; }
        public int EmployeeID { get; set; }
        public decimal TotalHours { get; set; }
        public decimal SalaryAmount { get; set; }
        public decimal PenaltyAmount { get; set; }
        public DateTime DatePaid { get; set; }
        public bool IsPaid { get; set; }

        public Salary() { }
    }
}
