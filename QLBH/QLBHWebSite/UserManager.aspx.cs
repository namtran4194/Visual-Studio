using System;
using System.Web.UI.WebControls;
using BussinessLogicLayer;
using DataAccessLayer;

public partial class UserManager : System.Web.UI.Page
{
    private PermissionBll _pBll = new PermissionBll();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.DataItem != null)
        {
            Permission p = _pBll.GetPermission(int.Parse(e.Row.Cells[2].Text));
            e.Row.Cells[2].Text = p.Ten;
        }
    }
}