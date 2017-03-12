using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblNotif.Text = "";
    }


    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        FormView1.ChangeMode(FormViewMode.Edit);
    }

    protected void LinkButton2_Click1(object sender, EventArgs e)
    {
        FormView1.ChangeMode(FormViewMode.Insert);
    }

    protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
    {
        if(e.Exception != null)
        {
            lblNotif.Text = e.Exception.Message;
            e.ExceptionHandled = true;
        }
    }
}