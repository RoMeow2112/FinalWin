using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagement
{
    public class DB
    {
        private SqlConnection con = new SqlConnection(@"Server=DESKTOP-KR5CTG2;Database=HotelManagement;Integrated Security=True;");

        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}