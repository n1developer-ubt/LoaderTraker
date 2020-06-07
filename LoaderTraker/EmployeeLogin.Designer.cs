namespace LoaderTraker
{
    partial class EmployeeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLogin));
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.btnConnexion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // cbUsers
            // 
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(12, 12);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(318, 39);
            this.cbUsers.TabIndex = 0;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Active = false;
            this.btnConnexion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnexion.BorderRadius = 0;
            this.btnConnexion.ButtonText = "Connexion";
            this.btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion.DisabledColor = System.Drawing.Color.Gray;
            this.btnConnexion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConnexion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConnexion.Iconimage")));
            this.btnConnexion.Iconimage_right = null;
            this.btnConnexion.Iconimage_right_Selected = null;
            this.btnConnexion.Iconimage_Selected = null;
            this.btnConnexion.IconMarginLeft = 0;
            this.btnConnexion.IconMarginRight = 0;
            this.btnConnexion.IconRightVisible = false;
            this.btnConnexion.IconRightZoom = 0D;
            this.btnConnexion.IconVisible = false;
            this.btnConnexion.IconZoom = 90D;
            this.btnConnexion.IsTab = false;
            this.btnConnexion.Location = new System.Drawing.Point(336, 12);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConnexion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConnexion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConnexion.selected = false;
            this.btnConnexion.Size = new System.Drawing.Size(166, 39);
            this.btnConnexion.TabIndex = 1;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnexion.Textcolor = System.Drawing.Color.White;
            this.btnConnexion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 65);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.cbUsers);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 104);
            this.MinimumSize = new System.Drawing.Size(530, 104);
            this.Name = "EmployeeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsers;
        private Bunifu.Framework.UI.BunifuFlatButton btnConnexion;
    }
}

