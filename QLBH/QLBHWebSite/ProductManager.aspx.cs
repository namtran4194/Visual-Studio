using BussinessLogicLayer;
using System;
using DataAccessLayer;

public partial class ProductManager : System.Web.UI.Page
{
    private ProductBll _prodBll = new ProductBll();
    protected void Page_Load(object sender, EventArgs e)
    {
        UserBll userBll = new UserBll();
        if (!(bool)Session["LoginStatus"])
        {
            Session["NotifCode"] = 1;
            Response.Redirect("Notification.aspx");
        }

        int permission = userBll.GetPermissionCode(Session["Username"].ToString());
        if (permission != 1)
        {
            Session["NotifCode"] = 2;
            Response.Redirect("Notification.aspx");
        }

        DataList1.DataSource = _prodBll.ProductList();
        DataList1.DataBind();
    }
}