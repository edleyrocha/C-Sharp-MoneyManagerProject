namespace MoneyManagerDesktop
{
    partial class FrmmAbout
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
            this.lbl_Company = new MetroFramework.Controls.MetroLabel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.imgHelpAbout = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(252, 272);
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
            this.lbl_Product.Location = new System.Drawing.Point(159, 63);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(97, 19);
            this.lbl_Product.TabIndex = 1;
            this.lbl_Product.Text = "%lbl_Product%";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(159, 101);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(93, 19);
            this.lbl_Version.TabIndex = 1;
            this.lbl_Version.Text = "%lbl_Version%";
            // 
            // lbl_Ringht
            // 
            this.lbl_Ringht.AutoSize = true;
            this.lbl_Ringht.Location = new System.Drawing.Point(159, 82);
            this.lbl_Ringht.Name = "lbl_Ringht";
            this.lbl_Ringht.Size = new System.Drawing.Size(88, 19);
            this.lbl_Ringht.TabIndex = 1;
            this.lbl_Ringht.Text = "%lbl_Ringht%";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Location = new System.Drawing.Point(159, 120);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(108, 19);
            this.lbl_Company.TabIndex = 1;
            this.lbl_Company.Text = "%lbl_Company%";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(23, 199);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(304, 67);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "%rtbDescription%";
            this.rtbDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbDescription_KeyDown);
            // 
            // imgHelpAbout
            // 
            this.imgHelpAbout.ActiveControl = null;
            this.imgHelpAbout.Location = new System.Drawing.Point(23, 63);
            this.imgHelpAbout.Name = "imgHelpAbout";
            this.imgHelpAbout.Size = new System.Drawing.Size(130, 130);
            this.imgHelpAbout.TabIndex = 3;
            this.imgHelpAbout.Text = "%imgHelpAbout%";
            this.imgHelpAbout.UseSelectable = true;
            // 
            // FrmmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.imgHelpAbout);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.lbl_Ringht);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmmAbout";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "%FrmmAbout%";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel lbl_Product;
        private MetroFramework.Controls.MetroLabel lbl_Version;
        private MetroFramework.Controls.MetroLabel lbl_Ringht;
        private MetroFramework.Controls.MetroLabel lbl_Company;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private MetroFramework.Controls.MetroTile imgHelpAbout;
    }
}