using DemoADO.NET.Models;
using System;
using System.Configuration;

namespace DemoADO.NET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BaseModel model = new SoDiaChiModel();
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["cnn"];
                model.ConnectionString = css.ConnectionString;
                model.Select();
                danhSach.Model = model;
            }
        }
    }
}