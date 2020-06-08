using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UBTStandardLibrary.Dialog;
using UBTStandardLibrary.Forms;

namespace LoaderTraker
{
    public partial class RoleSelectionWindow : Form
    {
        public RoleSelectionWindow()
        {
            InitializeComponent();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            var input = new InputDialog("Veuillez saisir votre mot de passe", new List<Input>(){new Input(){Hint = "Password",Type = InputType.Password,Index = 0,Name = "password"}},new N1Form(), ToolBoxProp.Exit);
            if (input.ShowIt() == ResultType.OK)
            {
                if (input.Output.Find(x => x.Name.Equals("password")).Value.Equals("n1developer"))
                {
                    using (AdminPanel panel = new AdminPanel())
                    {
                        panel.ShowDialog();
                    }
                }
            }

            BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            using(EmployeeLogin login = new EmployeeLogin())
            {
                login.ShowDialog();
            }
        }
    }
}
