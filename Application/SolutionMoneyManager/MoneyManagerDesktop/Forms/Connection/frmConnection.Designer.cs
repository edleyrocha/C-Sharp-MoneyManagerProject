namespace MoneyManagerDesktop
{
    partial class FrmConnection
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
            this.txtBoxSource = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxProvider = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxString = new MetroFramework.Controls.MetroTextBox();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.img_LogoDB = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(261, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "%btnClose%";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxSource
            // 
            this.txtBoxSource.Lines = new string[] {
        "%txtBoxSource%"};
            this.txtBoxSource.Location = new System.Drawing.Point(159, 121);
            this.txtBoxSource.MaxLength = 32767;
            this.txtBoxSource.Name = "txtBoxSource";
            this.txtBoxSource.PasswordChar = '\0';
            this.txtBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSource.SelectedText = "";
            this.txtBoxSource.Size = new System.Drawing.Size(204, 23);
            this.txtBoxSource.TabIndex = 0;
            this.txtBoxSource.Text = "%txtBoxSource%";
            this.txtBoxSource.UseSelectable = true;
            this.txtBoxSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtBoxProvider
            // 
            this.txtBoxProvider.Lines = new string[] {
        "%txtBoxProvider%"};
            this.txtBoxProvider.Location = new System.Drawing.Point(159, 150);
            this.txtBoxProvider.MaxLength = 32767;
            this.txtBoxProvider.Name = "txtBoxProvider";
            this.txtBoxProvider.PasswordChar = '\0';
            this.txtBoxProvider.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxProvider.SelectedText = "";
            this.txtBoxProvider.Size = new System.Drawing.Size(204, 43);
            this.txtBoxProvider.TabIndex = 1;
            this.txtBoxProvider.Text = "%txtBoxProvider%";
            this.txtBoxProvider.UseSelectable = true;
            this.txtBoxProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtBoxString
            // 
            this.txtBoxString.Lines = new string[] {
        "%txtBoxString%"};
            this.txtBoxString.Location = new System.Drawing.Point(23, 199);
            this.txtBoxString.MaxLength = 32767;
            this.txtBoxString.Name = "txtBoxString";
            this.txtBoxString.PasswordChar = '\0';
            this.txtBoxString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxString.SelectedText = "";
            this.txtBoxString.Size = new System.Drawing.Size(340, 80);
            this.txtBoxString.TabIndex = 2;
            this.txtBoxString.Text = "%txtBoxString%";
            this.txtBoxString.UseSelectable = true;
            this.txtBoxString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(159, 63);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(204, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "%btnNew%";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(159, 92);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(204, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "%btnLoad%";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // img_LogoDB
            // 
            this.img_LogoDB.ActiveControl = null;
            this.img_LogoDB.Location = new System.Drawing.Point(23, 63);
            this.img_LogoDB.Name = "img_LogoDB";
            this.img_LogoDB.Size = new System.Drawing.Size(130, 130);
            this.img_LogoDB.TabIndex = 7;
            this.img_LogoDB.Text = "%img_LogoDB%";
            this.img_LogoDB.UseSelectable = true;
            // 
            // FrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 330);
            this.Controls.Add(this.img_LogoDB);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBoxString);
            this.Controls.Add(this.txtBoxProvider);
            this.Controls.Add(this.txtBoxSource);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmConnection";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "%FrmConnection%";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTextBox txtBoxSource;
        private MetroFramework.Controls.MetroTextBox txtBoxProvider;
        private MetroFramework.Controls.MetroTextBox txtBoxString;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroTile img_LogoDB;
    }
}