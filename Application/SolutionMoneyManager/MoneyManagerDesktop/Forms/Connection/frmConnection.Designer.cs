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
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.textBoxSource = new MetroFramework.Controls.MetroTextBox();
            this.textBoxProvider = new MetroFramework.Controls.MetroTextBox();
            this.textBoxString = new MetroFramework.Controls.MetroTextBox();
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
            // textBoxSource
            // 
            this.textBoxSource.Lines = new string[] {
        "metroTextBox1"};
            this.textBoxSource.Location = new System.Drawing.Point(23, 63);
            this.textBoxSource.MaxLength = 32767;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.PasswordChar = '\0';
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSource.SelectedText = "";
            this.textBoxSource.Size = new System.Drawing.Size(307, 23);
            this.textBoxSource.TabIndex = 0;
            this.textBoxSource.Text = "metroTextBox1";
            this.textBoxSource.UseSelectable = true;
            // 
            // textBoxProvider
            // 
            this.textBoxProvider.Lines = new string[] {
        "metroTextBox1"};
            this.textBoxProvider.Location = new System.Drawing.Point(23, 92);
            this.textBoxProvider.MaxLength = 32767;
            this.textBoxProvider.Name = "textBoxProvider";
            this.textBoxProvider.PasswordChar = '\0';
            this.textBoxProvider.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxProvider.SelectedText = "";
            this.textBoxProvider.Size = new System.Drawing.Size(307, 23);
            this.textBoxProvider.TabIndex = 1;
            this.textBoxProvider.Text = "metroTextBox1";
            this.textBoxProvider.UseSelectable = true;
            // 
            // textBoxString
            // 
            this.textBoxString.Lines = new string[] {
        "metroTextBox1"};
            this.textBoxString.Location = new System.Drawing.Point(23, 121);
            this.textBoxString.MaxLength = 32767;
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.PasswordChar = '\0';
            this.textBoxString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxString.SelectedText = "";
            this.textBoxString.Size = new System.Drawing.Size(307, 50);
            this.textBoxString.TabIndex = 2;
            this.textBoxString.Text = "metroTextBox1";
            this.textBoxString.UseSelectable = true;
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
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
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
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.textBoxProvider);
            this.Controls.Add(this.textBoxSource);
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
        private MetroFramework.Controls.MetroTextBox textBoxSource;
        private MetroFramework.Controls.MetroTextBox textBoxProvider;
        private MetroFramework.Controls.MetroTextBox textBoxString;
        private MetroFramework.Controls.MetroButton btnNovo;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.PictureBox pbxDataBaseLogo;
        private MetroFramework.Controls.MetroButton btnTest;
    }
}