using System;

public partial class QuanLySanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataProcess userProc = new DataProcess();
        if (!(bool)Session["LoginStatus"])
        {
            Session["NotifCode"] = 1;
            Response.Redirect("Notification.aspx");
        }

        int permission = userProc.GetPermissionCode(Session["Username"].ToString());
        if (permission != 1)
        {
            Session["NotifCode"] = 2;
            Response.Redirect("Notification.aspx");
        }
    }
}