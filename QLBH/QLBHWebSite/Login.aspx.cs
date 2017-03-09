using BussinessLogicLayer;
using System;

public partial class Login : System.Web.UI.Page
{
    private UserBll _userBll = new UserBll();

    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var user = _userBll.GetUser(TextBox1.Text, TextBox2.Text);
        if (user != null)
        {
            Session["LoginStatus"] = true;
            Session["Username"] = TextBox1.Text;
            Session["Name"] = _userBll.GetUser(TextBox1.Text).HoTen;
            Response.Redirect("Home.aspx");
        }
        else
        {
            Label2.Visible = true;
        }
    }
}