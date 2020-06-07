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
    public partial class SelectedProduct : UserControl
    {
        public string Value
        {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public SelectedProduct()
        {
            InitializeComponent();
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
