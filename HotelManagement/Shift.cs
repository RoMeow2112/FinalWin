using System;

namespace HotelManagement.Models
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public int EmployeeID { get; set; }

        public DateTime? ShiftDate { get; set; }
        public DateTime? ShiftStartTime { get; set; }  // Thay đổi thành Nullable
        public DateTime? ShiftEndTime { get; set; }    // Thay đổi thành Nullable
        public decimal HoursWorked { get; set; }
        public string ShiftType { get; set; } // Morning / Evening / Night
        public bool IsSubstitute { get; set; } // Để phân biệt nếu là người thay ca

        public Shift() { }
    }
}
