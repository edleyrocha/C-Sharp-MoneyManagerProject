namespace MoneyManagerDesktop
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroButton_Collor = new MetroFramework.Controls.MetroButton();
            this.mtpLogin = new MetroFramework.Controls.MetroTabPage();
            this.imgStatusPassword = new System.Windows.Forms.PictureBox();
            this.imgStatusLogin = new System.Windows.Forms.PictureBox();
            this.metroTile_Foto = new MetroFramework.Controls.MetroTile();
            this.txt_Login = new MetroFramework.Controls.MetroTextBox();
            this.txt_Password = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.mtpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusLogin)).BeginInit();
            this.metroTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroToggle1
            // 
            this.metroToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.Location = new System.Drawing.Point(248, 7);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(50, 17);
            this.metroToggle1.TabIndex = 2;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.Visible = false;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroButton_Collor
            // 
            this.metroButton_Collor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton_Collor.BackgroundImage")));
            this.metroButton_Collor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton_Collor.Location = new System.Drawing.Point(220, 7);
            this.metroButton_Collor.Name = "metroButton_Collor";
            this.metroButton_Collor.Size = new System.Drawing.Size(31, 17);
            this.metroButton_Collor.TabIndex = 4;
            this.metroButton_Collor.UseSelectable = true;
            this.metroButton_Collor.Visible = false;
            this.metroButton_Collor.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mtpLogin
            // 
            this.mtpLogin.Controls.Add(this.imgStatusPassword);
            this.mtpLogin.Controls.Add(this.imgStatusLogin);
            this.mtpLogin.Controls.Add(this.metroTile_Foto);
            this.mtpLogin.Controls.Add(this.txt_Login);
            this.mtpLogin.Controls.Add(this.txt_Password);
            this.mtpLogin.Controls.Add(this.btnLogin);
            this.mtpLogin.HorizontalScrollbarBarColor = true;
            this.mtpLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpLogin.HorizontalScrollbarSize = 10;
            this.mtpLogin.Location = new System.Drawing.Point(4, 38);
            this.mtpLogin.Name = "mtpLogin";
            this.mtpLogin.Size = new System.Drawing.Size(328, 99);
            this.mtpLogin.TabIndex = 0;
            this.mtpLogin.Text = "%Login%";
            this.mtpLogin.VerticalScrollbarBarColor = true;
            this.mtpLogin.VerticalScrollbarHighlightOnWheel = false;
            this.mtpLogin.VerticalScrollbarSize = 10;
            // 
            // imgStatusPassword
            // 
            this.imgStatusPassword.BackColor = System.Drawing.Color.Transparent;
            this.imgStatusPassword.Location = new System.Drawing.Point(311, 42);
            this.imgStatusPassword.Name = "imgStatusPassword";
            this.imgStatusPassword.Size = new System.Drawing.Size(16, 16);
            this.imgStatusPassword.TabIndex = 10;
            this.imgStatusPassword.TabStop = false;
            // 
            // imgStatusLogin
            // 
            this.imgStatusLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgStatusLogin.Location = new System.Drawing.Point(311, 13);
            this.imgStatusLogin.Name = "imgStatusLogin";
            this.imgStatusLogin.Size = new System.Drawing.Size(16, 16);
            this.imgStatusLogin.TabIndex = 10;
            this.imgStatusLogin.TabStop = false;
            // 
            // metroTile_Foto
            // 
            this.metroTile_Foto.ActiveControl = null;
            this.metroTile_Foto.Location = new System.Drawing.Point(3, 3);
            this.metroTile_Foto.Name = "metroTile_Foto";
            this.metroTile_Foto.Size = new System.Drawing.Size(103, 96);
            this.metroTile_Foto.TabIndex = 6;
            this.metroTile_Foto.Text = "%Foto%";
            this.metroTile_Foto.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_Foto.TileImage")));
            this.metroTile_Foto.UseSelectable = true;
            this.metroTile_Foto.UseTileImage = true;
            // 
            // txt_Login
            // 
            this.txt_Login.Lines = new string[] {
        "%txt_Login%"};
            this.txt_Login.Location = new System.Drawing.Point(112, 13);
            this.txt_Login.MaxLength = 32767;
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.PasswordChar = '\0';
            this.txt_Login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Login.SelectedText = "";
            this.txt_Login.Size = new System.Drawing.Size(193, 23);
            this.txt_Login.TabIndex = 0;
            this.txt_Login.Tag = "1";
            this.txt_Login.Text = "%txt_Login%";
            this.txt_Login.UseSelectable = true;
            this.txt_Login.Click += new System.EventHandler(this.txt_Login_Click);
            this.txt_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Login_KeyDown);
            this.txt_Login.Leave += new System.EventHandler(this.txt_Login_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.Lines = new string[] {
        "%txt_Password%"};
            this.txt_Password.Location = new System.Drawing.Point(112, 42);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(193, 23);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Tag = "2";
            this.txt_Password.Text = "%txt_Password%";
            this.txt_Password.UseSelectable = true;
            this.txt_Password.Click += new System.EventHandler(this.txt_Password_Click);
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(234, 71);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "%btnLogin%";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.mtpLogin);
            this.metroTabControl.Location = new System.Drawing.Point(10, 63);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(336, 141);
            this.metroTabControl.TabIndex = 9;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTabControl_KeyDown);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 214);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.metroButton_Collor);
            this.Controls.Add(this.metroToggle1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "%MoneyManager%";
            this.mtpLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusLogin)).EndInit();
            this.metroTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroButton metroButton_Collor;
        private MetroFramework.Controls.MetroTabPage mtpLogin;
        private MetroFramework.Controls.MetroTile metroTile_Foto;
        private MetroFramework.Controls.MetroTextBox txt_Login;
        private MetroFramework.Controls.MetroTextBox txt_Password;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private System.Windows.Forms.PictureBox imgStatusLogin;
        private System.Windows.Forms.PictureBox imgStatusPassword;
    }
}