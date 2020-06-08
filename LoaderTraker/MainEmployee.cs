using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraReports.UI;
using LoaderTraker.Properties;

namespace LoaderTraker
{
    public partial class MainEmployee : Form
    {

        public MainEmployee(string username = "", string liciencePlate = "")
        {
            InitializeComponent();
            lblLiciencePlate.Text= liciencePlate;
            lblUsername.Text = username;
            foreach (var currentProduct in Settings.Default.Products.Split('\n'))
            {
                pnlProducts.Controls.Add(GetButton(currentProduct.Trim()));
            }
        }

        private Button GetButton(string text)
        {
            var button = new Button()
            {
                Text = text,
                Size = new Size(120, 60)
            };
            button.Click += ButtonOnClick;
            return button;
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                using(InputTaker taker = new InputTaker(b.Text, false, "123456789<0T", false))
                {
                    taker.ShowDialog();

                    if (taker.Value != null)
                    {
                        if (taker.Value.Length < 5 || taker.Value[1] != 'T' || taker.Value.Count(x=>x=='T') != 1 )
                        {
                            MessageBox.Show("Icorrect Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int val = Convert.ToInt32(GetInt(taker.Value));

                        if (val > 50)
                        {
                            var result = MessageBox.Show("Weight is greater than 50 KG\nAre you sure to proceed?", "Vérification",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result != DialogResult.Yes)
                                return;
                        }

                        var lbl = new SelectedProduct() {Dock = DockStyle.Top, Value= b.Text + "\t     " + taker.Value};
                        //lbl.AutoSize = false;
                        //lbl.DoubleClick +=LblOnDoubleClick;
                        pnlSelectedProducts.Controls.Add(lbl);
                    }
                }
                BringToFront();
            }
        }

        private void LblOnDoubleClick(object sender, EventArgs e)
        {
            if(sender is Label l)
                pnlSelectedProducts.Controls.Remove(l);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            TicketData data = new TicketData()
            {
                Address2 = Settings.Default.Address2,
                Address1 = Settings.Default.Address1,
                Client = lblLiciencePlate.Text,
                CompanyName = Settings.Default.CompanyName,
                Date = DateTime.Now,
                Products = pnlSelectedProducts.Controls.OfType<SelectedProduct>().Select(x=>x.Value).ToList(),
                Code = "LT"+DateTime.Now.ToString("yyyyMMdd")+"-"+GetSerial()+"-"+ pnlSelectedProducts.Controls.OfType<Label>().Select(x=>Convert.ToInt32(GetInt(x.Text))).Sum(),
                Username = lblUsername.Text
            };
            Ticket t = new Ticket(data);
            t.Print();
            this.Close();
        }

        private string GetInt(string x)
        {
            string r = "0";

            foreach (char c in x)
            {
                if (char.IsDigit(c))
                    r += c;
            }

            return r;
        }
        private readonly string _filePath = Path.Combine(Application.StartupPath, "Serial");
        private int GetSerial()
        {
            if (!File.Exists(_filePath))
                File.WriteAllText(_filePath,"1");

            string data = File.ReadAllText(_filePath);

            try
            {
                int dx = Convert.ToInt16(data);

                File.WriteAllText(_filePath, (dx + 1)+"");
                return dx;
            }
            catch (Exception e)
            {
                File.WriteAllText(_filePath,"1");
                return 1;
            }
        }
    }
}
