using System;

namespace HotelManagement.Models
{
    public class User
    {
        public int UserID;
        public int EmployeeID;
        public string Username;
        public string Password;
        public string Role;
        public bool IsActive;
        public DateTime? LastLogin;
        public byte[] FaceID { get; set; }
    }
}
