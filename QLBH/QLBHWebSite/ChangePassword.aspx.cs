using System;
using BussinessLogicLayer;
public partial class ChangePassword : System.Web.UI.Page
{
    private UserBll _userBll = new UserBll();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(bool)Session["LoginStatus"])
        {
            Session["NotifCode"] = 1;
            Response.Redirect("~/Notification.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!TextBox2.Text.Equals(TextBox3.Text))
        {
            Label2.Text = "Nhập lại mật khẩu không khớp!";
            return;
        }
        bool isChanged = _userBll.ChangePassword(Session["Username"].ToString(), TextBox1.Text, TextBox2.Text);
        if (isChanged)
        {
            Session["NotifCode"] = 4;
            Response.Redirect("~/Notification.aspx");
        }
        else
        {
            Label2.Text = "Thay đổi mật khẩu không thành công";
        }
    }
}