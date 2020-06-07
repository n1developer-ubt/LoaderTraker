using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using ChangeEventArgs = DevExpress.XtraReports.UI.ChangeEventArgs;

namespace LoaderTraker
{
    public partial class Ticket : DevExpress.XtraReports.UI.XtraReport
    {
        public Ticket(TicketData t)
        {
            InitializeComponent();
            tblProducts.SizeChanged += TblProductsOnSizeChanged;
            lblAddress1.Text = t.Address1;
            lblAddress2.Text = t.Address2;
            lblClient.Text = "CLIENT: " + t.Client;
            lblCode.Text = t.Code;
            lblResponsible.Text = "Responsable: " + t.Username;
            lblNumberOfProducts.Text = "NOMBRE DE LIGNE: " + t.Products.Count.ToString();
            lblCompanyName.Text = t.ComapanyName;
            lblDateTime.Text = t.Date.ToString("MM/dd/yyyy hh:mm");
            foreach(var x in t.Products)
            {
                string[] l = x.Split('\t');
                if(l.Length < 2)
                    continue;
                
                tblProducts.Rows.Add(new XRTableRow()
                {
                    Cells =
                    {
                        new XRTableCell()
                        {
                            Text = l[0].Trim(),
                            TextAlignment = TextAlignment.MiddleLeft,
                            WidthF = 152.13f
                        },
                        new XRTableCell()
                        {
                            Text = l[1].Trim(),
                            TextAlignment = TextAlignment.MiddleLeft,
                            WidthF = 94.87f
                        },
                    }
                });
            }
            this.Height = this.Height + tblProducts.Height - 25;
        }

        private void TblProductsOnSizeChanged(object sender, ChangeEventArgs e)
        {
            
        }
    }
}
