using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoaderTraker
{
    public partial class SystemUserControl : UserControl
    {
        private static string Allowed = "123456789A0B";
        public SystemUserControl(string username = "", string password = "")
        {

            InitializeComponent();
            if (!username.Trim().Equals("") && !password.Trim().Equals(""))
            {
                txtUsername.Text = username;
                txtPassword.Text = password;
            }
        }

        public SystemUser User => new SystemUser() { Password = txtPassword.isEmptyOrHint()?"":txtPassword.Text, Username = txtUsername.isEmptyOrHint()?"":txtUsername.Text.Trim() };

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPassword.isEmptyOrHint())
                return;

            string result = "";

            foreach (char c in txtPassword.Text)
            {
                if (Allowed.ToLower().Contains(c.ToString().ToLower()))
                    result += c;
            }

            txtPassword.Text = result;
        }
    }
}
