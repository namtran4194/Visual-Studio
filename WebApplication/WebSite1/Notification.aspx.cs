using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Notification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        switch ((int)Session["NotifCode"])
        {
            case 1:
                Label2.Text = "Bạn cần đăng nhập để vào trang này";
                break;
            case 2:
                Label2.Text = "Bạn không có quyền truy cập trang này";
                break;
            case 3:
                Label2.Text = "Chúc mừng, bạn đã đăng kí thành công!";
                break;
            case 4:
                Label2.Text = "Thay đổi mật khẩu thành công!";
                break;
        }
    }
}