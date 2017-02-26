using System;
using System.Data;
using System.Data.SqlClient;

namespace DemoADO.NET.Models
{
    public class SoDiaChiModel : BaseModel
    {
        public SoDiaChiModel()
        {
            _selectCommandText = "select * from LienHe";
        }
        protected override DataTable DoSelect(string selectCommandText)
        {
            DataTable table = base.DoSelect(selectCommandText);
            table.Columns[0].AutoIncrement = false;
            table.Columns[0].DefaultValue = 0;
            table.Columns.Add("HoTen", Type.GetType("System.String"), "Ho + ' ' + Ten");
            return table;
        }
        protected override void SetCommandParameters(SqlCommand command, object[] values)
        {
            command.CommandText = "UpdateLienHe";
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters.Add("@Ho", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NamSinh", SqlDbType.NVarChar, 4);
            command.Parameters.Add("@DienThoai", SqlDbType.NVarChar, 15);
            command.Parameters.Add("@EMail", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 2000);
            command.Parameters[0].Direction = ParameterDirection.InputOutput;
            base.SetCommandParameters(command, values);
        }
    }
}