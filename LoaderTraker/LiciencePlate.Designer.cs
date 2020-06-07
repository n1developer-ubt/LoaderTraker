namespace LoaderTraker
{
    partial class LiciencePlate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiciencePlate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new UBTStandardLibrary.UBTTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnnuler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnValidate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAffacer = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 37);
            this.panel1.TabIndex = 0;
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
            this.txtPassword.Hint = "Enter";
            this.txtPassword.Index = -1;
            this.txtPassword.isPassword = false;
            this.txtPassword.Location = new System.Drawing.Point(200, 0);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(665, 35);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Enter";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez saisir la plaque d’immatriculation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 57);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnAnnuler, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnValidate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAffacer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 55);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Active = false;
            this.btnAnnuler.Activecolor = System.Drawing.Color.Gray;
            this.btnAnnuler.BackColor = System.Drawing.Color.Gray;
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.BorderRadius = 0;
            this.btnAnnuler.ButtonText = "ANNULER";
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnnuler.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnnuler.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Iconimage")));
            this.btnAnnuler.Iconimage_right = null;
            this.btnAnnuler.Iconimage_right_Selected = null;
            this.btnAnnuler.Iconimage_Selected = null;
            this.btnAnnuler.IconMarginLeft = 0;
            this.btnAnnuler.IconMarginRight = 0;
            this.btnAnnuler.IconRightVisible = false;
            this.btnAnnuler.IconRightZoom = 0D;
            this.btnAnnuler.IconVisible = false;
            this.btnAnnuler.IconZoom = 90D;
            this.btnAnnuler.IsTab = false;
            this.btnAnnuler.Location = new System.Drawing.Point(3, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Normalcolor = System.Drawing.Color.Gray;
            this.btnAnnuler.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAnnuler.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnnuler.selected = false;
            this.btnAnnuler.Size = new System.Drawing.Size(282, 49);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnnuler.Textcolor = System.Drawing.Color.White;
            this.btnAnnuler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnValidate.Location = new System.Drawing.Point(579, 3);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Normalcolor = System.Drawing.Color.Green;
            this.btnValidate.OnHovercolor = System.Drawing.Color.Green;
            this.btnValidate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnValidate.selected = false;
            this.btnValidate.Size = new System.Drawing.Size(283, 49);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "VALIDER";
            this.btnValidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnValidate.Textcolor = System.Drawing.Color.White;
            this.btnValidate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnAffacer
            // 
            this.btnAffacer.Active = false;
            this.btnAffacer.Activecolor = System.Drawing.Color.Red;
            this.btnAffacer.BackColor = System.Drawing.Color.Red;
            this.btnAffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAffacer.BorderRadius = 0;
            this.btnAffacer.ButtonText = "AFFACER";
            this.btnAffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAffacer.DisabledColor = System.Drawing.Color.Gray;
            this.btnAffacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAffacer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAffacer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAffacer.Iconimage")));
            this.btnAffacer.Iconimage_right = null;
            this.btnAffacer.Iconimage_right_Selected = null;
            this.btnAffacer.Iconimage_Selected = null;
            this.btnAffacer.IconMarginLeft = 0;
            this.btnAffacer.IconMarginRight = 0;
            this.btnAffacer.IconRightVisible = false;
            this.btnAffacer.IconRightZoom = 0D;
            this.btnAffacer.IconVisible = false;
            this.btnAffacer.IconZoom = 90D;
            this.btnAffacer.IsTab = false;
            this.btnAffacer.Location = new System.Drawing.Point(291, 3);
            this.btnAffacer.Name = "btnAffacer";
            this.btnAffacer.Normalcolor = System.Drawing.Color.Red;
            this.btnAffacer.OnHovercolor = System.Drawing.Color.Red;
            this.btnAffacer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAffacer.selected = false;
            this.btnAffacer.Size = new System.Drawing.Size(282, 49);
            this.btnAffacer.TabIndex = 1;
            this.btnAffacer.Text = "AFFACER";
            this.btnAffacer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAffacer.Textcolor = System.Drawing.Color.White;
            this.btnAffacer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.userInput1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 356);
            this.panel3.TabIndex = 2;
            // 
            // userInput1
            // 
            this.userInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInput1.Inputs = "AZERTYUIOPQSDFGHJKLMWXCVBN<1234567890";
            this.userInput1.Location = new System.Drawing.Point(0, 0);
            this.userInput1.Name = "userInput1";
            this.userInput1.Size = new System.Drawing.Size(865, 354);
            this.userInput1.TabIndex = 0;
            this.userInput1.ActionPerformed += new LoaderTraker.UserInput.Action(this.userInput1_ActionPerformed);
            // 
            // LiciencePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LiciencePlate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiciencePlate";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnValidate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAffacer;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnnuler;
        private System.Windows.Forms.Label label1;
        private UBTStandardLibrary.UBTTextBox txtPassword;
        private UserInput userInput1;
    }
}