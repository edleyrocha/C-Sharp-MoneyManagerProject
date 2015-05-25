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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.mtcUsers = new MetroFramework.Controls.MetroTabControl();
            this.mtpInsert = new MetroFramework.Controls.MetroTabPage();
            this.imgStatusUserPasswordInsert = new System.Windows.Forms.PictureBox();
            this.imgStatusUserLoginInsert = new System.Windows.Forms.PictureBox();
            this.imgStatusUserNameInsert = new System.Windows.Forms.PictureBox();
            this.metroTile_UserInsert = new MetroFramework.Controls.MetroTile();
            this.txtPasswordInsert = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginInsert = new MetroFramework.Controls.MetroTextBox();
            this.txtNameInsert = new MetroFramework.Controls.MetroTextBox();
            this.btnCloseInsert = new MetroFramework.Controls.MetroButton();
            this.btnSaveInsert = new MetroFramework.Controls.MetroButton();
            this.mtpUpdate = new MetroFramework.Controls.MetroTabPage();
            this.mtpDelete = new MetroFramework.Controls.MetroTabPage();
            this.mtpSelect = new MetroFramework.Controls.MetroTabPage();
            this.mtcUsers.SuspendLayout();
            this.mtpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserPasswordInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserLoginInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserNameInsert)).BeginInit();
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
            this.mtcUsers.Size = new System.Drawing.Size(376, 182);
            this.mtcUsers.TabIndex = 0;
            this.mtcUsers.UseSelectable = true;
            // 
            // mtpInsert
            // 
            this.mtpInsert.Controls.Add(this.imgStatusUserPasswordInsert);
            this.mtpInsert.Controls.Add(this.imgStatusUserLoginInsert);
            this.mtpInsert.Controls.Add(this.imgStatusUserNameInsert);
            this.mtpInsert.Controls.Add(this.metroTile_UserInsert);
            this.mtpInsert.Controls.Add(this.txtPasswordInsert);
            this.mtpInsert.Controls.Add(this.txtLoginInsert);
            this.mtpInsert.Controls.Add(this.txtNameInsert);
            this.mtpInsert.Controls.Add(this.btnCloseInsert);
            this.mtpInsert.Controls.Add(this.btnSaveInsert);
            this.mtpInsert.HorizontalScrollbarBarColor = true;
            this.mtpInsert.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpInsert.HorizontalScrollbarSize = 10;
            this.mtpInsert.Location = new System.Drawing.Point(4, 38);
            this.mtpInsert.Name = "mtpInsert";
            this.mtpInsert.Size = new System.Drawing.Size(368, 140);
            this.mtpInsert.TabIndex = 0;
            this.mtpInsert.Text = "%mtpInsert%";
            this.mtpInsert.VerticalScrollbarBarColor = true;
            this.mtpInsert.VerticalScrollbarHighlightOnWheel = false;
            this.mtpInsert.VerticalScrollbarSize = 10;
            // 
            // imgStatusUserPasswordInsert
            // 
            this.imgStatusUserPasswordInsert.BackColor = System.Drawing.Color.Transparent;
            this.imgStatusUserPasswordInsert.Location = new System.Drawing.Point(335, 62);
            this.imgStatusUserPasswordInsert.Name = "imgStatusUserPasswordInsert";
            this.imgStatusUserPasswordInsert.Size = new System.Drawing.Size(16, 16);
            this.imgStatusUserPasswordInsert.TabIndex = 8;
            this.imgStatusUserPasswordInsert.TabStop = false;
            // 
            // imgStatusUserLoginInsert
            // 
            this.imgStatusUserLoginInsert.BackColor = System.Drawing.Color.Transparent;
            this.imgStatusUserLoginInsert.Location = new System.Drawing.Point(335, 33);
            this.imgStatusUserLoginInsert.Name = "imgStatusUserLoginInsert";
            this.imgStatusUserLoginInsert.Size = new System.Drawing.Size(16, 16);
            this.imgStatusUserLoginInsert.TabIndex = 8;
            this.imgStatusUserLoginInsert.TabStop = false;
            // 
            // imgStatusUserNameInsert
            // 
            this.imgStatusUserNameInsert.BackColor = System.Drawing.Color.Transparent;
            this.imgStatusUserNameInsert.Location = new System.Drawing.Point(335, 4);
            this.imgStatusUserNameInsert.Name = "imgStatusUserNameInsert";
            this.imgStatusUserNameInsert.Size = new System.Drawing.Size(16, 16);
            this.imgStatusUserNameInsert.TabIndex = 8;
            this.imgStatusUserNameInsert.TabStop = false;
            // 
            // metroTile_UserInsert
            // 
            this.metroTile_UserInsert.ActiveControl = null;
            this.metroTile_UserInsert.Location = new System.Drawing.Point(3, 3);
            this.metroTile_UserInsert.Name = "metroTile_UserInsert";
            this.metroTile_UserInsert.Size = new System.Drawing.Size(130, 130);
            this.metroTile_UserInsert.TabIndex = 7;
            this.metroTile_UserInsert.Text = "        %Foto%";
            this.metroTile_UserInsert.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_UserInsert.TileImage")));
            this.metroTile_UserInsert.UseSelectable = true;
            this.metroTile_UserInsert.UseTileImage = true;
            // 
            // txtPasswordInsert
            // 
            this.txtPasswordInsert.Lines = new string[] {
        "%txtPasswordInsert%"};
            this.txtPasswordInsert.Location = new System.Drawing.Point(145, 62);
            this.txtPasswordInsert.MaxLength = 32767;
            this.txtPasswordInsert.Name = "txtPasswordInsert";
            this.txtPasswordInsert.PasswordChar = '\0';
            this.txtPasswordInsert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordInsert.SelectedText = "";
            this.txtPasswordInsert.Size = new System.Drawing.Size(184, 23);
            this.txtPasswordInsert.TabIndex = 5;
            this.txtPasswordInsert.Tag = "3";
            this.txtPasswordInsert.Text = "%txtPasswordInsert%";
            this.txtPasswordInsert.UseSelectable = true;
            // 
            // txtLoginInsert
            // 
            this.txtLoginInsert.Lines = new string[] {
        "%txtLoginInsert%"};
            this.txtLoginInsert.Location = new System.Drawing.Point(145, 33);
            this.txtLoginInsert.MaxLength = 32767;
            this.txtLoginInsert.Name = "txtLoginInsert";
            this.txtLoginInsert.PasswordChar = '\0';
            this.txtLoginInsert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginInsert.SelectedText = "";
            this.txtLoginInsert.Size = new System.Drawing.Size(184, 23);
            this.txtLoginInsert.TabIndex = 5;
            this.txtLoginInsert.Tag = "2";
            this.txtLoginInsert.Text = "%txtLoginInsert%";
            this.txtLoginInsert.UseSelectable = true;
            // 
            // txtNameInsert
            // 
            this.txtNameInsert.Lines = new string[] {
        "%txtNameInsert%"};
            this.txtNameInsert.Location = new System.Drawing.Point(144, 4);
            this.txtNameInsert.MaxLength = 32767;
            this.txtNameInsert.Name = "txtNameInsert";
            this.txtNameInsert.PasswordChar = '\0';
            this.txtNameInsert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameInsert.SelectedText = "";
            this.txtNameInsert.Size = new System.Drawing.Size(185, 23);
            this.txtNameInsert.TabIndex = 5;
            this.txtNameInsert.Tag = "1";
            this.txtNameInsert.Text = "%txtNameInsert%";
            this.txtNameInsert.UseSelectable = true;
            // 
            // btnCloseInsert
            // 
            this.btnCloseInsert.Location = new System.Drawing.Point(254, 110);
            this.btnCloseInsert.Name = "btnCloseInsert";
            this.btnCloseInsert.Size = new System.Drawing.Size(75, 23);
            this.btnCloseInsert.TabIndex = 4;
            this.btnCloseInsert.Text = "%btnClose%";
            this.btnCloseInsert.UseSelectable = true;
            this.btnCloseInsert.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveInsert
            // 
            this.btnSaveInsert.Location = new System.Drawing.Point(173, 110);
            this.btnSaveInsert.Name = "btnSaveInsert";
            this.btnSaveInsert.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInsert.TabIndex = 2;
            this.btnSaveInsert.Text = "%btnSave%";
            this.btnSaveInsert.UseSelectable = true;
            this.btnSaveInsert.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtpUpdate
            // 
            this.mtpUpdate.HorizontalScrollbarBarColor = true;
            this.mtpUpdate.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpUpdate.HorizontalScrollbarSize = 10;
            this.mtpUpdate.Location = new System.Drawing.Point(4, 38);
            this.mtpUpdate.Name = "mtpUpdate";
            this.mtpUpdate.Size = new System.Drawing.Size(368, 140);
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
            this.mtpDelete.Size = new System.Drawing.Size(368, 140);
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
            this.mtpSelect.Size = new System.Drawing.Size(368, 140);
            this.mtpSelect.TabIndex = 3;
            this.mtpSelect.Text = "%mtpSelect%";
            this.mtpSelect.VerticalScrollbarBarColor = true;
            this.mtpSelect.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSelect.VerticalScrollbarSize = 10;
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
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserPasswordInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserLoginInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserNameInsert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcUsers;
        private MetroFramework.Controls.MetroTabPage mtpInsert;
        private MetroFramework.Controls.MetroTabPage mtpUpdate;
        private MetroFramework.Controls.MetroTabPage mtpDelete;
        private MetroFramework.Controls.MetroTabPage mtpSelect;
        private MetroFramework.Controls.MetroButton btnSaveInsert;
        private MetroFramework.Controls.MetroButton btnCloseInsert;
        private MetroFramework.Controls.MetroTextBox txtPasswordInsert;
        private MetroFramework.Controls.MetroTextBox txtLoginInsert;
        private MetroFramework.Controls.MetroTextBox txtNameInsert;
        private MetroFramework.Controls.MetroTile metroTile_UserInsert;
        private System.Windows.Forms.PictureBox imgStatusUserNameInsert;
        private System.Windows.Forms.PictureBox imgStatusUserPasswordInsert;
        private System.Windows.Forms.PictureBox imgStatusUserLoginInsert;




    }
}