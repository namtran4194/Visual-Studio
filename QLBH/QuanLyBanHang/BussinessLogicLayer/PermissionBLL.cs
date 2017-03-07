using DataAccessLayer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogicLayer
{
    public class PermissionBLL
    {
        DataProvider provider = new DataProvider();

        // lấy danh sách các quyền
        public List<Permission> PermissionList()
        {
            string sql = "select * from Quyen";
            DataTable table = provider.GetData(sql);

            List<Permission> permissions = new List<Permission>();
            foreach (DataRow row in table.Rows)
            {
                Permission p = new Permission();
                p.Ma = (int)row[0];
                p.Ten = (string)row[1];
                permissions.Add(p);
            }
            return permissions;
        }

        // thêm quyền mới
        public void AddPermission(int code, string name)
        {
            string sql = "insert into Quyen values(@code, @name)";
            SqlParameter paramCode = new SqlParameter("code", code);
            SqlParameter paramName = new SqlParameter("name", name);
            provider.UpdateData(sql, paramCode, paramName);
        }
    }
}
