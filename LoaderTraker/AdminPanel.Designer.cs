namespace LoaderTraker
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSystemUserContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddNewUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveOtherSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAddress2 = new UBTStandardLibrary.UBTTextBox();
            this.txtAddress1 = new UBTStandardLibrary.UBTTextBox();
            this.txtCompanyName = new UBTStandardLibrary.UBTTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtProducts = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClearHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvTickerData = new System.Windows.Forms.DataGridView();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickerData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlSystemUserContainer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 392);
            this.panel1.TabIndex = 0;
            // 
            // pnlSystemUserContainer
            // 
            this.pnlSystemUserContainer.AutoScroll = true;
            this.pnlSystemUserContainer.BackColor = System.Drawing.Color.White;
            this.pnlSystemUserContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSystemUserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSystemUserContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlSystemUserContainer.Name = "pnlSystemUserContainer";
            this.pnlSystemUserContainer.Size = new System.Drawing.Size(726, 347);
            this.pnlSystemUserContainer.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnAddNewUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(726, 45);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.Green;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = false;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(497, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Green;
            this.btnSave.OnHovercolor = System.Drawing.Color.Green;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(112, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Active = false;
            this.btnAddNewUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewUser.BorderRadius = 0;
            this.btnAddNewUser.ButtonText = "Add New";
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddNewUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNewUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.Iconimage")));
            this.btnAddNewUser.Iconimage_right = null;
            this.btnAddNewUser.Iconimage_right_Selected = null;
            this.btnAddNewUser.Iconimage_Selected = null;
            this.btnAddNewUser.IconMarginLeft = 0;
            this.btnAddNewUser.IconMarginRight = 0;
            this.btnAddNewUser.IconRightVisible = false;
            this.btnAddNewUser.IconRightZoom = 0D;
            this.btnAddNewUser.IconVisible = false;
            this.btnAddNewUser.IconZoom = 90D;
            this.btnAddNewUser.IsTab = false;
            this.btnAddNewUser.Location = new System.Drawing.Point(609, 3);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddNewUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddNewUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddNewUser.selected = false;
            this.btnAddNewUser.Size = new System.Drawing.Size(112, 37);
            this.btnAddNewUser.TabIndex = 2;
            this.btnAddNewUser.Text = "Add New";
            this.btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewUser.Textcolor = System.Drawing.Color.White;
            this.btnAddNewUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.txtAddress2);
            this.tabPage2.Controls.Add(this.txtAddress1);
            this.tabPage2.Controls.Add(this.txtCompanyName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other Settings";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSaveOtherSettings);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 350);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(726, 45);
            this.panel3.TabIndex = 7;
            // 
            // btnSaveOtherSettings
            // 
            this.btnSaveOtherSettings.Active = false;
            this.btnSaveOtherSettings.Activecolor = System.Drawing.Color.Green;
            this.btnSaveOtherSettings.BackColor = System.Drawing.Color.Green;
            this.btnSaveOtherSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveOtherSettings.BorderRadius = 0;
            this.btnSaveOtherSettings.ButtonText = "Save";
            this.btnSaveOtherSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveOtherSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveOtherSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveOtherSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveOtherSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveOtherSettings.Iconimage")));
            this.btnSaveOtherSettings.Iconimage_right = null;
            this.btnSaveOtherSettings.Iconimage_right_Selected = null;
            this.btnSaveOtherSettings.Iconimage_Selected = null;
            this.btnSaveOtherSettings.IconMarginLeft = 0;
            this.btnSaveOtherSettings.IconMarginRight = 0;
            this.btnSaveOtherSettings.IconRightVisible = false;
            this.btnSaveOtherSettings.IconRightZoom = 0D;
            this.btnSaveOtherSettings.IconVisible = false;
            this.btnSaveOtherSettings.IconZoom = 90D;
            this.btnSaveOtherSettings.IsTab = false;
            this.btnSaveOtherSettings.Location = new System.Drawing.Point(609, 3);
            this.btnSaveOtherSettings.Name = "btnSaveOtherSettings";
            this.btnSaveOtherSettings.Normalcolor = System.Drawing.Color.Green;
            this.btnSaveOtherSettings.OnHovercolor = System.Drawing.Color.Green;
            this.btnSaveOtherSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveOtherSettings.selected = false;
            this.btnSaveOtherSettings.Size = new System.Drawing.Size(112, 37);
            this.btnSaveOtherSettings.TabIndex = 3;
            this.btnSaveOtherSettings.Text = "Save";
            this.btnSaveOtherSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveOtherSettings.Textcolor = System.Drawing.Color.White;
            this.btnSaveOtherSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOtherSettings.Click += new System.EventHandler(this.btnSaveOtherSettings_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAddress2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAddress2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAddress2.BorderThickness = 2;
            this.txtAddress2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddress2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAddress2.Hint = "Address2";
            this.txtAddress2.Index = -1;
            this.txtAddress2.isPassword = false;
            this.txtAddress2.Location = new System.Drawing.Point(3, 77);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress2.MaxLength = 32767;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(726, 37);
            this.txtAddress2.TabIndex = 6;
            this.txtAddress2.Text = "Address2";
            this.txtAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress1
            // 
            this.txtAddress1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAddress1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAddress1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAddress1.BorderThickness = 2;
            this.txtAddress1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddress1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtAddress1.Hint = "Address1";
            this.txtAddress1.Index = -1;
            this.txtAddress1.isPassword = false;
            this.txtAddress1.Location = new System.Drawing.Point(3, 40);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress1.MaxLength = 32767;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(726, 37);
            this.txtAddress1.TabIndex = 5;
            this.txtAddress1.Text = "Address1";
            this.txtAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtCompanyName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtCompanyName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtCompanyName.BorderThickness = 2;
            this.txtCompanyName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtCompanyName.Hint = "Company Name";
            this.txtCompanyName.Index = -1;
            this.txtCompanyName.isPassword = false;
            this.txtCompanyName.Location = new System.Drawing.Point(3, 3);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(726, 37);
            this.txtCompanyName.TabIndex = 4;
            this.txtCompanyName.Text = "Company Name";
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.txtProducts);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(732, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtProducts
            // 
            this.txtProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProducts.Location = new System.Drawing.Point(3, 3);
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(724, 345);
            this.txtProducts.TabIndex = 9;
            this.txtProducts.Text = "";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSaveProducts);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 348);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(724, 45);
            this.panel4.TabIndex = 8;
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.Active = false;
            this.btnSaveProducts.Activecolor = System.Drawing.Color.Green;
            this.btnSaveProducts.BackColor = System.Drawing.Color.Green;
            this.btnSaveProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveProducts.BorderRadius = 0;
            this.btnSaveProducts.ButtonText = "Save";
            this.btnSaveProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProducts.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveProducts.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveProducts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveProducts.Iconimage")));
            this.btnSaveProducts.Iconimage_right = null;
            this.btnSaveProducts.Iconimage_right_Selected = null;
            this.btnSaveProducts.Iconimage_Selected = null;
            this.btnSaveProducts.IconMarginLeft = 0;
            this.btnSaveProducts.IconMarginRight = 0;
            this.btnSaveProducts.IconRightVisible = false;
            this.btnSaveProducts.IconRightZoom = 0D;
            this.btnSaveProducts.IconVisible = false;
            this.btnSaveProducts.IconZoom = 90D;
            this.btnSaveProducts.IsTab = false;
            this.btnSaveProducts.Location = new System.Drawing.Point(607, 3);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Normalcolor = System.Drawing.Color.Green;
            this.btnSaveProducts.OnHovercolor = System.Drawing.Color.Green;
            this.btnSaveProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveProducts.selected = false;
            this.btnSaveProducts.Size = new System.Drawing.Size(112, 37);
            this.btnSaveProducts.TabIndex = 3;
            this.btnSaveProducts.Text = "Save";
            this.btnSaveProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveProducts.Textcolor = System.Drawing.Color.White;
            this.btnSaveProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProducts_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel6);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(732, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sales History";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnClearHistory);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 350);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(726, 45);
            this.panel5.TabIndex = 9;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Active = false;
            this.btnClearHistory.Activecolor = System.Drawing.Color.Red;
            this.btnClearHistory.BackColor = System.Drawing.Color.Red;
            this.btnClearHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearHistory.BorderRadius = 0;
            this.btnClearHistory.ButtonText = "Clear History";
            this.btnClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearHistory.DisabledColor = System.Drawing.Color.Gray;
            this.btnClearHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClearHistory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClearHistory.Iconimage")));
            this.btnClearHistory.Iconimage_right = null;
            this.btnClearHistory.Iconimage_right_Selected = null;
            this.btnClearHistory.Iconimage_Selected = null;
            this.btnClearHistory.IconMarginLeft = 0;
            this.btnClearHistory.IconMarginRight = 0;
            this.btnClearHistory.IconRightVisible = false;
            this.btnClearHistory.IconRightZoom = 0D;
            this.btnClearHistory.IconVisible = false;
            this.btnClearHistory.IconZoom = 90D;
            this.btnClearHistory.IsTab = false;
            this.btnClearHistory.Location = new System.Drawing.Point(609, 3);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Normalcolor = System.Drawing.Color.Red;
            this.btnClearHistory.OnHovercolor = System.Drawing.Color.Red;
            this.btnClearHistory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClearHistory.selected = false;
            this.btnClearHistory.Size = new System.Drawing.Size(112, 37);
            this.btnClearHistory.TabIndex = 3;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearHistory.Textcolor = System.Drawing.Color.White;
            this.btnClearHistory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dgvTickerData);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(726, 347);
            this.panel6.TabIndex = 10;
            // 
            // dgvTickerData
            // 
            this.dgvTickerData.AllowUserToAddRows = false;
            this.dgvTickerData.AllowUserToDeleteRows = false;
            this.dgvTickerData.BackgroundColor = System.Drawing.Color.White;
            this.dgvTickerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.Address1,
            this.Address2,
            this.Date,
            this.Code,
            this.Client,
            this.Username,
            this.Products});
            this.dgvTickerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickerData.Location = new System.Drawing.Point(3, 3);
            this.dgvTickerData.Name = "dgvTickerData";
            this.dgvTickerData.ReadOnly = true;
            this.dgvTickerData.RowHeadersVisible = false;
            this.dgvTickerData.Size = new System.Drawing.Size(718, 339);
            this.dgvTickerData.TabIndex = 0;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company Name ";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // Address1
            // 
            this.Address1.HeaderText = "Address1";
            this.Address1.Name = "Address1";
            this.Address1.ReadOnly = true;
            // 
            // Address2
            // 
            this.Address2.HeaderText = "Address2";
            this.Address2.Name = "Address2";
            this.Address2.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Products
            // 
            this.Products.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Products.HeaderText = "Products";
            this.Products.MinimumWidth = 500;
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 424);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSystemUserContainer;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddNewUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private UBTStandardLibrary.UBTTextBox txtAddress2;
        private UBTStandardLibrary.UBTTextBox txtAddress1;
        private UBTStandardLibrary.UBTTextBox txtCompanyName;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveOtherSettings;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveProducts;
        private System.Windows.Forms.RichTextBox txtProducts;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClearHistory;
        private System.Windows.Forms.DataGridView dgvTickerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
    }
}