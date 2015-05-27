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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtcUsers = new MetroFramework.Controls.MetroTabControl();
            this.mtpSelect = new MetroFramework.Controls.MetroTabPage();
            this.btnCloseSelect = new System.Windows.Forms.Button();
            this.metroTile_UserSelect = new MetroFramework.Controls.MetroTile();
            this.mtpInsert = new MetroFramework.Controls.MetroTabPage();
            this.imgStatusUserPasswordInsert = new System.Windows.Forms.PictureBox();
            this.imgStatusUserLoginInsert = new System.Windows.Forms.PictureBox();
            this.imgStatusUserNameInsert = new System.Windows.Forms.PictureBox();
            this.metroTile_UserInsert = new MetroFramework.Controls.MetroTile();
            this.txtPasswordBInsert = new MetroFramework.Controls.MetroTextBox();
            this.txtPasswordAInsert = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginInsert = new MetroFramework.Controls.MetroTextBox();
            this.txtNameInsert = new MetroFramework.Controls.MetroTextBox();
            this.btnCloseInsert = new MetroFramework.Controls.MetroButton();
            this.btnSaveInsert = new MetroFramework.Controls.MetroButton();
            this.mtpUpdate = new MetroFramework.Controls.MetroTabPage();
            this.mtpDelete = new MetroFramework.Controls.MetroTabPage();
            this.btnListSelect = new System.Windows.Forms.Button();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.mtcUsers.SuspendLayout();
            this.mtpSelect.SuspendLayout();
            this.mtpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserPasswordInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserLoginInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserNameInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcUsers
            // 
            this.mtcUsers.Controls.Add(this.mtpSelect);
            this.mtcUsers.Controls.Add(this.mtpInsert);
            this.mtcUsers.Controls.Add(this.mtpUpdate);
            this.mtcUsers.Controls.Add(this.mtpDelete);
            this.mtcUsers.Location = new System.Drawing.Point(23, 63);
            this.mtcUsers.Name = "mtcUsers";
            this.mtcUsers.SelectedIndex = 0;
            this.mtcUsers.Size = new System.Drawing.Size(490, 205);
            this.mtcUsers.TabIndex = 0;
            this.mtcUsers.UseSelectable = true;
            // 
            // mtpSelect
            // 
            this.mtpSelect.Controls.Add(this.metroGrid1);
            this.mtpSelect.Controls.Add(this.btnListSelect);
            this.mtpSelect.Controls.Add(this.btnCloseSelect);
            this.mtpSelect.Controls.Add(this.metroTile_UserSelect);
            this.mtpSelect.HorizontalScrollbarBarColor = true;
            this.mtpSelect.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpSelect.HorizontalScrollbarSize = 10;
            this.mtpSelect.Location = new System.Drawing.Point(4, 38);
            this.mtpSelect.Name = "mtpSelect";
            this.mtpSelect.Size = new System.Drawing.Size(482, 163);
            this.mtpSelect.TabIndex = 3;
            this.mtpSelect.Text = "%mtpSelect%";
            this.mtpSelect.VerticalScrollbarBarColor = true;
            this.mtpSelect.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSelect.VerticalScrollbarSize = 10;
            // 
            // btnCloseSelect
            // 
            this.btnCloseSelect.Location = new System.Drawing.Point(404, 138);
            this.btnCloseSelect.Name = "btnCloseSelect";
            this.btnCloseSelect.Size = new System.Drawing.Size(75, 23);
            this.btnCloseSelect.TabIndex = 7;
            this.btnCloseSelect.Text = "%btnCloseSelect%";
            this.btnCloseSelect.UseVisualStyleBackColor = true;
            this.btnCloseSelect.Click += new System.EventHandler(this.btnCloseSelect_Click);
            // 
            // metroTile_UserSelect
            // 
            this.metroTile_UserSelect.ActiveControl = null;
            this.metroTile_UserSelect.Location = new System.Drawing.Point(2, 2);
            this.metroTile_UserSelect.Name = "metroTile_UserSelect";
            this.metroTile_UserSelect.Size = new System.Drawing.Size(130, 130);
            this.metroTile_UserSelect.TabIndex = 0;
            this.metroTile_UserSelect.TabStop = false;
            this.metroTile_UserSelect.Text = "        %Foto%";
            this.metroTile_UserSelect.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_UserSelect.TileImage")));
            this.metroTile_UserSelect.UseSelectable = true;
            this.metroTile_UserSelect.UseTileImage = true;
            // 
            // mtpInsert
            // 
            this.mtpInsert.Controls.Add(this.imgStatusUserPasswordInsert);
            this.mtpInsert.Controls.Add(this.imgStatusUserLoginInsert);
            this.mtpInsert.Controls.Add(this.imgStatusUserNameInsert);
            this.mtpInsert.Controls.Add(this.metroTile_UserInsert);
            this.mtpInsert.Controls.Add(this.txtPasswordBInsert);
            this.mtpInsert.Controls.Add(this.txtPasswordAInsert);
            this.mtpInsert.Controls.Add(this.txtLoginInsert);
            this.mtpInsert.Controls.Add(this.txtNameInsert);
            this.mtpInsert.Controls.Add(this.btnCloseInsert);
            this.mtpInsert.Controls.Add(this.btnSaveInsert);
            this.mtpInsert.HorizontalScrollbarBarColor = true;
            this.mtpInsert.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpInsert.HorizontalScrollbarSize = 10;
            this.mtpInsert.Location = new System.Drawing.Point(4, 38);
            this.mtpInsert.Name = "mtpInsert";
            this.mtpInsert.Size = new System.Drawing.Size(562, 163);
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
            this.metroTile_UserInsert.TabStop = false;
            this.metroTile_UserInsert.Text = "        %Foto%";
            this.metroTile_UserInsert.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_UserInsert.TileImage")));
            this.metroTile_UserInsert.UseSelectable = true;
            this.metroTile_UserInsert.UseTileImage = true;
            // 
            // txtPasswordBInsert
            // 
            this.txtPasswordBInsert.Lines = new string[] {
        "%txtPasswordBInsert%"};
            this.txtPasswordBInsert.Location = new System.Drawing.Point(239, 62);
            this.txtPasswordBInsert.MaxLength = 32767;
            this.txtPasswordBInsert.Name = "txtPasswordBInsert";
            this.txtPasswordBInsert.PasswordChar = '\0';
            this.txtPasswordBInsert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordBInsert.SelectedText = "";
            this.txtPasswordBInsert.Size = new System.Drawing.Size(90, 23);
            this.txtPasswordBInsert.TabIndex = 3;
            this.txtPasswordBInsert.Tag = "Repetir-Senha";
            this.txtPasswordBInsert.Text = "%txtPasswordBInsert%";
            this.txtPasswordBInsert.UseSelectable = true;
            this.txtPasswordBInsert.Enter += new System.EventHandler(this.txtPasswordBInsert_Enter);
            this.txtPasswordBInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordBInsert_KeyDown);
            this.txtPasswordBInsert.Leave += new System.EventHandler(this.txtPasswordBInsert_Leave);
            // 
            // txtPasswordAInsert
            // 
            this.txtPasswordAInsert.Lines = new string[] {
        "%txtPasswordAInsert%"};
            this.txtPasswordAInsert.Location = new System.Drawing.Point(145, 62);
            this.txtPasswordAInsert.MaxLength = 32767;
            this.txtPasswordAInsert.Name = "txtPasswordAInsert";
            this.txtPasswordAInsert.PasswordChar = '\0';
            this.txtPasswordAInsert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordAInsert.SelectedText = "";
            this.txtPasswordAInsert.Size = new System.Drawing.Size(90, 23);
            this.txtPasswordAInsert.TabIndex = 2;
            this.txtPasswordAInsert.Tag = "Senha";
            this.txtPasswordAInsert.Text = "%txtPasswordAInsert%";
            this.txtPasswordAInsert.UseSelectable = true;
            this.txtPasswordAInsert.Enter += new System.EventHandler(this.txtPasswordAInsert_Enter);
            this.txtPasswordAInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordAInsert_KeyDown);
            this.txtPasswordAInsert.Leave += new System.EventHandler(this.txtPasswordAInsert_Leave);
            // 
            // txtLoginInsert
            // 
            this.txtLoginInsert.Lines = new string[] {
        "%txtLoginInsert%"};
            this.txtLoginInsert.Location = new System.Drawing.Point(144, 33);
            this.txtLoginInsert.MaxLength = 32767;
            this.txtLoginInsert.Name = "txtLoginInsert";
            this.txtLoginInsert.PasswordChar = '\0';
            this.txtLoginInsert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginInsert.SelectedText = "";
            this.txtLoginInsert.Size = new System.Drawing.Size(185, 23);
            this.txtLoginInsert.TabIndex = 1;
            this.txtLoginInsert.Tag = "Nome do Login";
            this.txtLoginInsert.Text = "%txtLoginInsert%";
            this.txtLoginInsert.UseSelectable = true;
            this.txtLoginInsert.Enter += new System.EventHandler(this.txtLoginInsert_Enter);
            this.txtLoginInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginInsert_KeyDown);
            this.txtLoginInsert.Leave += new System.EventHandler(this.txtLoginInsert_Leave);
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
            this.txtNameInsert.TabIndex = 0;
            this.txtNameInsert.Tag = "Nome do Usuario";
            this.txtNameInsert.Text = "%txtNameInsert%";
            this.txtNameInsert.UseSelectable = true;
            this.txtNameInsert.Enter += new System.EventHandler(this.txtNameInsert_Enter);
            this.txtNameInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameInsert_KeyDown);
            this.txtNameInsert.Leave += new System.EventHandler(this.txtNameInsert_Leave);
            // 
            // btnCloseInsert
            // 
            this.btnCloseInsert.Location = new System.Drawing.Point(254, 110);
            this.btnCloseInsert.Name = "btnCloseInsert";
            this.btnCloseInsert.Size = new System.Drawing.Size(75, 23);
            this.btnCloseInsert.TabIndex = 5;
            this.btnCloseInsert.Tag = "Sair";
            this.btnCloseInsert.Text = "%btnClose%";
            this.btnCloseInsert.UseSelectable = true;
            this.btnCloseInsert.Click += new System.EventHandler(this.btnCloseInsert_Click);
            // 
            // btnSaveInsert
            // 
            this.btnSaveInsert.Location = new System.Drawing.Point(173, 110);
            this.btnSaveInsert.Name = "btnSaveInsert";
            this.btnSaveInsert.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInsert.TabIndex = 4;
            this.btnSaveInsert.Tag = "Salvar";
            this.btnSaveInsert.Text = "%btnSave%";
            this.btnSaveInsert.UseSelectable = true;
            this.btnSaveInsert.Click += new System.EventHandler(this.btnSaveInsert_Click);
            // 
            // mtpUpdate
            // 
            this.mtpUpdate.HorizontalScrollbarBarColor = true;
            this.mtpUpdate.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpUpdate.HorizontalScrollbarSize = 10;
            this.mtpUpdate.Location = new System.Drawing.Point(4, 38);
            this.mtpUpdate.Name = "mtpUpdate";
            this.mtpUpdate.Size = new System.Drawing.Size(562, 163);
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
            this.mtpDelete.Size = new System.Drawing.Size(562, 163);
            this.mtpDelete.TabIndex = 2;
            this.mtpDelete.Text = "%mtpDelete%";
            this.mtpDelete.VerticalScrollbarBarColor = true;
            this.mtpDelete.VerticalScrollbarHighlightOnWheel = false;
            this.mtpDelete.VerticalScrollbarSize = 10;
            // 
            // btnListSelect
            // 
            this.btnListSelect.Location = new System.Drawing.Point(323, 138);
            this.btnListSelect.Name = "btnListSelect";
            this.btnListSelect.Size = new System.Drawing.Size(75, 23);
            this.btnListSelect.TabIndex = 9;
            this.btnListSelect.Text = "%btnListSelect%";
            this.btnListSelect.UseVisualStyleBackColor = true;
            this.btnListSelect.Click += new System.EventHandler(this.btnListSelect_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(139, 4);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(340, 128);
            this.metroGrid1.TabIndex = 10;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 267);
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
            this.mtpSelect.ResumeLayout(false);
            this.mtpInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserPasswordInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserLoginInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatusUserNameInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox txtPasswordAInsert;
        private MetroFramework.Controls.MetroTextBox txtLoginInsert;
        private MetroFramework.Controls.MetroTextBox txtNameInsert;
        private MetroFramework.Controls.MetroTile metroTile_UserInsert;
        private System.Windows.Forms.PictureBox imgStatusUserNameInsert;
        private System.Windows.Forms.PictureBox imgStatusUserPasswordInsert;
        private System.Windows.Forms.PictureBox imgStatusUserLoginInsert;
        private MetroFramework.Controls.MetroTextBox txtPasswordBInsert;
        private System.Windows.Forms.Button btnCloseSelect;
        private MetroFramework.Controls.MetroTile metroTile_UserSelect;
        private System.Windows.Forms.Button btnListSelect;
        private MetroFramework.Controls.MetroGrid metroGrid1;




    }
}