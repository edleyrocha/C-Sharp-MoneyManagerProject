namespace MoneyManagerDesktop
{
    partial class frmConnection
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
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.pbxDataBaseLogo = new System.Windows.Forms.PictureBox();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDataBaseLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(255, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "%btnClose%";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxSource
            // 
            this.txtBoxSource.Lines = new string[] {
        "%txtBoxSource%"};
            this.txtBoxSource.Location = new System.Drawing.Point(23, 63);
            this.txtBoxSource.MaxLength = 32767;
            this.txtBoxSource.Name = "txtBoxSource";
            this.txtBoxSource.PasswordChar = '\0';
            this.txtBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSource.SelectedText = "";
            this.txtBoxSource.Size = new System.Drawing.Size(307, 23);
            this.txtBoxSource.TabIndex = 0;
            this.txtBoxSource.Text = "%txtBoxSource%";
            this.txtBoxSource.UseSelectable = true;
            this.txtBoxSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtBoxProvider
            // 
            this.txtBoxProvider.Lines = new string[] {
        "%txtBoxProvider%"};
            this.txtBoxProvider.Location = new System.Drawing.Point(23, 92);
            this.txtBoxProvider.MaxLength = 32767;
            this.txtBoxProvider.Name = "txtBoxProvider";
            this.txtBoxProvider.PasswordChar = '\0';
            this.txtBoxProvider.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxProvider.SelectedText = "";
            this.txtBoxProvider.Size = new System.Drawing.Size(307, 23);
            this.txtBoxProvider.TabIndex = 1;
            this.txtBoxProvider.Text = "%txtBoxProvider%";
            this.txtBoxProvider.UseSelectable = true;
            this.txtBoxProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtBoxString
            // 
            this.txtBoxString.Lines = new string[] {
        "%txtBoxString%"};
            this.txtBoxString.Location = new System.Drawing.Point(23, 121);
            this.txtBoxString.MaxLength = 32767;
            this.txtBoxString.Name = "txtBoxString";
            this.txtBoxString.PasswordChar = '\0';
            this.txtBoxString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxString.SelectedText = "";
            this.txtBoxString.Size = new System.Drawing.Size(307, 50);
            this.txtBoxString.TabIndex = 2;
            this.txtBoxString.Text = "%txtBoxString%";
            this.txtBoxString.UseSelectable = true;
            this.txtBoxString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(119, 177);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(211, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "%btnNovo%";
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(119, 206);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(211, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "%btnLoad%";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbxDataBaseLogo
            // 
            this.pbxDataBaseLogo.Location = new System.Drawing.Point(23, 177);
            this.pbxDataBaseLogo.Name = "pbxDataBaseLogo";
            this.pbxDataBaseLogo.Size = new System.Drawing.Size(90, 81);
            this.pbxDataBaseLogo.TabIndex = 6;
            this.pbxDataBaseLogo.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(119, 235);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(130, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "%btnTest%";
            this.btnTest.UseSelectable = true;
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 281);
            this.Controls.Add(this.pbxDataBaseLogo);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtBoxString);
            this.Controls.Add(this.txtBoxProvider);
            this.Controls.Add(this.txtBoxSource);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmConnection";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "%frmConnection%";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDataBaseLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTextBox txtBoxSource;
        private MetroFramework.Controls.MetroTextBox txtBoxProvider;
        private MetroFramework.Controls.MetroTextBox txtBoxString;
        private MetroFramework.Controls.MetroButton btnNovo;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.PictureBox pbxDataBaseLogo;
        private MetroFramework.Controls.MetroButton btnTest;
    }
}