using System;

public partial class Login : System.Web.UI.Page
{
    DataProcess logInProc = new DataProcess();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool isLoggedIn = logInProc.CheckingLogIn(TextBox1.Text, TextBox2.Text);
        if (isLoggedIn)
        {
            Session["LoginStatus"] = true;
            Session["Username"] = TextBox1.Text;
            Session["Name"] = logInProc.GetName(TextBox1.Text);
            Response.Redirect("Home.aspx");
        }
        else
        {
            Label2.Visible = true;
        }
    }
}