using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoaderTraker.Properties;
using Newtonsoft.Json;

namespace LoaderTraker
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();

            cbUsers.DisplayMember = "Username";
            cbUsers.ValueMember = "Password";
            if (!Settings.Default.Users.Trim().Equals(""))
            {
                var users = JsonConvert.DeserializeObject<List<SystemUser>>(Settings.Default.Users);
                cbUsers.DataSource = users;
            }

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (cbUsers.SelectedItem == null)
            {
                MessageBox.Show("Please Select User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbUsers.SelectedItem is SystemUser u)
            {
                using (InputTaker taker = new InputTaker())
                {
                    taker.ShowDialog();

                    if (taker.Value != null)
                    {
                        if (taker.Value.ToLower().Equals(u.Password.ToLower()))
                        {
                            using (LiciencePlate p = new LiciencePlate(u.Username))
                            {
                                p.ShowDialog();
                            }
                        }
                        else
                            MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
