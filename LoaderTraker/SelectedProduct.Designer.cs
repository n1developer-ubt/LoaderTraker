namespace LoaderTraker
{
    partial class SelectedProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDelete.ForeColor = System.Drawing.Color.Red;
            this.lblDelete.Location = new System.Drawing.Point(217, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(35, 39);
            this.lblDelete.TabIndex = 0;
            this.lblDelete.Text = "X";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(217, 39);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label2";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblDelete);
            this.Name = "SelectedProduct";
            this.Size = new System.Drawing.Size(252, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblText;
    }
}
