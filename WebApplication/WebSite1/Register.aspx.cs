using System;

public partial class Register : System.Web.UI.Page
{
    DataProcess registerProc = new DataProcess();
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (registerProc.isUsernameExisted(TextBox1.Text))
        {
            Label2.Text = "Tên đăng nhập đã tồn tại!";
            return;
        }
        if (!TextBox2.Text.Equals(TextBox3.Text))
        {
            Label2.Text = "Mật khẩu nhập lại không khớp!";
            return;

        }
        bool result = registerProc.Register(TextBox1.Text, TextBox2.Text, TextBox4.Text, TextBox5.Text);
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