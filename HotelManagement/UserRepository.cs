using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelManagement.Models;

namespace HotelManagement.Repositories
{
    public class UserRepository
    {
        DB db = new DB();

        public bool UpdateFaceID(int userId, byte[] faceIdData)
        {
            string query = @"UPDATE Users SET FaceID = @FaceID WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.AddWithValue("@FaceID", (object)faceIdData ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@UserID", userId);

            db.openConnection();
            int rowsAffected = cmd.ExecuteNonQuery();
            db.closeConnection();

            return rowsAffected > 0;
        }


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

        public List<User> GetAllUsersWithFaceID()
        {
            var users = new List<User>();

            string query = "SELECT UserID, EmployeeID, FaceID FROM Users WHERE FaceID IS NOT NULL";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            db.openConnection();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var user = new User()
                {
                    UserID = (int)reader["UserID"],
                    EmployeeID = (int)reader["EmployeeID"],
                    FaceID = reader["FaceID"] as byte[]
                };
                users.Add(user);
            }

            reader.Close();
            db.closeConnection();

            return users;
        }
    }
}
