using DemoADO.NET.Models;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoADO.NET
{
    public partial class FormEdit : System.Web.UI.UserControl
    {
        Control[] _controls;
        protected void Page_Load(object sender, EventArgs e)
        {
            _controls = new Control[] { textBox0, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            buttonCancel.Click += delegate
            {
                if (IsNew) Model.EditRow.Delete();
            };
            buttonDelete.Click += delegate
            {
                Model.Delete();
            };
            buttonUpdate.Click += delegate
            {
                object[] v = new object[8];
                for (int i = 1; i < _controls.Length; i++)
                    v[i] = GetValue(i);
                if (!IsNew)
                {
                    v[0] = Model.EditRow[0];
                    Model.Update(v);
                }
                else
                    Model.Insert(v);
            };
        }

        BaseModel Model
        {
            get { return (BaseModel)Session["model"]; }
        }
        bool IsNew { get { return textBox0.Text[0] == '0'; } }
        protected virtual object GetValue(int index)
        {
            string s = ((TextBox)_controls[index]).Text;
            if (string.IsNullOrWhiteSpace(s))
                return DBNull.Value;
            return s;
        }
        protected virtual void SetValue(int index, object value)
        {
            ((TextBox)_controls[index]).Text = value.ToString();
        }
        public DataRowView Data
        {
            set
            {
                Model.EditRow = value.Row;
                for (int i = 0; i < _controls.Length; i++)
                    SetValue(i, value[i]);
            }
        }
    }
}