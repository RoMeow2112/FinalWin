using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelManagement.Repositories
{
    public class ReportRepository
    {
        private readonly DB _db;

        public ReportRepository(DB db)
        {
            _db = db;
        }

        public (decimal TotalDue, decimal TotalPaid) GetSalarySummary(DateTime date)
        {
            decimal totalDue = 0;
            decimal totalPaid = 0;

            string query = @"
                SELECT 
                    SUM(CASE WHEN IsPaid = 0 THEN SalaryAmount ELSE 0 END) AS TotalDue,
                    SUM(CASE WHEN IsPaid = 1 THEN SalaryAmount ELSE 0 END) AS TotalPaid
                FROM Salary
                WHERE CAST(DatePaid AS DATE) = @Date";

            SqlCommand cmd = new SqlCommand(query, _db.getConnection);

            cmd.Parameters.AddWithValue("@Date", date.Date);

            try
            {
                _db.openConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    totalDue = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                    totalPaid = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                }
                reader.Close();
            }
            finally
            {
                _db.closeConnection();
            }

            return (totalDue, totalPaid);
        }

        public List<SalaryReportItem> GetEmployeesByShift(DateTime date, string shiftType)
        {
            List<SalaryReportItem> list = new List<SalaryReportItem>();

            string query = @"
                SELECT s.ShiftType, e.Name
                FROM Shifts s
                INNER JOIN Employees e ON s.EmployeeID = e.EmployeeID
                WHERE CAST(s.ShiftDate AS DATE) = @Date AND s.ShiftType = @ShiftType";

            SqlCommand cmd = new SqlCommand(query, _db.getConnection);

            cmd.Parameters.AddWithValue("@Date", date.Date);
            cmd.Parameters.AddWithValue("@ShiftType", shiftType);

            try
            {
                _db.openConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SalaryReportItem
                    {
                        ShiftType = reader.GetString(0),
                        EmployeeName = reader.GetString(1)
                    });
                }
                reader.Close();
            }
            finally
            {
                _db.closeConnection();
            }

            return list;
        }
    }
}
