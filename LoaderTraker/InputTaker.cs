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
    public partial class InputTaker : Form
    {
        public string Value { get; set; } = null;
        public InputTaker(string title = "", bool isPassword = true, string buttons = "123456789A0B", bool Do = true)
        {
            InitializeComponent();
            txtPassword.isPassword = isPassword;
            if (!title.Equals(""))
                Text = title;
            userInput1.Do = Do;
            userInput1.Inputs = buttons;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Value = txtPassword.Text;
            Hide();
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
    }
}
