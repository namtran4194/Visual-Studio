using BussinessLogicLayer;
using System;

public partial class PermissionManager : System.Web.UI.Page
{
    private PermissionBll _permBll = new PermissionBll();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            updateView();
        }
    }

    private void updateView()
    {
        GridView1.DataSource = _permBll.PermissionList();
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool result = _permBll.AddPermission(int.Parse(TextBox1.Text), TextBox2.Text);
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
        bool result = _permBll.RemovePermission(int.Parse(TextBox3.Text));
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
        bool result = _permBll.EditPermission(int.Parse(TextBox4.Text), TextBox5.Text);
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