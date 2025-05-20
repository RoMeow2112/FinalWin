using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelManagement.Repositories
{
    public class EmployeeRepository
    {
        DB _db = new DB();

        // Lấy tất cả nhân viên
        public List<Employees> GetAll()
        {
            string query = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);

            _db.openConnection();

            List<Employees> employees = new List<Employees>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employees employee = new Employees
                {
                    EmployeeID = (int)reader["EmployeeID"],
                    Name = (string)reader["Name"],
                    Position = (string)reader["Position"],
                    HourlyRate = (decimal)reader["HourlyRate"],
                    Status = (string)reader["Status"],
                    DateHired = (DateTime)reader["DateHired"]
                };
                employees.Add(employee);
            }

            reader.Close();
            _db.closeConnection();

            return employees;
        }

        public Employees GetById(int employeeId)
        {
            Employees emp = null;
            string query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

            _db.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                emp = new Employees()
                {
                    EmployeeID = (int)reader["EmployeeID"],
                    Name = reader["Name"].ToString(),
                    Position = reader["Position"].ToString(),
                    HourlyRate = Convert.ToDecimal(reader["HourlyRate"]),
                    DateHired = reader["DateHired"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(reader["DateHired"]),
                    Status = reader["Status"].ToString()
                };
            }
            reader.Close();
            _db.closeConnection();

            return emp;
        }


        // Thêm nhân viên mới
        public bool Add(Employees employee)
        {
            string query = @"INSERT INTO Employees (Name, Position, HourlyRate, Status, DateHired)
                     VALUES (@Name, @Position, @HourlyRate, @Status, @DateHired)";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@Name", employee.Name);
            cmd.Parameters.AddWithValue("@Position", employee.Position);
            cmd.Parameters.AddWithValue("@HourlyRate", employee.HourlyRate);
            cmd.Parameters.AddWithValue("@Status", employee.Status);
            cmd.Parameters.AddWithValue("@DateHired", employee.DateHired);

            _db.openConnection();
            int rowsAffected = cmd.ExecuteNonQuery();
            _db.closeConnection();

            return rowsAffected > 0;
        }


        // Sửa thông tin nhân viên
        public bool Update(Employees employee)
        {
            using (SqlConnection conn = _db.getConnection)
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Update Employees
                    string updateEmpQuery = @"
                UPDATE Employees
                SET Position = @Position, Status = @Status, HourlyRate = @HourlyRate
                WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand cmdEmp = new SqlCommand(updateEmpQuery, conn, transaction))
                    {
                        cmdEmp.Parameters.AddWithValue("@Position", employee.Position);
                        cmdEmp.Parameters.AddWithValue("@Status", employee.Status);
                        cmdEmp.Parameters.AddWithValue("@HourlyRate", employee.HourlyRate);
                        cmdEmp.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

                        int rowsEmp = cmdEmp.ExecuteNonQuery();
                        if (rowsEmp == 0)
                            throw new Exception("Không tìm thấy nhân viên để cập nhật.");
                    }

                    // Update Role trong bảng Users (giả sử Role trùng với Position)
                    string updateUserQuery = @"
                UPDATE Users
                SET Role = @Role
                WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand cmdUser = new SqlCommand(updateUserQuery, conn, transaction))
                    {
                        cmdUser.Parameters.AddWithValue("@Role", employee.Position);
                        cmdUser.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

                        int rowsUser = cmdUser.ExecuteNonQuery();
                        if (rowsUser == 0)
                            throw new Exception("Không tìm thấy tài khoản user để cập nhật.");
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    // Có thể log lỗi ex.Message tại đây
                    return false;
                }
            }
        }




        // Xóa nhân viên
        public bool Delete(int employeeID)
        {
            using (SqlConnection conn = _db.getConnection)
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Xóa ca làm
                    using (SqlCommand cmdShift = new SqlCommand("DELETE FROM Shifts WHERE EmployeeID=@EmployeeID", conn, transaction))
                    {
                        cmdShift.Parameters.AddWithValue("@EmployeeID", employeeID);
                        cmdShift.ExecuteNonQuery();
                    }

                    // Xóa lương
                    using (SqlCommand cmdSalary = new SqlCommand("DELETE FROM Salary WHERE EmployeeID=@EmployeeID", conn, transaction))
                    {
                        cmdSalary.Parameters.AddWithValue("@EmployeeID", employeeID);
                        cmdSalary.ExecuteNonQuery();
                    }

                    // Xóa tài khoản user
                    using (SqlCommand cmdUser = new SqlCommand("DELETE FROM Users WHERE EmployeeID=@EmployeeID", conn, transaction))
                    {
                        cmdUser.Parameters.AddWithValue("@EmployeeID", employeeID);
                        cmdUser.ExecuteNonQuery();
                    }

                    // Xóa nhân viên
                    using (SqlCommand cmdEmp = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@EmployeeID", conn, transaction))
                    {
                        cmdEmp.Parameters.AddWithValue("@EmployeeID", employeeID);
                        int rows = cmdEmp.ExecuteNonQuery();
                        if (rows == 0)
                            throw new Exception("Không tìm thấy nhân viên.");
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }


    }
}
