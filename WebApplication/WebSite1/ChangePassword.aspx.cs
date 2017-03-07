using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePassword : System.Web.UI.Page
{
    DataProcess changeProc = new DataProcess();
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
        bool isChanged = changeProc.ChangePassword(Session["Username"].ToString(), TextBox1.Text, TextBox2.Text);
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