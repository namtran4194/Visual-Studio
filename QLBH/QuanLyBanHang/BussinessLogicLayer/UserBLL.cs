using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogicLayer
{
    public class UserBll
    {
        private DataProvider _provider = new DataProvider();

        // lấy thông tin người dùng
        public User GetUser(string username, string password)
        {
            var sql = "CheckingLogIn";
            var paramUser = new SqlParameter("username", username);
            var paramPassword = new SqlParameter("password", password);
            var table = _provider.GetData(sql, true, paramUser, paramPassword);
            if (table.Rows.Count <= 0) return null;
            return CreateUser(table.Rows[0]);
        }

        // lấy thông tin người dùng
        public User GetUser(string username)
        {
            var sql = "select * from NguoiDung where TenDangNhap=@username";
            var paramUser = new SqlParameter("username", username);
            var table = _provider.GetData(sql, paramUser);
            if (table.Rows.Count <= 0) return null;
            return CreateUser(table.Rows[0]);
        }

        // thêm người dùng mới vào database
        public bool AddNewUser(string username, string password, string email, string fullname)
        {
            var sql = "insert into NguoiDung(MaQuyen, TenDangNhap, MatKhau, Email, HoTen) values(2, @tendangnhap, @matkhau, @email, @hoten)";
            var paramUser = new SqlParameter("tendangnhap", username);
            var paramPassword = new SqlParameter("matkhau", password);
            var paramEmail = new SqlParameter("email", email);
            var paramFullName = new SqlParameter("hoten", fullname);
            return _provider.UpdateData(sql, paramUser, paramPassword, paramEmail, paramFullName);
        }

        // thay đổi mật khẩu
        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            var sql = "update NguoiDung set MatKhau=@newPassword where TenDangNhap=@username and MatKhau=@oldPassword";
            var paramUser = new SqlParameter("username", username);
            var paramOldPassword = new SqlParameter("oldPassword", oldPassword);
            var paramNewPassword = new SqlParameter("newPassword", newPassword);
            return _provider.UpdateData(sql, paramUser, paramOldPassword, paramNewPassword);
        }

        // lấy quyền của người dùng
        public int GetPermissionCode(string username)
        {
            var user = GetUser(username);
            return user.MaQuyen;
        }

        // tạo đối tượng người dùng từ 1 hàng chứa các thông tin của người dùng
        private User CreateUser(DataRow row)
        {
            var user = new User
            {
                Ma = (int)row["Ma"],
                MaQuyen = (int)row["MaQuyen"],
                TenDangNhap = (string)row["TenDangNhap"],
                MatKhau = (string)row["MatKhau"],
                HoTen = (string)row["HoTen"],
                Email = (string)row["Email"]
            };
            return user;
        }
    }
}