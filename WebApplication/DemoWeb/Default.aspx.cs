using System;
using System.Data;
using System.Collections;
using System.Xml;
using System.Web.UI;
using Demo.Entity;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Configuration;

namespace Demo
{
    public partial class _Default : Page
    {
        int CheckPoint(ListControl listControl)
        {
            foreach (ListItem item in listControl.Items)
                if (item.Selected ^ (item.Text != item.Value)) return 0;
            return 1;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            #region Đọc dữ liệu từ file xml hiển thị lên bảng
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(MapPath(@"\App_Data\Person.xml"));

            ArrayList list = new ArrayList();
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                list.Add(new Person(node.FirstChild.InnerText, node.LastChild.InnerText));
            }

            dataGrid.DataSource = list;
            dataGrid.DataBind();
            #endregion

            #region Sử dụng Basic Web Controls
            if (!IsPostBack)
            {
                radioButtonList1.Items.Add(new ListItem("runat=\"server\""));
                radioButtonList1.Items.Add(new ListItem("AutoPostBack=\"true\"", "1"));
                radioButtonList1.Items.Add(new ListItem("AutoPostBack=\"false\""));
            }
            button1.Click += delegate
            {
                int point = CheckPoint(checkBoxList1) + CheckPoint(radioButtonList1);
                if (textBox1.Text.ToUpper() == "TEXT") point++;

                label1.Text = string.Format("Trả lời đúng {0}/3 câu hỏi", point);
            };
            #endregion

            #region Sử dụng Repeater, DataList và DataGrid để thể hiện dữ liệu trong file XML
            if (!IsPostBack)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath(@"App_Data\News.xml"));
                listControl1.DataSource = ds.Tables["BaiViet"];
                listControl1.DataBind();
                Application["BaiViet"] = listControl1.DataSource;
            }
            #endregion

            #region Login control
            label2.Text = "";
            login1.OnLogin += delegate
            {
                if (login1.UserName != "vuhaiminh" || login1.Password != "08092012")
                {
                    label2.Text = "Sai tên người dùng hoặc mật khẩu";
                    label2.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label2.Text = "Đăng nhập thành công";
            };
            #endregion

            #region Đọc cấu hình
            //// Cách 1
            //Configuration cf = WebConfigurationManager.OpenWebConfiguration("~/");
            //string selectCommandText = cf.AppSettings.Settings["selectPerson"].Value;
            //string connString = cf.ConnectionStrings.ConnectionStrings["cnn"].ConnectionString;
            //// Cách 2
            //selectCommandText = ConfigurationManager.AppSettings["selectPerson"];
            //connString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            #endregion
        }

        protected void listControl1_ItemCommand(object sender, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                DataTable table = (DataTable)Application["BaiViet"];
                table.Rows.RemoveAt(e.Item.ItemIndex);

                listControl1.DataSource = table;
                listControl1.DataBind();
            }
        }

    }
}