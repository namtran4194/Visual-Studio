using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class Login : System.Web.UI.UserControl
    {
        public event EventHandler OnLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            button1.Click += delegate
            {
                if (OnLogin != null) OnLogin(this, new EventArgs());
            };
        }

        public string PasswordCaption { set { label2.Text = value; } }
        public string UserNameCaption { set { label1.Text = value; } }
        public string Password
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }
        public string UserName
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
    }
}