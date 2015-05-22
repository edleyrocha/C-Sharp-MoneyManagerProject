namespace MoneyManagerDesktop
{
    partial class frmUsers
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
            this.mtcUsers = new MetroFramework.Controls.MetroTabControl();
            this.mtpInsert = new MetroFramework.Controls.MetroTabPage();
            this.metroTile_Foto = new MetroFramework.Controls.MetroTile();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.btnCloseNew = new MetroFramework.Controls.MetroButton();
            this.btnSaveNew = new MetroFramework.Controls.MetroButton();
            this.mtpUpdate = new MetroFramework.Controls.MetroTabPage();
            this.mtpDelete = new MetroFramework.Controls.MetroTabPage();
            this.mtpSelect = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtcUsers.SuspendLayout();
            this.mtpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcUsers
            // 
            this.mtcUsers.Controls.Add(this.mtpInsert);
            this.mtcUsers.Controls.Add(this.mtpUpdate);
            this.mtcUsers.Controls.Add(this.mtpDelete);
            this.mtcUsers.Controls.Add(this.mtpSelect);
            this.mtcUsers.Location = new System.Drawing.Point(23, 63);
            this.mtcUsers.Name = "mtcUsers";
            this.mtcUsers.SelectedIndex = 0;
            this.mtcUsers.Size = new System.Drawing.Size(376, 304);
            this.mtcUsers.TabIndex = 0;
            this.mtcUsers.UseSelectable = true;
            // 
            // mtpInsert
            // 
            this.mtpInsert.Controls.Add(this.pictureBox1);
            this.mtpInsert.Controls.Add(this.metroTile_Foto);
            this.mtpInsert.Controls.Add(this.txtPassword);
            this.mtpInsert.Controls.Add(this.txtLogin);
            this.mtpInsert.Controls.Add(this.txtName);
            this.mtpInsert.Controls.Add(this.btnCloseNew);
            this.mtpInsert.Controls.Add(this.btnSaveNew);
            this.mtpInsert.HorizontalScrollbarBarColor = true;
            this.mtpInsert.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpInsert.HorizontalScrollbarSize = 10;
            this.mtpInsert.Location = new System.Drawing.Point(4, 38);
            this.mtpInsert.Name = "mtpInsert";
            this.mtpInsert.Size = new System.Drawing.Size(368, 262);
            this.mtpInsert.TabIndex = 0;
            this.mtpInsert.Text = "%mtpInsert%";
            this.mtpInsert.VerticalScrollbarBarColor = true;
            this.mtpInsert.VerticalScrollbarHighlightOnWheel = false;
            this.mtpInsert.VerticalScrollbarSize = 10;
            // 
            // metroTile_Foto
            // 
            this.metroTile_Foto.ActiveControl = null;
            this.metroTile_Foto.Location = new System.Drawing.Point(3, 3);
            this.metroTile_Foto.Name = "metroTile_Foto";
            this.metroTile_Foto.Size = new System.Drawing.Size(135, 135);
            this.metroTile_Foto.TabIndex = 7;
            this.metroTile_Foto.Text = "        %Foto%";
            this.metroTile_Foto.UseSelectable = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Lines = new string[] {
        "%txtPassword%"};
            this.txtPassword.Location = new System.Drawing.Point(145, 62);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(184, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Tag = "3";
            this.txtPassword.Text = "%txtPassword%";
            this.txtPassword.UseSelectable = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Lines = new string[] {
        "%txtLogin%"};
            this.txtLogin.Location = new System.Drawing.Point(145, 33);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.Size = new System.Drawing.Size(184, 23);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.Tag = "2";
            this.txtLogin.Text = "%txtLogin%";
            this.txtLogin.UseSelectable = true;
            // 
            // txtName
            // 
            this.txtName.Lines = new string[] {
        "%txtName%"};
            this.txtName.Location = new System.Drawing.Point(144, 4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(185, 23);
            this.txtName.TabIndex = 5;
            this.txtName.Tag = "1";
            this.txtName.Text = "%txtName%";
            this.txtName.UseSelectable = true;
            // 
            // btnCloseNew
            // 
            this.btnCloseNew.Location = new System.Drawing.Point(254, 116);
            this.btnCloseNew.Name = "btnCloseNew";
            this.btnCloseNew.Size = new System.Drawing.Size(75, 23);
            this.btnCloseNew.TabIndex = 4;
            this.btnCloseNew.Text = "%btnClose%";
            this.btnCloseNew.UseSelectable = true;
            this.btnCloseNew.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(173, 116);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.Text = "%btnSave%";
            this.btnSaveNew.UseSelectable = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtpUpdate
            // 
            this.mtpUpdate.HorizontalScrollbarBarColor = true;
            this.mtpUpdate.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpUpdate.HorizontalScrollbarSize = 10;
            this.mtpUpdate.Location = new System.Drawing.Point(4, 38);
            this.mtpUpdate.Name = "mtpUpdate";
            this.mtpUpdate.Size = new System.Drawing.Size(368, 262);
            this.mtpUpdate.TabIndex = 1;
            this.mtpUpdate.Text = "%mtpUpdate%";
            this.mtpUpdate.VerticalScrollbarBarColor = true;
            this.mtpUpdate.VerticalScrollbarHighlightOnWheel = false;
            this.mtpUpdate.VerticalScrollbarSize = 10;
            // 
            // mtpDelete
            // 
            this.mtpDelete.HorizontalScrollbarBarColor = true;
            this.mtpDelete.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpDelete.HorizontalScrollbarSize = 10;
            this.mtpDelete.Location = new System.Drawing.Point(4, 38);
            this.mtpDelete.Name = "mtpDelete";
            this.mtpDelete.Size = new System.Drawing.Size(368, 262);
            this.mtpDelete.TabIndex = 2;
            this.mtpDelete.Text = "%mtpDelete%";
            this.mtpDelete.VerticalScrollbarBarColor = true;
            this.mtpDelete.VerticalScrollbarHighlightOnWheel = false;
            this.mtpDelete.VerticalScrollbarSize = 10;
            // 
            // mtpSelect
            // 
            this.mtpSelect.HorizontalScrollbarBarColor = true;
            this.mtpSelect.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpSelect.HorizontalScrollbarSize = 10;
            this.mtpSelect.Location = new System.Drawing.Point(4, 38);
            this.mtpSelect.Name = "mtpSelect";
            this.mtpSelect.Size = new System.Drawing.Size(368, 262);
            this.mtpSelect.TabIndex = 3;
            this.mtpSelect.Text = "%mtpSelect%";
            this.mtpSelect.VerticalScrollbarBarColor = true;
            this.mtpSelect.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSelect.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(335, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 372);
            this.Controls.Add(this.mtcUsers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmUsers";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "%frmUsers%";
            this.mtcUsers.ResumeLayout(false);
            this.mtpInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcUsers;
        private MetroFramework.Controls.MetroTabPage mtpInsert;
        private MetroFramework.Controls.MetroTabPage mtpUpdate;
        private MetroFramework.Controls.MetroTabPage mtpDelete;
        private MetroFramework.Controls.MetroTabPage mtpSelect;
        private MetroFramework.Controls.MetroButton btnSaveNew;
        private MetroFramework.Controls.MetroButton btnCloseNew;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTile metroTile_Foto;
        private System.Windows.Forms.PictureBox pictureBox1;




    }
}