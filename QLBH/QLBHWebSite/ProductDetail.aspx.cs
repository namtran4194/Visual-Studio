using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLogicLayer;

public partial class ProductDetail : System.Web.UI.Page
{
    private ProductTypeBll _productBll = new ProductTypeBll();
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void FormView1_DataBound(object sender, EventArgs e)
    {
        Label label = (Label)FormView1.FindControl("MaLoaiLabel");
        label.Text = _productBll.GetProduct(int.Parse(label.Text)).Ten;
    }
}