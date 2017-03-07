using DemoADO.NET.Models;
using System;
using System.Web.UI.WebControls;

namespace DemoADO.NET
{
    public partial class DanhSachLienHe : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            buttonAdd.Click += delegate
            {
                Model.DataTable.Rows.InsertAt(Model.DataTable.NewRow(), 0);
                EditIndex = 0;
            };
            buttonFilter.Click += delegate
            {
                Model.Select(string.Format("Ten Like N'{0}%'", textFilter.Text));
                EditIndex = -1;
                textFilter.Text = "";
            };
            dataList1.ItemCommand += new DataListCommandEventHandler(dataList1_ItemCommand);
        }
        void dataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            EditIndex = e.CommandName == "Edit" ? e.Item.ItemIndex : -1;
        }
        int EditIndex
        {
            get { return dataList1.EditItemIndex; }
            set
            {
                dataList1.EditItemIndex = value;
                dataList1.DataSource = Model.DataTable;
                dataList1.DataBind();
            }
        }
        public BaseModel Model
        {
            get { return (BaseModel)Session["model"]; }
            set { Session["model"] = value; EditIndex = -1; }
        }
    }
}
