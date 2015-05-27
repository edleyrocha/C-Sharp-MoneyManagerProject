//------------------------------------------------------------------------------
//
// <git hub="https://github.com/edleyrocha">
//      GitHub Repositories
// </git>
//
// <mail address ="edleyrocha@hotmail.com">
//      Developer Email.
// </mail>
//
//------------------------------------------------------------------------------
namespace MoneyManagerDesktop
{
    #region ---> (Using)
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using MetroFramework.Forms;
    using MetroFramework;
    #endregion
    public partial class frmUsers : MetroForm
    {
        public enum ChoseActionForm
        {
            InsertUsers = 0,
            UpdateUsers = 1,
            DeleteUsers = 2,
            SelectUsers = 3
        }
        ChoseActionForm SelectedAction;
        public frmUsers(ChoseActionForm choseAction)
        {
            InitializeComponent();
            this.SelectedAction = choseAction;
            this.SetConfigStartUser();
        }
        public void SetConfigStartUser()
        {
            this.Text = ("Cadastro");
            // Hide Tabs
            this.mtcUsers.SuspendLayout();
            this.mtcUsers.TabPages.Clear();
            switch (SelectedAction)
            {
                case ChoseActionForm.InsertUsers:
                    {
                        if (!mtcUsers.TabPages.Contains(mtpInsert))
                        {
                            this.Size = new Size(420, 370); // ( 45 , 190)
                            this.mtcUsers.Size = new Size(375, 180);
                            this.mtpInsert.Text = String.Format("{0}{1}{1}{1}{1}{1}", "Novo Usuario", "                  ");
                            this.mtcUsers.TabPages.Add(mtpInsert);
                            this.metroTile_UserInsert.Text = ("");
                            this.btnSaveInsert.Text = ((String)btnSaveInsert.Tag);
                            this.btnCloseInsert.Text = ((String)btnCloseInsert.Tag);
                            this.txtNameInsert.Text = ((String)txtNameInsert.Tag);
                            this.txtLoginInsert.Text = ((String)txtLoginInsert.Tag);
                            this.txtPasswordAInsert.Text = ((String)txtPasswordAInsert.Tag);
                            this.txtPasswordBInsert.Text = ((String)txtPasswordBInsert.Tag);
                        };
                        break;
                    };
                case ChoseActionForm.UpdateUsers:
                    {
                        if (!this.mtcUsers.TabPages.Contains(mtpUpdate))
                        {
                            // this.Size = new Size(615, 395);// ( 45 , 190)
                            //  this.mtcUsers.Size = new Size(570, 205);
                            this.mtpUpdate.Text = String.Format("{0}{1}{1}{1}{1}{1}{1}{1}", "Alterar Usuario", "                  ");
                            this.mtcUsers.TabPages.Add(mtpUpdate);
                            // this.metroTile_UserSelect.Text = ("");
                        };
                        break;
                    };
                case ChoseActionForm.DeleteUsers:
                    {
                        if (!this.mtcUsers.TabPages.Contains(mtpDelete))
                        {
                            this.mtpDelete.Text = String.Format("{0}{1}{1}{1}{1}{1}", "Deletar Usuario", "                  ");
                            this.mtcUsers.TabPages.Add(mtpDelete);
                        };
                        break;
                    };
                case ChoseActionForm.SelectUsers:
                    {
                        if (!this.mtcUsers.TabPages.Contains(mtpSelect))
                        {
                            this.Size = new Size(535, 395);// ( 45 , 190)
                            this.mtcUsers.Size = new Size(490, 205); //
                            this.mtpSelect.Text = String.Format("{0}{1}{1}{1}{1}{1}{1}{1}", "Lista de Usuarios", "                  ");
                            this.mtcUsers.TabPages.Add(mtpSelect);
                            this.metroTile_UserSelect.Text = ("");
                            this.btnCloseSelect.Text = ("Sair");
                            this.btnListSelect.Text = ("Mostar");
                        };
                        break;
                    };
                default:
                    {
                        break;
                    };
            };
            this.mtcUsers.ResumeLayout();
        }

        #region ---> (Select User)

        private void SelectUsers()
        {
            clsUsers u = new clsUsers();
            DataTable dt = u.SelectAllUserCommand();

            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metroGrid1.RowHeadersWidth = (10);
            metroGrid1.ScrollBars = ScrollBars.None;
            metroGrid1.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            metroGrid1.DefaultCellStyle.SelectionForeColor = Color.Black;
            metroGrid1.DefaultCellStyle.BackColor = Color.White;
            metroGrid1.DefaultCellStyle.ForeColor = Color.Black;

            metroGrid1.DataSource = dt;

            metroGrid1.ClearSelection();

            metroGrid1.Refresh();
        }
        private void btnListSelect_Click(object sender, EventArgs e)
        {
            this.SelectUsers();
        }

