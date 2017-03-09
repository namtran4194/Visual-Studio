using DataAccessLayer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogicLayer
{
    public class PermissionBll
    {
        private DataProvider _provider = new DataProvider();

        // lấy danh sách các quyền
        public List<Permission> PermissionList()
        {
            const string sql = "select * from Quyen";
            var table = _provider.GetData(sql);

            var permissions = new List<Permission>();
            foreach (DataRow row in table.Rows)
            {
                var p = new Permission
                {
                    Ma = (int)row[0],
                    Ten = (string)row[1]
                };
                permissions.Add(p);
            }
            return permissions;
        }

        // thêm quyền mới
        public bool AddPermission(int code, string name)
        {
            const string sql = "insert into Quyen values(@code, @name)";
            var paramCode = new SqlParameter("code", code);
            var paramName = new SqlParameter("name", name);
            return _provider.UpdateData(sql, paramCode, paramName);
        }

        // xóa quyền theo mã
        public bool RemovePermission(int code)
        {
            var sql = "RemovePermission";
            var param = new SqlParameter("code", code);
            return _provider.UpdateData(sql, true, param);
        }

        // sửa tên quyền
        public bool EditPermission(int code, string codeName)
        {
            var sql = "EditPermission";
            var paramCode = new SqlParameter("code", code);
            var paramName = new SqlParameter("codeName", codeName);
            return _provider.UpdateData(sql, true, paramCode, paramName);
        }
    }
}
