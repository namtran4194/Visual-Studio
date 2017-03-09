using System;
using BussinessLogicLayer;

public partial class Register : System.Web.UI.Page
{
    private UserBll _userBll = new UserBll();
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (_userBll.GetUser(TextBox1.Text) != null)
        {
            Label2.Text = "Tên đăng nhập đã tồn tại!";
            return;
        }
        if (!TextBox2.Text.Equals(TextBox3.Text))
        {
            Label2.Text = "Mật khẩu nhập lại không khớp!";
            return;

        }
        bool result = _userBll.AddNewUser(TextBox1.Text, TextBox2.Text, TextBox4.Text, TextBox5.Text);
        if (result)
        {
            Session["NotifCode"] = 3;
            Response.Redirect("~/Notification.aspx");
        }
        else
        {
            Label2.Text = "Đăng kí không thành công!";
        }
    }
}