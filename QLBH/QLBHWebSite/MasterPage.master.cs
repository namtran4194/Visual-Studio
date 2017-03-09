using System;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Application["visit"].ToString();
        bool loginStatus = (bool)Session["LoginStatus"];
        if (loginStatus)
        {
            Label lblChao = new Label();
            lblChao.Text = "Chào " + Session["Name"] + ", ";

            HyperLink hplChgPwd = new HyperLink();
            hplChgPwd.Text = "Đổi mật khẩu";
            hplChgPwd.NavigateUrl = "~/ChangePassword.aspx";

            LinkButton logout = new LinkButton();
            logout.Text = "Thoát";
            logout.Click += Logout_Click;

            tdChao.Controls.Add(lblChao);
            tdChao.Controls.Add(hplChgPwd);
            tdChao.Controls.Add(logout);
        }
        else
        {
            Label lblChao = new Label();
            lblChao.Text = "Chào khách, ";

            HyperLink hplLogin = new HyperLink();
            hplLogin.Text = "Đăng nhập";
            hplLogin.NavigateUrl = "Login.aspx";

            HyperLink hplRegister = new HyperLink();
            hplRegister.Text = "Đăng ký";
            hplRegister.NavigateUrl = "~/Register.aspx";

            tdChao.Controls.Add(lblChao);
            tdChao.Controls.Add(hplLogin);
            tdChao.Controls.Add(hplRegister);
        }
    }

    private void Logout_Click(object sender, EventArgs e)
    {
        Session["LoginStatus"] = false;
        Response.Redirect(Request.RawUrl);
    }
}