using System;
using System.Data;
using System.Data.SqlClient;

namespace DemoADO.NET.Models
{
    public class SqlProvider
    {
        String _connectionString;
        public String ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
        // Hàm chạy câu lệnh SELECT
        public DataTable LoadData(string selectCommandText)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(selectCommandText, connection);
            DataTable table = new DataTable();
            connection.Open();
            IDataReader reader = command.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connection.Close();
            return table;
        }
        // Hàm chạy StoredProcedure
        public int Execute(SqlCommand command)
        {
            int res = -1;
            command.Connection = new SqlConnection(_connectionString);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection.Open();
            res = command.ExecuteNonQuery();
            command.Connection.Close();
            return res;
        }
    }
}