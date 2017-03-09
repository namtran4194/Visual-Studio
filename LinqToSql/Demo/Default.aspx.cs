using System;
using System.Linq;

namespace Demo
{
    public partial class Default : System.Web.UI.Page
    {
        private QLBanHangDataContext _context = new QLBanHangDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = _context.Quyens;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Quyen q = new Quyen();
            q.Ma = int.Parse(TextBox1.Text);
            q.Ten = TextBox2.Text;
            try
            {
                _context.Quyens.InsertOnSubmit(q);
                _context.SubmitChanges();
                Response.Redirect(Request.RawUrl);
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            };
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Quyen q = _context.Quyens.Where(q1 => q1.Ma == int.Parse(TextBox3.Text)).FirstOrDefault();
            try
            {
                _context.Quyens.DeleteOnSubmit(q);
                _context.SubmitChanges();
                Response.Redirect(Request.RawUrl);
            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message;
            }
        }
    }
}