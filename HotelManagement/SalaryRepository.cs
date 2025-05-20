using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelManagement.Repositories
{
    public class SalaryRepository
    {
        DB _db = new DB();

        // Lấy lương của ngày hôm nay
        public List<Salary> GetSalariesByDate(DateTime date)
        {
            string query = "SELECT * FROM Salary WHERE CAST(DatePaid AS DATE) = @date";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@date", date.Date);

            _db.openConnection();

            List<Salary> salaries = new List<Salary>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Salary salary = new Salary
                {
                    SalaryID = (int)reader["SalaryID"],
                    EmployeeID = (int)reader["EmployeeID"],
                    TotalHours = reader["TotalHoursWorked"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["TotalHoursWorked"]),
                    SalaryAmount = reader["SalaryAmount"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["SalaryAmount"]),
                    PenaltyAmount = reader["PenaltyAmount"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["PenaltyAmount"]),
                    DatePaid = reader["DatePaid"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["DatePaid"]),
                    IsPaid = reader["IsPaid"] == DBNull.Value ? false : Convert.ToBoolean(reader["IsPaid"])

                };
                salaries.Add(salary);
            }

            reader.Close();
            _db.closeConnection();

            return salaries;
        }

        // Thêm lương cho nhân viên
        public bool AddSalary(Salary salary)
        {
            string query = @"INSERT INTO Salary(EmployeeID, TotalHoursWorked, SalaryAmount, PenaltyAmount, DatePaid, IsPaid)
                             VALUES(@EmployeeID, @TotalHoursWorked, @SalaryAmount, @PenaltyAmount, @DatePaid, @IsPaid)";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@EmployeeID", salary.EmployeeID);
            cmd.Parameters.AddWithValue("@TotalHoursWorked", salary.TotalHours);
            cmd.Parameters.AddWithValue("@SalaryAmount", salary.SalaryAmount);
            cmd.Parameters.AddWithValue("@PenaltyAmount", salary.PenaltyAmount);
            cmd.Parameters.AddWithValue("@DatePaid", salary.DatePaid);
            cmd.Parameters.AddWithValue("@IsPaid", salary.IsPaid);

            _db.openConnection();
            bool isSuccess = cmd.ExecuteNonQuery() == 1;
            _db.closeConnection();
            return isSuccess;
        }

        public bool UpdateIsPaid(int salaryId, bool isPaid)
        {
            string query = "UPDATE Salary SET IsPaid = @IsPaid WHERE SalaryID = @SalaryID";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@IsPaid", isPaid);
            cmd.Parameters.AddWithValue("@SalaryID", salaryId);

            _db.openConnection();
            int rows = cmd.ExecuteNonQuery();
            _db.closeConnection();

            return rows > 0;
        }

    }
}
