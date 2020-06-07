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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

            var users = Settings.Default.Users;

            if (!users.Trim().Equals(""))
            {
                var systemUsers = JsonConvert.DeserializeObject<List<SystemUser>>(users);

                foreach (SystemUser user in systemUsers)
                {
                    pnlSystemUserContainer.Controls.Add(new SystemUserControl(user.Username, user.Password){ Dock = DockStyle.Top });
                }
            }
            txtCompanyName.Text = Settings.Default.CompanyName.Equals("")?txtCompanyName.Hint: Settings.Default.CompanyName;
            txtAddress1.Text = Settings.Default.Address1.Equals("")?txtAddress1.Hint: Settings.Default.Address1;
            txtAddress2.Text = Settings.Default.Address2.Equals("")?txtAddress2.Hint: Settings.Default.Address2;
            LoadProducts();
            LoadTicketData();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            pnlSystemUserContainer.Controls.Add(new SystemUserControl(){Dock = DockStyle.Top});
        }

        private void LoadTicketData()
        {
            if(Settings.Default.SalesHistory.Trim().Equals(""))
                return;

            var data = JsonConvert.DeserializeObject<List<TicketData>>(Settings.Default.SalesHistory);

            foreach (TicketData t in data)
            {
                dgvTickerData.Rows.Add(t.CompanyName, t.Address1, t.Address2, t.Date.ToString("dd/mm/yyyy HH:mm"),
                    t.Code, t.Client, t.Username, string.Join(", ", t.Products));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var updatedUsers = pnlSystemUserContainer.Controls.OfType<SystemUserControl>().ToList();
            Settings.Default.Users = JsonConvert.SerializeObject(updatedUsers.Where(x=>
                !(x.User.Username.Trim().Equals("") || x.User.Password.Trim().Equals(""))).Select(x => x.User).ToList());
            Settings.Default.Save();
            MessageBox.Show("Settings Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveOtherSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.CompanyName = txtCompanyName.Text;
            Settings.Default.Address1= txtAddress1.Text;
            Settings.Default.Address2= txtAddress2.Text;
            SettingSaved();
        }

        private void LoadProducts()
        {
            txtProducts.Text = Settings.Default.Products;
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            Settings.Default.Products = txtProducts.Text.Trim();
            SettingSaved();
        }

        private void SettingSaved()
        {
            Settings.Default.Save();
            MessageBox.Show("Other Setting Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            Settings.Default.SalesHistory = "";
            Settings.Default.Save();
            dgvTickerData.Rows.Clear();
        }
    }
}
