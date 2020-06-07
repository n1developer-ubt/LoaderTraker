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
    public partial class UserInput : UserControl
    {
        public delegate void Action(string c);

        public event Action ActionPerformed;

        public UserInput()
        {
            InitializeComponent();
        }

        private readonly int _size = 80;
        private readonly int _padding = 3;
        private string _inputs = "";
        public string Inputs
        {
            get => _inputs;
            set
            {
                if (pnlInputs == null)
                    return;
                pnlInputs.Controls.Clear();
                foreach (char c in value)
                {
                    pnlInputs.Controls.Add(GetInputButton(c.ToString()));
                }

                this.Width = _padding * (_size + 2 * _padding);
                Height =(int) Math.Round(value.Length / (_padding + 0.0)) * (_size + 2 * _padding);
                _inputs = value;
            }
        }

        private Button GetInputButton(string text)
        {
            var button = new Button()
            {
                Text =  text,
                Margin = new Padding(_padding),
                Size = new Size(_size,_size)
            };

            button.Click += ButtonOnClick;

            if (text.Equals("<"))
            {
                button.Text = "<--";
                if(Do)
                    button.Size = new Size(_size * 4 + 2 * 3 * _padding, _size);
                button.BackColor = Color.Red;
            }
            return button;
        }

        public bool Do = true;

        private void ButtonOnClick(object sender, EventArgs e)
        {
            if(sender is Control c)
                ActionPerformed?.Invoke(c.Text);
        }
    }
}
