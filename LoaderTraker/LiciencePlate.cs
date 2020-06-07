using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoaderTraker
{
    public partial class LiciencePlate : Form
    {
        private readonly string _username;
        public LiciencePlate(string username ="")
        {
            _username = username;
            InitializeComponent();
        }

        private void userInput1_ActionPerformed(string c)
        {
            if (c.Equals("<--"))
            {
                if (txtPassword.isEmptyOrHint())
                    return;

                if (txtPassword.Text.Length <= 1)
                {
                    txtPassword.Text = txtPassword.Hint;
                    return;
                }

                txtPassword.Text = txtPassword.Text.Substring(0, txtPassword.Text.Length - 1);


                return;
            }

            if (txtPassword.isEmptyOrHint())
                txtPassword.Text = c;
            else
                txtPassword.Text += c;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            using(MainEmployee em = new MainEmployee(_username, txtPassword.Text))
            {
                em.ShowDialog();
            }
        }
    }
}
