namespace MoneyManagerDesktop
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.lbl_Product = new MetroFramework.Controls.MetroLabel();
            this.lbl_Version = new MetroFramework.Controls.MetroLabel();
            this.lbl_Ringht = new MetroFramework.Controls.MetroLabel();
            this.imgHelpAbout = new System.Windows.Forms.PictureBox();
            this.lbl_Company = new MetroFramework.Controls.MetroLabel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHelpAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(273, 217);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "%btnClose%";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Location = new System.Drawing.Point(109, 60);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(97, 19);
            this.lbl_Product.TabIndex = 1;
            this.lbl_Product.Text = "%lbl_Product%";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(109, 79);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(93, 19);
            this.lbl_Version.TabIndex = 1;
            this.lbl_Version.Text = "%lbl_Version%";
            // 
            // lbl_Ringht
            // 
            this.lbl_Ringht.AutoSize = true;
            this.lbl_Ringht.Location = new System.Drawing.Point(109, 98);
            this.lbl_Ringht.Name = "lbl_Ringht";
            this.lbl_Ringht.Size = new System.Drawing.Size(88, 19);
            this.lbl_Ringht.TabIndex = 1;
            this.lbl_Ringht.Text = "%lbl_Ringht%";
            // 
            // imgHelpAbout
            // 
            this.imgHelpAbout.Location = new System.Drawing.Point(23, 63);
            this.imgHelpAbout.Name = "imgHelpAbout";
            this.imgHelpAbout.Size = new System.Drawing.Size(80, 65);
            this.imgHelpAbout.TabIndex = 2;
            this.imgHelpAbout.TabStop = false;
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Location = new System.Drawing.Point(109, 117);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(108, 19);
            this.lbl_Company.TabIndex = 1;
            this.lbl_Company.Text = "%lbl_Company%";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(23, 142);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(325, 67);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "%rtbDescription%";
            this.rtbDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbDescription_KeyDown);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 266);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.imgHelpAbout);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.lbl_Ringht);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmAbout";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "%frmAbout%";
            ((System.ComponentModel.ISupportInitialize)(this.imgHelpAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel lbl_Product;
        private MetroFramework.Controls.MetroLabel lbl_Version;
        private MetroFramework.Controls.MetroLabel lbl_Ringht;
        private System.Windows.Forms.PictureBox imgHelpAbout;
        private MetroFramework.Controls.MetroLabel lbl_Company;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}