        private void btnCloseSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ---> (Insert Users)

        MetroFramework.Components.MetroToolTip mttHintNameInsert = new MetroFramework.Components.MetroToolTip();
        MetroFramework.Components.MetroToolTip mttHintLoginInsert = new MetroFramework.Components.MetroToolTip();
        MetroFramework.Components.MetroToolTip mttHintPasswordInsert = new MetroFramework.Components.MetroToolTip();

        Boolean insertNameStatus = (false);
        Boolean insertLoginStatus = (false);
        Boolean insertPasswordStatus = (false);

        private void InsertUser()
        {
            clsUsers u = new clsUsers();
            u.nome = (txtNameInsert.Text);
            u.login = (txtLoginInsert.Text);
            u.password = (txtPasswordAInsert.Text);
            u.status = (Convert.ToString(clsUsers.StatusUser.Enabled));

            string msgResult = u.InsertUsersCommand();

            if (msgResult == Boolean.FalseString)
            {
                MessageBox.Show("Erro ao Cadastrar novo Usuario");
            }
            else if (msgResult == Boolean.TrueString)
            {
                String msg_Title = String.Format("{0}{1}", "Usuario", " :)");
                String msg_Text = String.Format("{0}{1}", "\r\r", "Cadastrado com Sucesso");
                MessageBoxButtons msg_Buttons = MessageBoxButtons.OK;
                MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                DialogResult diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
            };
        }

        private void btnSaveInsert_Click(object sender, EventArgs e)
        {
            if ((insertNameStatus == (true)) && (insertLoginStatus == (true)) && (insertPasswordStatus == (true)))
            {
                this.InsertUser();
                insertNameStatus = (false);
                insertLoginStatus = (false);
                insertPasswordStatus = (false);
            }
        }
        private void btnCloseInsert_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region ---> (txtNameInsert)

        private void txtNameInsert_Enter(object sender, EventArgs e)
        {
            this.txtNameInsert.Text = ("");
        }

        private void txtNameInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }

        private void txtNameInsert_Leave(object sender, EventArgs e)
        {
            txtNameInsertLeave();
        }

