using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataProvider
    {
        private string connString = ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;
        private SqlConnection conn;

        public DataProvider()
        {
        }

        public DataTable GetData(string sql, params SqlParameter[] parameter)
        {
            OpenConnection();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(parameter);
            table.Load(command.ExecuteReader());
            CloseConnection();
            return table;
        }

        public void UpdateData(string sql, params SqlParameter[] parameter)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(parameter);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        private void OpenConnection()
        {
            conn = new SqlConnection(connString);
            conn.Open();
        }

        private void CloseConnection()
        {
            conn.Close();
        }
    }
}
