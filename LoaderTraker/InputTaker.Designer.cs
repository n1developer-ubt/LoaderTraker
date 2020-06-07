namespace LoaderTraker
{
    partial class InputTaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputTaker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new UBTStandardLibrary.UBTTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCorrect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnValidate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userInput1 = new LoaderTraker.UserInput();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(269, 47);
            this.panel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtPassword.Hint = "Password";
            this.txtPassword.Index = -1;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(5, 5);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(259, 37);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(269, 53);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCorrect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnValidate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 43);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCorrect
            // 
            this.btnCorrect.Active = false;
            this.btnCorrect.Activecolor = System.Drawing.Color.Red;
            this.btnCorrect.BackColor = System.Drawing.Color.Red;
            this.btnCorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrect.BorderRadius = 0;
            this.btnCorrect.ButtonText = "CORRIGER";
            this.btnCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrect.DisabledColor = System.Drawing.Color.Gray;
            this.btnCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCorrect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCorrect.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCorrect.Iconimage")));
            this.btnCorrect.Iconimage_right = null;
            this.btnCorrect.Iconimage_right_Selected = null;
            this.btnCorrect.Iconimage_Selected = null;
            this.btnCorrect.IconMarginLeft = 0;
            this.btnCorrect.IconMarginRight = 0;
            this.btnCorrect.IconRightVisible = false;
            this.btnCorrect.IconRightZoom = 0D;
            this.btnCorrect.IconVisible = false;
            this.btnCorrect.IconZoom = 90D;
            this.btnCorrect.IsTab = false;
            this.btnCorrect.Location = new System.Drawing.Point(3, 3);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Normalcolor = System.Drawing.Color.Red;
            this.btnCorrect.OnHovercolor = System.Drawing.Color.Red;
            this.btnCorrect.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCorrect.selected = false;
            this.btnCorrect.Size = new System.Drawing.Size(123, 37);
            this.btnCorrect.TabIndex = 1;
            this.btnCorrect.Text = "CORRIGER";
            this.btnCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCorrect.Textcolor = System.Drawing.Color.White;
            this.btnCorrect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Active = false;
            this.btnValidate.Activecolor = System.Drawing.Color.Green;
            this.btnValidate.BackColor = System.Drawing.Color.Green;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidate.BorderRadius = 0;
            this.btnValidate.ButtonText = "VALIDER";
            this.btnValidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidate.DisabledColor = System.Drawing.Color.Gray;
            this.btnValidate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValidate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnValidate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnValidate.Iconimage")));
            this.btnValidate.Iconimage_right = null;
            this.btnValidate.Iconimage_right_Selected = null;
            this.btnValidate.Iconimage_Selected = null;
            this.btnValidate.IconMarginLeft = 0;
            this.btnValidate.IconMarginRight = 0;
            this.btnValidate.IconRightVisible = false;
            this.btnValidate.IconRightZoom = 0D;
            this.btnValidate.IconVisible = false;
            this.btnValidate.IconZoom = 90D;
            this.btnValidate.IsTab = false;
            this.btnValidate.Location = new System.Drawing.Point(132, 3);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Normalcolor = System.Drawing.Color.Green;
            this.btnValidate.OnHovercolor = System.Drawing.Color.Green;
            this.btnValidate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnValidate.selected = false;
            this.btnValidate.Size = new System.Drawing.Size(124, 37);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "VALIDER";
            this.btnValidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnValidate.Textcolor = System.Drawing.Color.White;
            this.btnValidate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userInput1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(269, 353);
            this.panel3.TabIndex = 3;
            // 
            // userInput1
            // 
            this.userInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInput1.Inputs = "123456789A0B";
            this.userInput1.Location = new System.Drawing.Point(5, 5);
            this.userInput1.Name = "userInput1";
            this.userInput1.Size = new System.Drawing.Size(259, 343);
            this.userInput1.TabIndex = 0;
            this.userInput1.ActionPerformed += new LoaderTraker.UserInput.Action(this.userInput1_ActionPerformed);
            // 
            // InputTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 453);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "InputTaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputTaker";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserInput userInput1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UBTStandardLibrary.UBTTextBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCorrect;
        private Bunifu.Framework.UI.BunifuFlatButton btnValidate;
    }
}