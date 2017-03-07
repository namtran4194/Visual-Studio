using System;
using System.Data;
using System.Data.SqlClient;

namespace DemoADO.NET.Models
{
    public class BaseModel : SqlProvider
    {
        protected String _selectCommandText;
        DataTable _table;
        public DataTable DataTable
        {
            get { return _table; }
            set { _table = value; }
        }
        // Đọc dữ liệu
        public DataTable Select()
        {
            return DoSelect(_selectCommandText);
        }
        public DataTable Select(string filter)
        {
            String sql = _selectCommandText;
            if (!String.IsNullOrWhiteSpace(filter)) sql += " where " + filter;
            return DoSelect(sql);
        }
        protected virtual DataTable DoSelect(string selectCommandText)
        {
            _table = LoadData(selectCommandText);
            foreach (DataColumn column in _table.Columns) column.ReadOnly = false;
            return _table;
        }
        // Cập nhật dữ liệu
        DataRow _editRow;
        public DataRow EditRow
        {
            get { return _editRow; }
            set { _editRow = value; }
        }
        public void Insert(Object[] values) { DoUpdate(values, 1); }
        public void Update(Object[] values) { DoUpdate(values, 0); }
        public void Delete() { DoUpdate(_editRow.ItemArray, -1); }
        protected virtual void SetCommandParameters(
        SqlCommand command, Object[] values)
        {
            for (int i = 0; i < command.Parameters.Count; i++)
                command.Parameters[i].Value = values[i];
        }
        protected void DoUpdate(Object[] values, Int32 action)
        {
            SqlCommand command = new SqlCommand();
            SetCommandParameters(command, values);
            command.Parameters.Add("@ThaoTac", SqlDbType.Int).Value = action;
            if (Execute(command) == 0) return;
            if (action >= 0)
            {
                _editRow.ItemArray = values;
                if (action == 1)
                {
                    _editRow[0] = command.Parameters[0].Value;
                    if (_editRow.RowState == DataRowState.Detached)
                        _table.Rows.Add(_editRow);
                }
            }
            else
                _editRow.Delete();
            _table.AcceptChanges();
        }

    }
}