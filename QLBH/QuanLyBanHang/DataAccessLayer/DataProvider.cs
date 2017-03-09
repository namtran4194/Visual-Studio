using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataProvider
    {
        private string _connString = ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;
        private SqlConnection _conn;
        private bool _storedProcedure = false;

        public DataTable GetData(string sql, params SqlParameter[] parameter)
        {
            OpenConnection();
            var table = new DataTable();
            var command = new SqlCommand(sql, _conn);
            command.Parameters.AddRange(parameter);
            if (_storedProcedure)
            {
                command.CommandType = CommandType.StoredProcedure;
                _storedProcedure = false;
            }
            table.Load(command.ExecuteReader());
            CloseConnection();
            return table;
        }

        public DataTable GetData(string sql, bool storedProcedure, params SqlParameter[] parameter)
        {
            _storedProcedure = storedProcedure;
            return GetData(sql, parameter);
        }

        public bool UpdateData(string sql, params SqlParameter[] parameter)
        {
            OpenConnection();
            var command = new SqlCommand(sql, _conn);
            command.Parameters.AddRange(parameter);
            if (_storedProcedure)
            {
                command.CommandType = CommandType.StoredProcedure;
                _storedProcedure = false;
            }
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { CloseConnection(); }
        }

        public bool UpdateData(string sql, bool storedProcedure, params SqlParameter[] parameter)
        {
            _storedProcedure = storedProcedure;
            return UpdateData(sql, parameter);
        }

        private void OpenConnection()
        {
            _conn = new SqlConnection(_connString);
            _conn.Open();
        }

        private void CloseConnection()
        {
            _conn.Close();
        }
    }
}
