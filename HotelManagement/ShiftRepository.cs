using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelManagement.Repositories
{
    public class ShiftRepository
    {
        DB _db = new DB();

        // Lấy ca làm của ngày hôm nay
        public List<Shift> GetShiftsByDate(DateTime date)
        {
            string query = "SELECT * FROM Shifts WHERE ShiftDate = @date";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@date", date.Date);

            _db.openConnection();

            List<Shift> shifts = new List<Shift>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Shift shift = new Shift
                {
                    ShiftID = (int)reader["ShiftID"],
                    EmployeeID = (int)reader["EmployeeID"],
                    ShiftType = reader["ShiftType"].ToString(),
                    ShiftDate = (DateTime)reader["ShiftDate"],
                    ShiftStartTime = reader["ShiftStartTime"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["ShiftStartTime"],
                    ShiftEndTime = reader["ShiftEndTime"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["ShiftEndTime"],
                    HoursWorked = reader["HoursWorked"] == DBNull.Value ? 0 : (decimal)reader["HoursWorked"],
                    IsSubstitute = (bool)reader["IsSubstitute"]
                };
                shifts.Add(shift);
            }

            reader.Close();
            _db.closeConnection();

            return shifts;
        }


        // Thêm ca làm mới
        public bool Add(Shift shift)
        {
            string query = @"
    INSERT INTO Shifts (EmployeeID, ShiftType, ShiftDate, ShiftStartTime, ShiftEndTime, HoursWorked, IsSubstitute)
    VALUES (@EmployeeID, @ShiftType, @ShiftDate, @ShiftStartTime, @ShiftEndTime, @HoursWorked, @IsSubstitute)";

            SqlCommand cmd = new SqlCommand(query, _db.getConnection);

            cmd.Parameters.AddWithValue("@EmployeeID", shift.EmployeeID);
            cmd.Parameters.AddWithValue("@ShiftType", shift.ShiftType);
            cmd.Parameters.AddWithValue("@ShiftStartTime", DBNull.Value);  // NULL lúc thêm
            cmd.Parameters.AddWithValue("@ShiftEndTime", DBNull.Value);    // NULL lúc thêm
            cmd.Parameters.AddWithValue("@HoursWorked", 0);
            cmd.Parameters.AddWithValue("@IsSubstitute", shift.IsSubstitute);
            cmd.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);

            _db.openConnection();
            int rows = cmd.ExecuteNonQuery();
            _db.closeConnection();

            return rows > 0;
        }

        public List<Shift> GetUpcomingShifts(int employeeId, string position)
        {
            string query = @"
        SELECT * FROM Shifts s
        JOIN Employees e ON s.EmployeeID = e.EmployeeID
        WHERE s.EmployeeID = @EmployeeID 
          AND e.Position = @Position
          AND (s.ShiftEndTime IS NULL OR CAST(s.ShiftDate AS DATE) >= CAST(GETDATE() AS DATE))
        ORDER BY s.ShiftDate, s.ShiftType";

            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@Position", position);

            _db.openConnection();

            List<Shift> shifts = new List<Shift>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Shift shift = new Shift()
                {
                    ShiftID = (int)reader["ShiftID"],
                    EmployeeID = (int)reader["EmployeeID"],
                    ShiftType = (string)reader["ShiftType"],
                    ShiftDate = (DateTime)reader["ShiftDate"],
                    ShiftStartTime = reader["ShiftStartTime"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["ShiftStartTime"],
                    ShiftEndTime = reader["ShiftEndTime"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["ShiftEndTime"],
                    HoursWorked = reader["HoursWorked"] == DBNull.Value ? 0 : (decimal)reader["HoursWorked"],
                    IsSubstitute = (bool)reader["IsSubstitute"]
                };
                shifts.Add(shift);
            }
            reader.Close();
            _db.closeConnection();

            return shifts;
        }

        public bool CheckInShift(int shiftId, DateTime checkInTime)
        {
            string query = "UPDATE Shifts SET ShiftStartTime = @CheckInTime WHERE ShiftID = @ShiftID";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@CheckInTime", checkInTime);
            cmd.Parameters.AddWithValue("@ShiftID", shiftId);

            _db.openConnection();
            int rows = cmd.ExecuteNonQuery();
            _db.closeConnection();

            return rows > 0;
        }

        public bool CheckOutShift(int shiftId, DateTime checkOutTime)
        {
            string query = "UPDATE Shifts SET ShiftEndTime = @CheckOutTime WHERE ShiftID = @ShiftID";
            SqlCommand cmd = new SqlCommand(query, _db.getConnection);
            cmd.Parameters.AddWithValue("@CheckOutTime", checkOutTime);
            cmd.Parameters.AddWithValue("@ShiftID", shiftId);

            _db.openConnection();
            int rows = cmd.ExecuteNonQuery();
            _db.closeConnection();

            return rows > 0;
        }


    }
}
