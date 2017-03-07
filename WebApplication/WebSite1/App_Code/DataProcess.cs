using System.Configuration;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DataProcess
/// </summary>
public class DataProcess
{
    private string connString = ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;
    private SqlConnection conn;
    public DataProcess()
    {
    }

    public bool CheckingLogIn(string username, string password)
    {
        OpenConnection();
        SqlCommand command = new SqlCommand("CheckingLogIn", conn);
        command.Parameters.AddWithValue("username", username);
        command.Parameters.AddWithValue("password", password);
        command.CommandType = CommandType.StoredProcedure;
        SqlDataReader reader = command.ExecuteReader();
        bool isValid = false;
        if (reader.HasRows) isValid = true;
        CloseConnection();
        return isValid;
    }

    public bool Register(string username, string password, string email, string fullname)
    {
        OpenConnection();
        bool isSuccessed = false;
        string sql = "insert into NguoiDung(MaQuyen, TenDangNhap, MatKhau, Email, HoTen) values(2, @tendangnhap, @matkhau, @email, @hoten)";
        SqlCommand command = new SqlCommand(sql, conn);
        command.Parameters.AddWithValue("tendangnhap", username);
        command.Parameters.AddWithValue("matkhau", password);
        command.Parameters.AddWithValue("email", email);
        command.Parameters.AddWithValue("hoten", fullname);

        try
        {
            command.ExecuteNonQuery();
            isSuccessed = true;
        }
        catch { };
        CloseConnection();
        return isSuccessed;
    }

    public bool isUsernameExisted(string username)
    {
        OpenConnection();
        bool isExisted = false;
        string sql = "select * from NguoiDung where TenDangNhap=@username";
        SqlCommand command = new SqlCommand(sql, conn);
        command.Parameters.AddWithValue("username", username);
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows) isExisted = true;
        CloseConnection();
        return isExisted;
    }

    public bool ChangePassword(string username, string oldPassword, string newPassword)
    {
        OpenConnection();
        bool isChanged = false;
        string sql = "update NguoiDung set MatKhau=@newPassword where TenDangNhap=@username and MatKhau=@oldPassword";
        SqlCommand command = new SqlCommand(sql, conn);
        command.Parameters.AddWithValue("username", username);
        command.Parameters.AddWithValue("newPassword", newPassword);
        command.Parameters.AddWithValue("oldPassword", oldPassword);
        try
        {
            command.ExecuteNonQuery();
            isChanged = true;
        }
        catch { }
        CloseConnection();
        return isChanged;
    }

    public string GetName(string username)
    {
        OpenConnection();
        SqlCommand command = new SqlCommand("GetFullName", conn);
        command.Parameters.AddWithValue("username", username);
        command.CommandType = CommandType.StoredProcedure;
        string name = command.ExecuteScalar().ToString();
        CloseConnection();
        return name;
    }

    public int GetPermissionCode(string username)
    {
        OpenConnection();
        SqlCommand command = new SqlCommand("GetPermissionCode", conn);
        command.Parameters.AddWithValue("username", username);
        command.CommandType = CommandType.StoredProcedure;
        int code = (int)command.ExecuteScalar();
        CloseConnection();
        return code;
    }

    public DataTable GetListPermission()
    {
        DataTable list = new DataTable();
        OpenConnection();
        SqlCommand commmand = new SqlCommand("select * from Quyen", conn);
        SqlDataReader reader = commmand.ExecuteReader();
        list.Load(reader);
        CloseConnection();
        return list;
    }

    public bool AddPermission(int code, string codeName)
    {
        bool isSuccess = false;
        OpenConnection();
        SqlCommand command = new SqlCommand("AddPermission", conn);
        command.Parameters.AddWithValue("code", code);
        command.Parameters.AddWithValue("codeName", codeName);
        command.CommandType = CommandType.StoredProcedure;
        try
        {
            command.ExecuteNonQuery();
            isSuccess = true;
        }
        catch { };
        CloseConnection();
        return isSuccess;
    }

    public bool RemovePermission(int code)
    {
        bool isSuccess = false;
        OpenConnection();
        SqlCommand command = new SqlCommand("RemovePermission", conn);
        command.Parameters.AddWithValue("code", code);
        command.CommandType = CommandType.StoredProcedure;
        try
        {
            command.ExecuteNonQuery();
            isSuccess = true;
        }
        catch { };
        CloseConnection();
        return isSuccess;
    }

    public bool EditPermission(int code, string codeName)
    {
        bool isSuccessed = false;
        OpenConnection();
        SqlCommand command = new SqlCommand("EditPermission", conn);
        command.Parameters.AddWithValue("code", code);
        command.Parameters.AddWithValue("codeName", codeName);
        command.CommandType = CommandType.StoredProcedure;
        try
        {
            command.ExecuteNonQuery();
            isSuccessed = true;
        }
        catch { };
        CloseConnection();
        return isSuccessed;
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