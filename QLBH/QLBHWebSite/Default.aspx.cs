using System;
using DataAccessLayer;
using BussinessLogicLayer;
public partial class _Default : System.Web.UI.Page
{
    PermissionBLL pbll = new PermissionBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = pbll.PermissionList();
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        pbll.AddPermission(int.Parse(TextBox1.Text), TextBox2.Text);
        Response.Redirect(Request.RawUrl);
    }
}