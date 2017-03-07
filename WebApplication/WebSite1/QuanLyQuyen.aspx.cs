using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuanLyQuyen : System.Web.UI.Page
{
    DataProcess quyenProc = new DataProcess();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            updateView();
        }
    }

    private void updateView()
    {
        GridView1.DataSource = quyenProc.GetListPermission();
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool result = quyenProc.AddPermission(int.Parse(TextBox1.Text), TextBox2.Text);
        if (result)
        {
            Label2.Text = "Thêm thành công!";
            updateView();
        }
        else
        {
            Label2.Text = "Thêm không thành công!";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        bool result = quyenProc.RemovePermission(int.Parse(TextBox3.Text));
        if (result)
        {
            Label3.Text = "Xóa thành công!";
            updateView();
        }
        else
        {
            Label3.Text = "Xóa không thành công!";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        bool result = quyenProc.EditPermission(int.Parse(TextBox4.Text), TextBox5.Text);
        if (result)
        {
            Label4.Text = "Sửa thành công!";
            updateView();
        }
        else
        {
            Label4.Text = "Sửa không thành công!";
        }
    }
}