using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLogicLayer;
using DataAccessLayer;
using System.IO;

public partial class Uploader : System.Web.UI.Page
{
    private UploaderBll _upBll = new UploaderBll();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string fullPath = MapPath("~/ProductImages");
        string tenThat = Guid.NewGuid().ToString() + "." + FileUpload1.PostedFile.FileName.Split('.')[1];
        fullPath += "/" + tenThat;
        FileUpload1.PostedFile.SaveAs(fullPath);

        // lưu vào database
        _upBll.AddNewFile(tenThat, FileUpload1.PostedFile.FileName);
        GridView1.DataBind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)sender;
        Upload up = _upBll.GetFile(lbtn.CommandArgument);
        // xóa file trong folder
        FileInfo file = new FileInfo(Server.MapPath("~/ProductImages") + "/" + up.TenFileThat);
        file.Delete();
        // xóa file trong database 
        _upBll.DeleteFile(lbtn.CommandArgument);
        GridView1.DataBind();
    }
}