using DemoADO.NET.Models;
using System;
using System.Configuration;
using System.Web.UI;

namespace DemoADO.NET
{
    public partial class _Default : Page
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