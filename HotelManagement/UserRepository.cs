using System;
using System.Data.SqlClient;
using HotelManagement.Models;

namespace HotelManagement.Repositories
{
    public class UserRepository
    {
        DB db = new DB();

        public User Login(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password); // đang để mật khẩu thường

            db.openConnection();

            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;

            if (reader.Read())
            {
                user = new User();
                user.UserID = (int)reader["UserID"];
                user.EmployeeID = (int)reader["EmployeeID"];
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.Role = reader["Role"].ToString();
                user.IsActive = (bool)reader["IsActive"];
                user.LastLogin = reader["LastLogin"] is DBNull ? null : (DateTime?)reader["LastLogin"];
            }

            reader.Close();
            db.closeConnection();

            return user;
        }

        public void UpdateLastLogin(int userID)
        {
            string query = "UPDATE Users SET LastLogin = GETDATE() WHERE UserID = @id";
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.AddWithValue("@id", userID);

            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