        private void txtNameInsertLeave()
        {
            insertNameStatus = (false);
            clsUsers u = new clsUsers();
            u.nome = (txtNameInsert.Text);
            string msgResult = u.CheckUserNameInsertExist();

            if (String.IsNullOrEmpty(this.txtNameInsert.Text))
            {
                mttHintNameInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintNameInsert.Style = (this.Style);
                mttHintNameInsert.Show("Nome inválido", this.imgStatusUserNameInsert, 2000);
                mttHintNameInsert.SetToolTip(this.imgStatusUserNameInsert, "Nome inválido");
                imgStatusUserNameInsert.Cursor = Cursors.Hand;

                this.txtNameInsert.Text = ((String)txtNameInsert.Tag);
                this.imgStatusUserNameInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else if (msgResult == (Boolean.FalseString))
            {
                mttHintNameInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintNameInsert.Style = MetroColorStyle.Blue;
                mttHintNameInsert.Show("Nome já existe", this.imgStatusUserNameInsert, 2000);
                mttHintNameInsert.SetToolTip(this.imgStatusUserNameInsert, "Nome já existe");
                imgStatusUserNameInsert.Cursor = Cursors.Hand;
                this.imgStatusUserNameInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else if (msgResult == (Boolean.TrueString))
            {
                insertNameStatus = (true);
                mttHintNameInsert.RemoveAll();
                imgStatusUserNameInsert.Cursor = Cursors.Default;
                this.imgStatusUserNameInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_accept16;
            };
        }

        #endregion

        #region ---> (txtLoginInsert)

        private void txtLoginInsert_Enter(object sender, EventArgs e)
        {
            this.txtLoginInsert.Text = ("");
        }
        private void txtLoginInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }

        private void txtLoginInsert_Leave(object sender, EventArgs e)
        {
            txtLoginInsertLeave();
        }

        private void txtLoginInsertLeave()
        {
            insertLoginStatus = (false);
            clsUsers u = new clsUsers();
            u.login = (txtLoginInsert.Text);
            string msgResult = u.CheckUserLoginInsertExist();

            if (String.IsNullOrEmpty(this.txtLoginInsert.Text))
            {
                mttHintLoginInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintLoginInsert.Style = (this.Style);
                mttHintLoginInsert.Show("Login inválido", this.imgStatusUserLoginInsert, 2000);
                mttHintLoginInsert.SetToolTip(this.imgStatusUserLoginInsert, "Login inválido");
                imgStatusUserLoginInsert.Cursor = Cursors.Hand;

                this.txtLoginInsert.Text = ((String)txtLoginInsert.Tag);
                this.imgStatusUserLoginInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else if (msgResult == (Boolean.FalseString))
            {
                mttHintLoginInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintLoginInsert.Style = MetroColorStyle.Blue;
                mttHintLoginInsert.Show("Login já existe", this.imgStatusUserLoginInsert, 2000);
                mttHintLoginInsert.SetToolTip(this.imgStatusUserLoginInsert, "Login já existe");
                imgStatusUserLoginInsert.Cursor = Cursors.Hand;
                this.imgStatusUserLoginInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else
            {
                insertLoginStatus = (true);
                mttHintLoginInsert.RemoveAll();
                imgStatusUserLoginInsert.Cursor = Cursors.Default;
                this.imgStatusUserLoginInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_accept16;
            };
        }

        #endregion

        #region ---> (txtPassword)

        private void txtPasswordAInsert_Enter(object sender, EventArgs e)
        {
            this.txtPasswordAInsert.Text = ("");
            if (txtPasswordAInsert.UseSystemPasswordChar == (false))
            {
                txtPasswordAInsert.UseSystemPasswordChar = (true);
            };
        }

        private void txtPasswordBInsert_Enter(object sender, EventArgs e)
        {
            this.txtPasswordBInsert.Text = ("");
            if (txtPasswordBInsert.UseSystemPasswordChar == (false))
            {
                txtPasswordBInsert.UseSystemPasswordChar = (true);
            };
        }

        private void txtPasswordAInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }

        private void txtPasswordBInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }

        private void txtPasswordAInsert_Leave(object sender, EventArgs e)
        {
            txtPasswordAInsertLeave();
        }
        private void txtPasswordAInsertLeave()
        {
            if ((String.IsNullOrEmpty(this.txtPasswordAInsert.Text)) ||
               ((this.txtPasswordAInsert.Text) == (String)txtPasswordAInsert.Tag))
            {
                mttHintPasswordInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintPasswordInsert.Style = (this.Style);
                mttHintPasswordInsert.Show("Senha inválida", this.imgStatusUserPasswordInsert, 2000);
                mttHintPasswordInsert.SetToolTip(this.imgStatusUserPasswordInsert, "Senha inválida");
                imgStatusUserPasswordInsert.Cursor = Cursors.Hand;
                this.imgStatusUserPasswordInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else
            {
                mttHintPasswordInsert.RemoveAll();
                imgStatusUserPasswordInsert.Cursor = Cursors.Default;
                this.imgStatusUserPasswordInsert.Image = null;
            };
        }
        private void txtPasswordBInsert_Leave(object sender, EventArgs e)
        {
            txtPasswordBInsertLeave();
        }
        private void txtPasswordBInsertLeave()
        {
            insertPasswordStatus = (false);
            if ((String.IsNullOrEmpty(this.txtPasswordBInsert.Text)) ||
               ((this.txtPasswordBInsert.Text) == (String)txtPasswordBInsert.Tag))
            {
                mttHintPasswordInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintPasswordInsert.Style = (this.Style);
                mttHintPasswordInsert.Show("Senha inválida", this.imgStatusUserPasswordInsert, 2000);
                mttHintPasswordInsert.SetToolTip(this.imgStatusUserPasswordInsert, "Senha inválida");
                imgStatusUserPasswordInsert.Cursor = Cursors.Hand;

                this.imgStatusUserPasswordInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else if ((this.txtPasswordBInsert.Text) != (this.txtPasswordAInsert.Text))
            {
                mttHintPasswordInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintPasswordInsert.Style = MetroColorStyle.Blue;
                mttHintPasswordInsert.Show("Password não Combina", this.imgStatusUserPasswordInsert, 2000);
                mttHintPasswordInsert.SetToolTip(this.imgStatusUserPasswordInsert, "Password não Combina");
                imgStatusUserPasswordInsert.Cursor = Cursors.Hand;
                this.imgStatusUserPasswordInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else
            {
                insertPasswordStatus = (true);
                mttHintPasswordInsert.RemoveAll();
                imgStatusUserPasswordInsert.Cursor = Cursors.Default;
                this.imgStatusUserPasswordInsert.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_accept16;
            };
        }

        #endregion



        #endregion

    }
}