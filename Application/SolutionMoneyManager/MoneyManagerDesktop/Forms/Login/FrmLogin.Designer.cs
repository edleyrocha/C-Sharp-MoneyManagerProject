namespace MoneyManagerDesktop
{
    partial class FrmLogin
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
            this.mtpLogin = new MetroFramework.Controls.MetroTabPage();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.imgLogin = new MetroFramework.Controls.MetroTile();
            this.imgStatusPassword = new System.Windows.Forms.PictureBox();
            this.imgStatusLogin = new System.Windows.Forms.PictureBox();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtcLogin = new MetroFramework.Controls.MetroTabControl();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lblStatusLogin = new MetroFramework.Controls.MetroLabel();
            this.mtpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusLogin)).BeginInit();
            this.mtcLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtpLogin
            // 
            this.mtpLogin.Controls.Add(this.lblStatusLogin);
            this.mtpLogin.Controls.Add(this.btnLogin);
            this.mtpLogin.Controls.Add(this.btnClose);
            this.mtpLogin.Controls.Add(this.imgLogin);
            this.mtpLogin.Controls.Add(this.imgStatusPassword);
            this.mtpLogin.Controls.Add(this.imgStatusLogin);
            this.mtpLogin.Controls.Add(this.txtLogin);
            this.mtpLogin.Controls.Add(this.txtPassword);
            this.mtpLogin.HorizontalScrollbarBarColor = true;
            this.mtpLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpLogin.HorizontalScrollbarSize = 10;
            this.mtpLogin.Location = new System.Drawing.Point(4, 38);
            this.mtpLogin.Name = "mtpLogin";
            this.mtpLogin.Size = new System.Drawing.Size(361, 136);
            this.mtpLogin.TabIndex = 0;
            this.mtpLogin.Text = "%Login%";
            this.mtpLogin.VerticalScrollbarBarColor = true;
            this.mtpLogin.VerticalScrollbarHighlightOnWheel = false;
            this.mtpLogin.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(263, 110);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "%btnClose%";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imgLogin
            // 
            this.imgLogin.ActiveControl = null;
            this.imgLogin.Location = new System.Drawing.Point(3, 3);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(130, 130);
            this.imgLogin.TabIndex = 11;
            this.imgLogin.Text = "%imgLogin%";
            this.imgLogin.UseSelectable = true;
            // 
            // imgStatusPassword
            // 
            this.imgStatusPassword.BackColor = System.Drawing.Color.Transparent;
            this.imgStatusPassword.Location = new System.Drawing.Point(344, 32);
            this.imgStatusPassword.Name = "imgStatusPassword";
            this.imgStatusPassword.Size = new System.Drawing.Size(16, 16);
            this.imgStatusPassword.TabIndex = 10;
            this.imgStatusPassword.TabStop = false;
            // 
            // imgStatusLogin
            // 
            this.imgStatusLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgStatusLogin.Location = new System.Drawing.Point(344, 3);
            this.imgStatusLogin.Name = "imgStatusLogin";
            this.imgStatusLogin.Size = new System.Drawing.Size(16, 16);
            this.imgStatusLogin.TabIndex = 10;
            this.imgStatusLogin.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Lines = new string[] {
        "%txtLogin%"};
            this.txtLogin.Location = new System.Drawing.Point(145, 3);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.Size = new System.Drawing.Size(193, 23);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Tag = "Usuario";
            this.txtLogin.Text = "%txtLogin%";
            this.txtLogin.UseSelectable = true;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Lines = new string[] {
        "%txtPassword%"};
            this.txtPassword.Location = new System.Drawing.Point(145, 32);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(193, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "Senha";
            this.txtPassword.Text = "%txtPassword%";
            this.txtPassword.UseSelectable = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // mtcLogin
            // 
            this.mtcLogin.Controls.Add(this.mtpLogin);
            this.mtcLogin.Location = new System.Drawing.Point(10, 63);
            this.mtcLogin.Name = "mtcLogin";
            this.mtcLogin.SelectedIndex = 0;
            this.mtcLogin.Size = new System.Drawing.Size(369, 178);
            this.mtcLogin.TabIndex = 9;
            this.mtcLogin.UseSelectable = true;
            this.mtcLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtcLogin_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(182, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "%btnLogin%";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStatusLogin
            // 
            this.lblStatusLogin.AutoSize = true;
            this.lblStatusLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStatusLogin.Location = new System.Drawing.Point(145, 58);
            this.lblStatusLogin.Name = "lblStatusLogin";
            this.lblStatusLogin.Size = new System.Drawing.Size(145, 25);
            this.lblStatusLogin.TabIndex = 14;
            this.lblStatusLogin.Text = "%lblStatusLogin%";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 257);
            this.Controls.Add(this.mtcLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "%MoneyManager%";
            this.mtpLogin.ResumeLayout(false);
            this.mtpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusLogin)).EndInit();
            this.mtcLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage mtpLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTabControl mtcLogin;
        private System.Windows.Forms.PictureBox imgStatusLogin;
        private System.Windows.Forms.PictureBox imgStatusPassword;
        private MetroFramework.Controls.MetroTile imgLogin;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel lblStatusLogin;
    }
}