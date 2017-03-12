using BussinessLogicLayer;
using System;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

public partial class ProductManager : System.Web.UI.Page
{
    private ProductBll _prodBll = new ProductBll();
    private int productPerPage = 3;
    private int links = 10;

    protected void Page_Load(object sender, EventArgs e)
    {
        // kiểm tra đăng nhập
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

        // hiển thị dữ liệu
        List<SanPham> products = _prodBll.ProductList();
        int page = 1;
        if (!string.IsNullOrEmpty(Request.QueryString["Page"]))
        {
            page = int.Parse(Request.QueryString["Page"]);
        }
        DataList1.DataSource = products.Skip((page - 1) * productPerPage).Take(productPerPage);
        DataList1.DataBind();

        int leftSide = page - (links / 2);
        int rightSide = page + (links - links / 2) - 1;
        int totalPage = products.Count / productPerPage;
        if (products.Count % productPerPage != 0) totalPage++;
        for (int i = leftSide; i <= rightSide; i++)
        {
            if (i >= 1 && i <= totalPage)
            {
                HyperLink hpl = new HyperLink();
                hpl.Text = i.ToString();
                if (page != i) hpl.NavigateUrl = "~/ProductManager.aspx?page=" + i;
                tdPage.Controls.Add(hpl);
            }
        }
    }
}