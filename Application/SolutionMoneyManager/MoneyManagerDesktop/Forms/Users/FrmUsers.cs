﻿///////////////////////////////////////////////
//-------------------------------------------//
//                                           //
// <git hub="https://github.com/edleyrocha"> //
//      GitHub Repositories                  //
// </git>                                    //
//                                           //
// <mail address="edleyrocha@hotmail.com">   //
//       Developer Email                     //
// </mail>                                   //
//                                           //
//---------------- --------------------------//
///////////////////// /////////////////////////
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
    public partial class FrmUsers : MetroForm
    {
        public FrmUsers(ChoseActionForm choseAction)
        {
            InitializeComponent();
            this.SelectedAction = (choseAction);
            this.SetConfigStartUsers();
        }
        #region ---> (Form Users)

        public enum ChoseActionForm
        {
            SelectUsers = (0),
            InsertUsers = (1),
            UpdateUsers = (2),
            DeleteUsers = (3),
            RestoreUsers = (4)
        }

        ChoseActionForm SelectedAction;

        public void SetConfigStartUsers()
        {
            // this form
            this.Text = ("Cadastro");
            // Hide Tabs
            this.mtcUsers.SuspendLayout();
            this.mtcUsers.TabPages.Clear();
            switch (SelectedAction)
            {
                case ChoseActionForm.SelectUsers:
                    {
                        if (!this.mtcUsers.TabPages.Contains(mtpSelect))
                        {
                            // this form
                            this.Size = (new Size(535, 300));
                            // mtcUsers
                            this.mtcUsers.Size = (new Size(490, 215));
                            this.mtcUsers.TabPages.Add(mtpSelect);
                            // mtpSelect
                            this.mtpSelect.Text = (String.Format("{0}{1}{1}{1}{1}", "Lista de Usuarios", "                                    "));
                            // lbl
                            this.lblCoutSelect.Text = ("");
                            // imgSelect
                            this.imgSelect.Text = ("");
                            this.imgSelect.UseTileImage = (true);
                            this.imgSelect.TileImageAlign = (ContentAlignment.MiddleCenter);
                            this.imgSelect.TileImage = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersFind128);
                            // btn
                            this.btnCloseSelect.Text = ((String)btnCloseSelect.Tag);
                            this.btnListSelect.Text = ((String)btnListSelect.Tag);
                        };
                        break;
                    };
                case ChoseActionForm.InsertUsers:
                    {
                        if (!mtcUsers.TabPages.Contains(mtpInsert))
                        {
                            // this
                            this.Size = (new Size(400, 300));
                            // mtcUsers
                            this.mtcUsers.Size = (new Size(360, 215));
                            this.mtcUsers.TabPages.Add(mtpInsert);
                            // mtpInsert
                            this.mtpInsert.Text = (String.Format("{0}{1}{1}{1}", "Novo Usuario", "                                    "));
                            // imgInsert
                            this.imgInsert.Text = ("");
                            this.imgInsert.UseTileImage = (true);
                            this.imgInsert.TileImageAlign = (ContentAlignment.MiddleCenter);
                            this.imgInsert.TileImage = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersNew128);
                            // btn
                            this.btnSaveInsert.Text = ((String)btnSaveInsert.Tag);
                            this.btnCloseInsert.Text = ((String)btnCloseInsert.Tag);
                            // txt
                            this.txtNameInsert.Enabled = (false);
                            this.txtLoginInsert.Enabled = (false);
                            this.txtPasswordAInsert.Enabled = (false);
                            this.txtPasswordBInsert.Enabled = (false);
                            this.txtNameInsert.Text = ((String)txtNameInsert.Tag);
                            this.txtLoginInsert.Text = ((String)txtLoginInsert.Tag);
                            this.txtPasswordAInsert.Text = ((String)txtPasswordAInsert.Tag);
                            this.txtPasswordBInsert.Text = ((String)txtPasswordBInsert.Tag);
                            // img
                            this.imgStatusNameInsert.Image = (null);
                            this.imgStatusLoginInsert.Image = (null);
                            this.imgStatusPasswordInsert.Image = (null);
                        };
                        break;
                    };
                case ChoseActionForm.UpdateUsers:
                    {
                        if (!this.mtcUsers.TabPages.Contains(mtpUpdate))
                        {
                            // this
                            this.Size = (new Size(400, 435));
                            // mtcUsers
                            this.mtcUsers.Size = (new Size(360, 355));
                            this.mtcUsers.TabPages.Add(mtpUpdate);
                            // mtpUpdate
                            this.mtpUpdate.Text = (String.Format("{0}{1}{1}", "Atualizar Usuario", "                                    "));
                            // imgUpdate 
                            this.imgUpdate.Text = ("");
                            this.imgUpdate.UseTileImage = (true);
                            this.imgUpdate.TileImageAlign = (ContentAlignment.MiddleCenter);
                            this.imgUpdate.TileImage = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersUpdate128);
                            // lbls
                            this.lblCoutUpdate.Text = ("");
                            this.lblGridUpdate.Text = ("");
                            // Txts
                            this.txtNameUpdate.Text = ((String)txtNameUpdate.Tag);
                            this.txtLoginUpdate.Text = ((String)txtLoginUpdate.Tag);
                            this.txtPasswordAUpdate.Text = ((String)txtPasswordAUpdate.Tag);
                            this.txtPasswordBUpdate.Text = ((String)txtPasswordBUpdate.Tag);
                            this.txtNameUpdate.Enabled = (false);
                            this.txtLoginUpdate.Enabled = (false);
                            this.txtPasswordAUpdate.Enabled = (false);
                            this.txtPasswordBUpdate.Enabled = (false);
                            // btns
                            this.btnCloseUpdate.Text = ((String)btnCloseUpdate.Tag);
                            this.btnUpdateSave.Text = ((String)btnUpdateSave.Tag);
                            // GridView
                            this.metroGrid4.Enabled = (false);
                            this.metroGrid4.TabStop = (false);
                            this.metroGrid4.DataSource = (null);
                            // picture box Update
                            this.imgStatusGridUpdate.Image = (null);
                            this.imgStatusNameUpdate.Image = (null);
                            this.imgStatusLoginUpdate.Image = (null);
                            this.imgStatusPasswordUpdate.Image = (null);
                        };
                        break;
                    };
                case ChoseActionForm.DeleteUsers:
                    {
                        if (!this.mtcUsers.TabPages.Contains(mtpDelete))
                        {
                            // this
                            this.Size = (new Size(535, 300));
                            // mtcUsers
                            this.mtcUsers.Size = (new Size(490, 215));
                            this.mtcUsers.TabPages.Add(mtpDelete);
                            // mtpDelete
                            this.mtpDelete.Text = (String.Format("{0}{1}{1}{1}{1}", "Deletar Usuario", "                                    "));
                            // imgDelete 
                            this.imgDelete.Text = ("");
                            this.imgDelete.UseTileImage = (true);
                            this.imgDelete.TileImageAlign = (ContentAlignment.MiddleCenter);
                            this.imgDelete.TileImage = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersDelete128);
                            // lbl
                            this.lblCoutDelete.Text = ("");
                            // btn
                            this.btnCloseDelete.Text = ((String)btnCloseDelete.Tag);
                            this.btnDeleteUsers.Text = ((String)btnDeleteUsers.Tag);
                        };
                        break;
                    };
                case ChoseActionForm.RestoreUsers:
                    {
                        if (!this.mtcUsers.TabPages.Contains(mtpRestore))
                        {
                            // this
                            this.Size = new Size(535, 300);
                            // mtcUsers
                            this.mtcUsers.Size = new Size(490, 215);
                            this.mtcUsers.TabPages.Add(mtpRestore);
                            // mtpRestore
                            this.mtpRestore.Text = String.Format("{0}{1}{1}{1}{1}", "Restaurar Usuarios", "                                    ");
                            // imgRestore 
                            this.imgRestore.Text = ("");
                            this.imgRestore.UseTileImage = (true);
                            this.imgRestore.TileImageAlign = (ContentAlignment.MiddleCenter);
                            this.imgRestore.TileImage = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersRecover128);
                            // lbl
                            this.lblCoutRestore.Text = ("");
                            // btn
                            this.btnRestoreUsers.Text = ((String)btnRestoreUsers.Tag);
                            this.btnCloseRestore.Text = ((String)btnCloseRestore.Tag);
                        }
                        break;
                    };
                default:
                    {
                        break; //Standard not Open   :(
                    };
            };
            this.mtcUsers.ResumeLayout();
        }

        private void metroTile_Users_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode) == (Keys.Escape))
            {
                this.Close();
            };
        }

        #endregion

        #region ---> (Select Users)

        private void ShowDataGrid‎Select()
        {
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metroGrid1.RowHeadersWidth = (10);
            metroGrid1.ScrollBars = ScrollBars.None;

            metroGrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            metroGrid1.ColumnHeadersDefaultCellStyle.Font = mtpInsert.Font;

            metroGrid1.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            metroGrid1.DefaultCellStyle.SelectionForeColor = Color.Black;

            metroGrid1.DefaultCellStyle.BackColor = Color.White;
            metroGrid1.DefaultCellStyle.ForeColor = Color.Black;

            ClsUsers objClsUsersSelect = new ClsUsers();

            DataTable objDataTable = objClsUsersSelect.SelectNameLoginForStatus(ClsUsers.StatusUser.Enabled);

            metroGrid1.DataSource = objDataTable;
            metroGrid1.ClearSelection();
            metroGrid1.Refresh();
        }

        private void SelectUsers()
        {
            this.ShowDataGrid‎Select();
            String CountRows = (metroGrid1.RowCount.ToString());
            if ((metroGrid1.RowCount) == (0))
            {
                this.lblCoutSelect.Text = String.Format(("{0}"), ("Nenhum Registro Encontrado"));
            }
            else if ((metroGrid1.RowCount) == (1))
            {
                this.lblCoutSelect.Text = String.Format(("{0} {1}"), (CountRows), ("Registro Encontrado"));
            }
            else if ((metroGrid1.RowCount) >= (2))
            {
                this.lblCoutSelect.Text = String.Format(("{0} {1}"), (CountRows), ("Registros Encontrados"));
            };
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

        MetroFramework.Components.MetroToolTip mttHintNameInsert = (new MetroFramework.Components.MetroToolTip());
        MetroFramework.Components.MetroToolTip mttHintLoginInsert = (new MetroFramework.Components.MetroToolTip());
        MetroFramework.Components.MetroToolTip mttHintPasswordInsert = (new MetroFramework.Components.MetroToolTip());
        
        Boolean insertNameStatus = (false);
        Boolean insertLoginStatus = (false);
        Boolean insertPasswordStatus = (false);

        private void InsertUsers()
        {
            if ((btnSaveInsert.Tag.ToString().Trim()) == (btnSaveInsert.Text.Trim()))
            {

                this.btnSaveInsert.Text = ("Salvar");
                this.btnCloseInsert.Text = ("Cancelar");
                this.txtNameInsert.Text = ("");
                this.txtNameInsert.Enabled = (true);
                this.txtLoginInsert.Enabled = (true);
                this.txtPasswordAInsert.Enabled = (true);
                this.txtPasswordBInsert.Enabled = (true);
                this.txtNameInsert.Focus();
            }
            else if ((btnSaveInsert.Text.Trim()) == ("Salvar"))
            {
                this.txtNameInsertLeave();
                this.txtLoginInsertLeave();
                this.txtPasswordAInsertLeave();
                this.txtPasswordBInsertLeave();

                if ((insertNameStatus == (true)) && (insertLoginStatus == (true)) && (insertPasswordStatus == (true)))
                {
                    ClsUsers objClsUsers = new ClsUsers();
                    objClsUsers.name = ((txtNameInsert.Text).Trim());
                    objClsUsers.login = ((txtLoginInsert.Text).Trim());
                    objClsUsers.password = ((txtPasswordAInsert.Text).Trim());
                    objClsUsers.status = (Convert.ToString(ClsUsers.StatusUser.Enabled));

                    string msgResult = (objClsUsers.InsertNewUsersCommand());

                    if ((msgResult) == (Boolean.FalseString))
                    {
                        MessageBox.Show("Erro ao Cadastrar novo Usuario");
                    }
                    else if ((msgResult) == (Boolean.TrueString))
                    {
                        this.SetConfigStartUsers();
                        String msg_Title = (String.Format("{0}{1}", (objClsUsers.name), " :)"));
                        String msg_Text = (String.Format("{0}{1}", "\r\r", "Cadastrado com Sucesso"));
                        MessageBoxButtons msg_Buttons = (MessageBoxButtons.OK);
                        MessageBoxIcon msg_Icon = (MessageBoxIcon.None);
                        MessageBoxDefaultButton msg_ButtonsDefault = (MessageBoxDefaultButton.Button1);
                        DialogResult diagResult = (MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault));
                    };
                };
            };
        }
        private void btnSaveInsert_Click(object sender, EventArgs e)
        {
            this.InsertUsers();
        }
        private void btnCloseInsert_Click(object sender, EventArgs e)
        {
            if ((btnCloseInsert.Tag.ToString().Trim()) == (btnCloseInsert.Text.Trim()))
            {
                this.Close();
            }
            else if ((btnCloseInsert.Text.ToString().Trim()) == (("Cancelar").Trim()))
            {
                String msg_Title = (this.mtpInsert.Text);
                String msg_Text = ("\r\rCancelar Cadastro?");
                MessageBoxButtons msg_Buttons = (MessageBoxButtons.YesNo);
                MessageBoxIcon msg_Icon = (MessageBoxIcon.None);
                MessageBoxDefaultButton msg_ButtonsDefault = (MessageBoxDefaultButton.Button1);
                DialogResult diagResult = (MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault));

                if ((diagResult) == (DialogResult.Yes))
                {
                    this.SetConfigStartUsers();
                }
                else if (diagResult == DialogResult.No)
                {
                    this.txtNameInsert.Focus();
                }
            };
        }

        #region ---> (txtNameInsert)

        private void txtNameInsert_Enter(object sender, EventArgs e)
        {
            this.txtNameInsert.Text = ("");
        }

        private void txtNameInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode) == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = (true);
            };
        }

        private void txtNameInsert_Leave(object sender, EventArgs e)
        {
            this.txtNameInsertLeave();
        }

        private void txtNameInsertLeave()
        {
            insertNameStatus = (false);
            ClsUsers u = new ClsUsers();
            u.name = (txtNameInsert.Text.Trim());
            string msgResult = u.CheckUserNameInsertExist();

            if (String.IsNullOrEmpty(this.txtNameInsert.Text.Trim()) || (this.txtNameInsert.Text.Trim()) == (((String)txtNameInsert.Tag).Trim()))
            {
                mttHintNameInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintNameInsert.Style = (this.Style);
                mttHintNameInsert.SetToolTip(this.imgStatusNameInsert, "Nome inválido");
                imgStatusNameInsert.Cursor = Cursors.Hand;

                this.txtNameInsert.Text = ((String)txtNameInsert.Tag);
                this.imgStatusNameInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else if (msgResult == (Boolean.FalseString))
            {
                mttHintNameInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintNameInsert.Style = MetroColorStyle.Blue;
                mttHintNameInsert.SetToolTip(this.imgStatusNameInsert, "Nome já existe");
                imgStatusNameInsert.Cursor = Cursors.Hand;
                this.imgStatusNameInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else if (msgResult == (Boolean.TrueString))
            {
                insertNameStatus = (true);
                mttHintNameInsert.RemoveAll();
                imgStatusNameInsert.Cursor = Cursors.Default;
                this.imgStatusNameInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
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
            this.txtLoginInsertLeave();
        }

        private void txtLoginInsertLeave()
        {
            insertLoginStatus = (false);
            ClsUsers objClsUsers = new ClsUsers();
            objClsUsers.login = (txtLoginInsert.Text);
            string msgResult = (objClsUsers.CheckUserLoginInsertExist());

            if (String.IsNullOrEmpty(this.txtLoginInsert.Text.Trim()) || (this.txtLoginInsert.Text.Trim()) == (((String)txtLoginInsert.Tag).Trim()))
            {
                mttHintLoginInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintLoginInsert.Style = (this.Style);
                mttHintLoginInsert.Show("Login inválido", this.imgStatusLoginInsert, 2000);
                mttHintLoginInsert.SetToolTip(this.imgStatusLoginInsert, "Login inválido");
                imgStatusLoginInsert.Cursor = Cursors.Hand;

                this.txtLoginInsert.Text = ((String)txtLoginInsert.Tag);
                this.imgStatusLoginInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else if (msgResult == (Boolean.FalseString))
            {
                mttHintLoginInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintLoginInsert.Style = MetroColorStyle.Blue;
                mttHintLoginInsert.Show("Login já existe", this.imgStatusLoginInsert, 2000);
                mttHintLoginInsert.SetToolTip(this.imgStatusLoginInsert, "Login já existe");
                imgStatusLoginInsert.Cursor = Cursors.Hand;
                this.imgStatusLoginInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else
            {
                insertLoginStatus = (true);
                mttHintLoginInsert.RemoveAll();
                imgStatusLoginInsert.Cursor = Cursors.Default;
                this.imgStatusLoginInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
            };
        }

        #endregion

        #region ---> (txtPasswordInsert)

        private void txtPasswordAInsertLeave()
        {
            if ((String.IsNullOrEmpty(this.txtPasswordAInsert.Text)) || ((this.txtPasswordAInsert.Text) == (String)txtPasswordAInsert.Tag))
            {
                mttHintPasswordInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintPasswordInsert.Style = (this.Style);
                mttHintPasswordInsert.Show("Senha inválida", this.imgStatusPasswordInsert, 2000);
                mttHintPasswordInsert.SetToolTip(this.imgStatusPasswordInsert, "Senha inválida");
                imgStatusPasswordInsert.Cursor = Cursors.Hand;
                this.imgStatusPasswordInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else
            {
                mttHintPasswordInsert.RemoveAll();
                imgStatusPasswordInsert.Cursor = Cursors.Default;
                this.imgStatusPasswordInsert.Image = null;
            };
        }

        private void txtPasswordBInsertLeave()
        {
            insertPasswordStatus = (false);
            if ((String.IsNullOrEmpty(this.txtPasswordBInsert.Text)) ||
               ((this.txtPasswordBInsert.Text) == (String)txtPasswordBInsert.Tag))
            {
                mttHintPasswordInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintPasswordInsert.Style = (this.Style);
                mttHintPasswordInsert.Show("Senha inválida", this.imgStatusPasswordInsert, 2000);
                mttHintPasswordInsert.SetToolTip(this.imgStatusPasswordInsert, "Senha inválida");
                imgStatusPasswordInsert.Cursor = Cursors.Hand;

                this.imgStatusPasswordInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else if ((this.txtPasswordBInsert.Text) != (this.txtPasswordAInsert.Text))
            {
                mttHintPasswordInsert.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                mttHintPasswordInsert.Style = MetroColorStyle.Blue;
                mttHintPasswordInsert.Show("Senha não Combina", this.imgStatusPasswordInsert, 2000);
                mttHintPasswordInsert.SetToolTip(this.imgStatusPasswordInsert, "Senha não Combina");
                imgStatusPasswordInsert.Cursor = Cursors.Hand;
                this.imgStatusPasswordInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else
            {
                insertPasswordStatus = (true);
                mttHintPasswordInsert.RemoveAll();
                imgStatusPasswordInsert.Cursor = Cursors.Default;
                this.imgStatusPasswordInsert.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
            };
        }

        private void txtPasswordAInsert_Enter(object sender, EventArgs e)
        {
            this.txtPasswordAInsert.Text = ("");
            if (txtPasswordAInsert.UseSystemPasswordChar == (false))
            {
                txtPasswordAInsert.UseSystemPasswordChar = (true);
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

        private void txtPasswordAInsert_Leave(object sender, EventArgs e)
        {
            this.txtPasswordAInsertLeave();
        }

        private void txtPasswordBInsert_Enter(object sender, EventArgs e)
        {
            this.txtPasswordBInsert.Text = ("");
            if (txtPasswordBInsert.UseSystemPasswordChar == (false))
            {
                txtPasswordBInsert.UseSystemPasswordChar = (true);
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

        private void txtPasswordBInsert_Leave(object sender, EventArgs e)
        {
            this.txtPasswordBInsertLeave();
        }

        #endregion

        #endregion

        #region ---> (Update Users)

        MetroFramework.Components.MetroToolTip mttHintNameUpdate = new MetroFramework.Components.MetroToolTip();
        MetroFramework.Components.MetroToolTip mttHintLoginUpdate = new MetroFramework.Components.MetroToolTip();
        MetroFramework.Components.MetroToolTip mttHintPasswordUpdate = new MetroFramework.Components.MetroToolTip();

        Boolean updateNameStatus = (false);
        Boolean updateLoginStatus = (false);
        Boolean updatePasswordStatus = (false);

        private void ShowDataGrid‎Update()
        {
            metroGrid4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metroGrid4.RowHeadersWidth = (10);
            metroGrid4.ScrollBars = ScrollBars.None;

            metroGrid4.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            metroGrid4.ColumnHeadersDefaultCellStyle.Font = mtpInsert.Font;

            metroGrid4.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            metroGrid4.DefaultCellStyle.SelectionForeColor = Color.Black;

            metroGrid4.DefaultCellStyle.BackColor = Color.White;
            metroGrid4.DefaultCellStyle.ForeColor = Color.Black;

            ClsUsers u = new ClsUsers();

            ClsUsers.StatusUser StatusSelected = ClsUsers.StatusUser.Enabled;
            DataTable dataTableListUsers = u.SelectNameForStatus(StatusSelected);

            metroGrid4.DataSource = dataTableListUsers;
            metroGrid4.ClearSelection();
            metroGrid4.Refresh();
        }

        private void CheckSelectedDadaGrigUpdate()
        {
            if ((metroGrid4.RowCount) >= (1))
            {
                bool flag = metroGrid4.CurrentRow.Selected;

                if (flag)
                {
                    this.imgStatusGridUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
                    this.lblGridUpdate.Text = ("Registro Selecionado");
                    this.btnUpdateSave.Enabled = (true);
                }
                else
                {
                    this.imgStatusGridUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
                    this.lblGridUpdate.Text = ("Selecione um Registro");
                    this.btnUpdateSave.Enabled = (false);
                };
            }
        }

        private string GetNameSelectedOnDataGridUpdate()
        {
            String returnString = ("");
            String CountRows = (metroGrid4.RowCount.ToString());

            if (metroGrid4.RowCount == (0))
            {
                returnString = String.Format(("{0}"), ("Nenhum Registro Encontrado"));
                lblCoutUpdate.Text = (returnString);
                this.btnUpdateSave.Enabled = (false);
            }
            else if (metroGrid4.RowCount >= (1))
            {
                bool flag = metroGrid4.CurrentRow.Selected;
                if (flag)
                {
                    int rowIndexSelected = metroGrid4.CurrentCell.RowIndex;
                    int columIndexSelected = metroGrid4.CurrentCell.ColumnIndex;
                    String nameSelectedOnGrid = (String)(metroGrid4.Rows[(rowIndexSelected)].Cells[columIndexSelected].Value);
                    returnString = String.Format(("{0}"), (nameSelectedOnGrid));
                    lblCoutUpdate.Text = (returnString);
                };
            };
            return returnString;
        }

        private void ShowDataOnTxTBox()
        {
            ClsUsers u = new ClsUsers();

            ClsUsers.StatusUser StatusSelected = ClsUsers.StatusUser.Enabled;
            String NameSelected = this.GetNameSelectedOnDataGridUpdate();
            DataTable dataTableListUsers = u.SelectNameLoginPasswordForStatus(NameSelected, StatusSelected);

            this.txtPasswordAUpdate.UseSystemPasswordChar = (true);
            this.txtPasswordBUpdate.UseSystemPasswordChar = (true);

            this.txtNameUpdate.Text = (dataTableListUsers.Rows[0]["Name"].ToString().Trim());
            this.txtLoginUpdate.Text = (dataTableListUsers.Rows[0]["Login"].ToString().Trim());
            this.txtPasswordAUpdate.Text = (dataTableListUsers.Rows[0]["Password"].ToString().Trim());
            this.txtPasswordBUpdate.Text = (dataTableListUsers.Rows[0]["Password"].ToString().Trim());
        }

        private void UpdateUsers()
        {
            if ((btnUpdateSave.Tag.ToString().Trim()) == (btnUpdateSave.Text.Trim()))
            {
                this.btnUpdateSave.Text = ("Editar");
                this.btnUpdateSave.Enabled = (false);
                this.ShowDataGrid‎Update();

                this.metroGrid4.Enabled = (true);

                String CountRows = (metroGrid4.RowCount.ToString());

                if ((metroGrid4.RowCount) == (0))
                {
                    this.lblCoutUpdate.Text = String.Format(("{0}"), ("Nenhum Registro Encontrado"));
                    this.metroGrid4.Enabled = (false);
                    this.btnUpdateSave.Enabled = (false);
                }
                else if ((metroGrid4.RowCount) == (1))
                {
                    this.lblCoutUpdate.Text = String.Format(("{0} {1}"), (CountRows), ("Registro Encontrado"));
                }
                else if ((metroGrid4.RowCount) >= (2))
                {
                    this.lblCoutUpdate.Text = String.Format(("{0} {1}"), (CountRows), ("Registros Encontrados"));
                };
            }
            else if ((btnUpdateSave.Text.ToString().Trim()) == (("Editar").Trim()))
            {
                bool flag = metroGrid4.CurrentRow.Selected;

                if (flag)
                {
                    this.ShowDataOnTxTBox();

                    this.metroGrid4.Enabled = (false);
                    this.txtNameUpdate.Enabled = (true);
                    this.txtLoginUpdate.Enabled = (true);
                    this.txtPasswordAUpdate.Enabled = (true);
                    this.txtPasswordBUpdate.Enabled = (true);

                    this.btnUpdateSave.Text = ("Salvar");
                    this.btnCloseUpdate.Text = ("Cancelar");
                    this.imgStatusGridUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
                    this.lblGridUpdate.Text = ("Editando registro. Aguarndo....");
                }
                else
                {
                    this.CheckSelectedDadaGrigUpdate();
                };

            }
            else if ((btnUpdateSave.Text.ToString().Trim()) == (("Salvar").Trim()))
            {

                this.txtNameUpdateLeave();
                this.txtLoginUpdateLeave();
                this.txtPasswordAUpdateLeave();
                this.txtPasswordBUpdateLeave();

                if ((updateNameStatus) && (updateLoginStatus) && (updatePasswordStatus))
                {

                    ClsUsers u = new ClsUsers();
                    u.name = ((txtNameUpdate.Text).Trim());
                    u.login = ((txtLoginUpdate.Text).Trim());
                    u.password = ((txtPasswordAUpdate.Text).Trim());

                    string updateName = GetNameSelectedOnDataGridUpdate();
                    string msgResult = u.UpdateNameLoginPasswordForName(updateName);

                    if (msgResult == Boolean.FalseString)
                    {
                        MessageBox.Show("Erro ao Editado Usuario");
                    }
                    else if (msgResult == Boolean.TrueString)
                    {
                        this.SetConfigStartUsers();
                        String msg_Title = String.Format("{0}{1}", (u.name), " :)");
                        String msg_Text = String.Format("{0}{1}", "\r\r", "Editado com Sucesso");
                        MessageBoxButtons msg_Buttons = MessageBoxButtons.OK;
                        MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                        MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                        DialogResult diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
                    };
                }
                else
                {
                    MessageBox.Show("Erro ao Editar Usuario");
                };
            };
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            this.UpdateUsers();
        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            if ((btnCloseUpdate.Tag.ToString().Trim()) == (btnCloseUpdate.Text.Trim()))
            {
                this.Close();
            }
            else if ((btnCloseUpdate.Text.ToString().Trim()) == (("Cancelar").Trim()))
            {
                String msg_Title = (GetNameSelectedOnDataGridUpdate());
                String msg_Text = ("\r\rCancelar o Registro Selecionado?");
                MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                DialogResult diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);

                if (diagResult == DialogResult.Yes)
                {
                    this.SetConfigStartUsers();
                }
                else if (diagResult == DialogResult.No)
                {
                    this.txtNameUpdate.Focus();
                }
            };
        }

        private void metroGrid4_MouseClick(object sender, MouseEventArgs e)
        {
            this.GetNameSelectedOnDataGridUpdate();
            this.CheckSelectedDadaGrigUpdate();
        }

        private void metroGrid4_KeyUp(object sender, KeyEventArgs e)
        {
            this.GetNameSelectedOnDataGridUpdate();
            this.CheckSelectedDadaGrigUpdate();
        }

        #region ---> (txtNameUpdate)

        private void txtNameUpdateLeave()
        {
            this.updateNameStatus = (false);

            ClsUsers u = new ClsUsers();

            ClsUsers.StatusUser StatusSelected = ClsUsers.StatusUser.Enabled;
            String NameSelected = this.GetNameSelectedOnDataGridUpdate();
            DataTable dataTableListUsers = u.SelectNameLoginPasswordForStatus(NameSelected, StatusSelected);

            String myName = (dataTableListUsers.Rows[0]["Name"].ToString().Trim());
            String myNewName = (this.txtNameUpdate.Text.Trim());

            if ((myName.ToUpper()) == (myNewName.ToUpper()))
            {
                this.updateNameStatus = true;
                this.mttHintNameUpdate.RemoveAll();
                this.imgStatusNameUpdate.Cursor = Cursors.Default;
                this.imgStatusNameUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
            }
            else
            {
                u.name = (txtNameUpdate.Text.Trim());
                string msgResult = u.CheckUserNameInsertExist();

                if (String.IsNullOrEmpty(this.txtNameUpdate.Text.Trim()))
                {
                    this.mttHintNameUpdate.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                    this.mttHintNameUpdate.Style = (this.Style);
                    this.mttHintNameUpdate.Show("Nome inválido", this.imgStatusNameUpdate, 2000);
                    this.mttHintNameUpdate.SetToolTip(this.imgStatusNameUpdate, "Nome inválido");

                    this.imgStatusNameUpdate.Cursor = Cursors.Hand;
                    this.imgStatusNameUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
                }
                else if (msgResult == (Boolean.FalseString))
                {
                    this.mttHintNameUpdate.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                    this.mttHintNameUpdate.Style = (this.Style);
                    this.mttHintNameUpdate.Show("Nome já existe", this.imgStatusNameUpdate, 2000);
                    this.mttHintNameUpdate.SetToolTip(this.imgStatusNameUpdate, "Nome já existe");

                    this.imgStatusNameUpdate.Cursor = Cursors.Hand;
                    this.imgStatusNameUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
                }
                else if (msgResult == (Boolean.TrueString))
                {
                    this.updateNameStatus = true;
                    this.mttHintNameUpdate.RemoveAll();
                    this.imgStatusNameUpdate.Cursor = Cursors.Default;
                    this.imgStatusNameUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
                };
            };
        }

        private void txtNameUpdate_Leave(object sender, EventArgs e)
        {
            this.txtNameUpdateLeave();
        }

        private void txtNameUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }

        #endregion

        #region ---> (txtLoginUpdate)

        private void txtLoginUpdateLeave()
        {
            this.updateLoginStatus = (false);

            ClsUsers u = new ClsUsers();

            ClsUsers.StatusUser StatusSelected = ClsUsers.StatusUser.Enabled;
            String NameSelected = this.GetNameSelectedOnDataGridUpdate();
            DataTable dataTableListUsers = u.SelectNameLoginPasswordForStatus(NameSelected, StatusSelected);

            String myLogin = (dataTableListUsers.Rows[0]["Login"].ToString().Trim());
            String myNewLogin = (this.txtLoginUpdate.Text.Trim());
            if ((myLogin.ToUpper()) == (myNewLogin.ToUpper()))
            {
                this.updateLoginStatus = true;
                this.mttHintLoginUpdate.RemoveAll();
                this.imgStatusLoginUpdate.Cursor = Cursors.Default;
                this.imgStatusLoginUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
            }
            else
            {
                u.login = (this.txtLoginUpdate.Text.Trim());
                string msgResult = u.CheckUserLoginInsertExist();

                if (String.IsNullOrEmpty(this.txtLoginUpdate.Text.Trim()))
                {
                    this.mttHintLoginUpdate.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                    this.mttHintLoginUpdate.Style = (this.Style);
                    this.mttHintLoginUpdate.Show("Login inválido", this.imgStatusLoginUpdate, 2000);
                    this.mttHintLoginUpdate.SetToolTip(this.imgStatusLoginUpdate, "Login inválido");

                    this.imgStatusLoginUpdate.Cursor = Cursors.Hand;
                    this.imgStatusLoginUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
                }
                else if (msgResult == (Boolean.FalseString))
                {
                    this.mttHintLoginUpdate.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                    this.mttHintLoginUpdate.Style = (this.Style);
                    this.mttHintLoginUpdate.Show("Login já existe", this.imgStatusLoginUpdate, 2000);
                    this.mttHintLoginUpdate.SetToolTip(this.imgStatusLoginUpdate, "Login já existe");

                    this.imgStatusLoginUpdate.Cursor = Cursors.Hand;
                    this.imgStatusLoginUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
                }
                else if (msgResult == (Boolean.TrueString))
                {
                    this.updateLoginStatus = true;
                    this.mttHintLoginUpdate.RemoveAll();
                    this.imgStatusLoginUpdate.Cursor = Cursors.Default;
                    this.imgStatusLoginUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
                };
            };
        }

        private void txtLoginUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }

        private void txtLoginUpdate_Leave(object sender, EventArgs e)
        {
            this.txtLoginUpdateLeave();
        }

        #endregion

        #region ---> (txtPasswordAUpdate)
        private void txtPasswordAUpdateLeave()
        {
            if ((String.IsNullOrEmpty(this.txtPasswordAUpdate.Text.Trim())) || ((this.txtPasswordAUpdate.Text) == (String)txtPasswordBUpdate.Text))
            {
                this.mttHintPasswordUpdate.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                this.mttHintPasswordUpdate.Style = (this.Style);
                this.mttHintPasswordUpdate.Show("Senha inválida", this.imgStatusPasswordUpdate, 2000);
                this.mttHintPasswordUpdate.SetToolTip(this.imgStatusPasswordUpdate, "Senha inválida");
                this.imgStatusPasswordUpdate.Cursor = Cursors.Hand;
                this.imgStatusPasswordUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else
            {
                this.mttHintPasswordUpdate.RemoveAll();
                this.imgStatusPasswordUpdate.Cursor = Cursors.Default;
                this.imgStatusPasswordUpdate.Image = null;
            };
        }

        private void txtPasswordBUpdateLeave()
        {
            updatePasswordStatus = (false);
            if (String.IsNullOrEmpty(this.txtPasswordBUpdate.Text.Trim()))
            {
                this.mttHintPasswordUpdate.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                this.mttHintPasswordUpdate.Style = (this.Style);
                this.mttHintPasswordUpdate.Show("Senha inválida", this.imgStatusPasswordUpdate, 2000);
                this.mttHintPasswordUpdate.SetToolTip(this.imgStatusPasswordUpdate, "Senha inválida");
                this.imgStatusPasswordUpdate.Cursor = Cursors.Hand;
                this.imgStatusPasswordUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else if ((this.txtPasswordAUpdate.Text.Trim()) != (this.txtPasswordBUpdate.Text.Trim()))
            {
                this.mttHintPasswordUpdate.Theme = this.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                this.mttHintPasswordUpdate.Style = (this.Style);
                this.mttHintPasswordUpdate.Show("Senha não Combina", this.imgStatusPasswordUpdate, 2000);
                this.mttHintPasswordUpdate.SetToolTip(this.imgStatusPasswordUpdate, "Senha não Combina");
                this.imgStatusPasswordUpdate.Cursor = Cursors.Hand;
                this.imgStatusPasswordUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
            }
            else
            {
                this.updatePasswordStatus = (true);
                this.mttHintPasswordUpdate.RemoveAll();
                this.imgStatusPasswordUpdate.Cursor = Cursors.Default;
                this.imgStatusPasswordUpdate.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
            };
        }

        private void txtPasswordAUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }

        private void txtPasswordAUpdate_Leave(object sender, EventArgs e)
        {
            this.txtPasswordAUpdateLeave();
        }

        private void txtPasswordBUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }

        private void txtPasswordBUpdate_Leave(object sender, EventArgs e)
        {
            this.txtPasswordBUpdateLeave();
        }

        #endregion

        #endregion

        #region ---> (Delete Users)

        private void ShowDataGrid‎Delete()
        {
            metroGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metroGrid2.RowHeadersWidth = (10);
            metroGrid2.ScrollBars = ScrollBars.None;

            metroGrid2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            metroGrid2.ColumnHeadersDefaultCellStyle.Font = mtpInsert.Font;

            metroGrid2.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            metroGrid2.DefaultCellStyle.SelectionForeColor = Color.Black;

            metroGrid2.DefaultCellStyle.BackColor = Color.White;
            metroGrid2.DefaultCellStyle.ForeColor = Color.Black;

            ClsUsers u = new ClsUsers();

            ClsUsers.StatusUser StatusSelected = ClsUsers.StatusUser.Enabled;
            DataTable dataTableListUsers = u.SelectNameForStatus(StatusSelected);

            metroGrid2.DataSource = dataTableListUsers;
            metroGrid2.ClearSelection();
            metroGrid2.Refresh();
        }

        private void DeleteUsers()
        {
            if ((btnDeleteUsers.Tag.ToString().Trim()) == (btnDeleteUsers.Text.Trim()))
            {
                //Listar
                this.btnDeleteUsers.Text = ("Deletar");
                this.ShowDataGrid‎Delete();

                String CountRows = (metroGrid2.RowCount.ToString());

                if (metroGrid2.RowCount == (0))
                {
                    this.lblCoutDelete.Text = String.Format(("{0}"), ("Nenhum Registro Encontrado"));
                    this.btnDeleteUsers.Enabled = (false);
                }
                else if (metroGrid2.RowCount == (1))
                {
                    this.lblCoutDelete.Text = String.Format(("{0} {1}"), (CountRows), ("Registro Encontrado"));
                }
                else if (metroGrid2.RowCount >= (2))
                {
                    this.lblCoutDelete.Text = String.Format(("{0} {1}"), (CountRows), ("Registros Encontrados"));
                };
            }
            else
            {
                //Delete]
                bool flag = metroGrid2.CurrentRow.Selected;

                if (flag)
                {
                    //Select User 
                    int rowIndexSelected = metroGrid2.CurrentCell.RowIndex;
                    int columIndexSelected = metroGrid2.CurrentCell.ColumnIndex;
                    String nameSelectedOnGrid = (String)(metroGrid2.Rows[(rowIndexSelected)].Cells[columIndexSelected].Value);

                    //mbox
                    String msg_Title = (nameSelectedOnGrid);
                    String msg_Text = ("\r\rDeletar Registro Selecionado?");
                    MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                    MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                    DialogResult diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);

                    if (diagResult == DialogResult.Yes)
                    {
                        ClsUsers u = new ClsUsers();

                        ClsUsers.StatusUser StatusSelected = ClsUsers.StatusUser.Disabled;

                        string msgResult = u.UpdateStatusForName(nameSelectedOnGrid, StatusSelected);

                        if (msgResult == Boolean.FalseString)
                        {
                            MessageBox.Show("Erro ao Deletar Usuario");
                        }
                        else if (msgResult == Boolean.TrueString)
                        {
                            this.btnDeleteUsers.Text = ((String)btnDeleteUsers.Tag);
                            this.btnDeleteUsers.PerformClick();
                            msg_Title = String.Format("{0}{1}", (nameSelectedOnGrid), " :(");
                            msg_Text = String.Format("{0}{1}", "\r\r", "Deletado com Sucesso");
                            msg_Buttons = MessageBoxButtons.OK;
                            msg_Icon = MessageBoxIcon.None;
                            msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                            diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
                        };
                    };
                }
                else
                {
                    MessageBox.Show("Selecione um Registo");
                };
            };
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            this.DeleteUsers();
        }

        private void btnCloseDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ---> (Restore Users)

        private void ShowDataGrid‎Restore()
        {
            metroGrid3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metroGrid3.RowHeadersWidth = (10);
            metroGrid3.ScrollBars = ScrollBars.None;

            metroGrid3.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            metroGrid3.ColumnHeadersDefaultCellStyle.Font = mtpInsert.Font;

            metroGrid3.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            metroGrid3.DefaultCellStyle.SelectionForeColor = Color.Black;

            metroGrid3.DefaultCellStyle.BackColor = Color.White;
            metroGrid3.DefaultCellStyle.ForeColor = Color.Black;

            ClsUsers u = new ClsUsers();

            ClsUsers.StatusUser StatusSelected = ClsUsers.StatusUser.Disabled;
            DataTable dataTableListUsers = u.SelectNameForStatus(StatusSelected);

            metroGrid3.DataSource = dataTableListUsers;
            metroGrid3.ClearSelection();
            metroGrid3.Refresh();
        }

        private void RestoreUsers()
        {
            if ((btnRestoreUsers.Tag.ToString().Trim()) == (btnRestoreUsers.Text.Trim()))
            {
                //Listar
                this.btnRestoreUsers.Text = ("Restore");

                this.ShowDataGrid‎Restore();

                String CountRows = (metroGrid3.RowCount.ToString());

                if (metroGrid3.RowCount == (0))
                {
                    this.lblCoutRestore.Text = String.Format(("{0}"), ("Nenhum Registro Encontrado"));
                    this.btnRestoreUsers.Enabled = (false);
                }
                else if (metroGrid3.RowCount == (1))
                {
                    this.lblCoutRestore.Text = String.Format(("{0} {1}"), (CountRows), ("Registro Encontrado"));
                }
                else if (metroGrid3.RowCount >= (2))
                {
                    this.lblCoutRestore.Text = String.Format(("{0} {1}"), (CountRows), ("Registros Encontrados"));
                };
            }
            else
            {
                //Restore
                bool flag = metroGrid3.CurrentRow.Selected;

                if (flag)
                {
                    //Select User 
                    int rowIndexSelected = metroGrid3.CurrentCell.RowIndex;
                    int columIndexSelected = metroGrid3.CurrentCell.ColumnIndex;
                    String nameSelectedOnGrid = (String)(metroGrid3.Rows[(rowIndexSelected)].Cells[columIndexSelected].Value);

                    //mbox
                    String msg_Title = (nameSelectedOnGrid);
                    String msg_Text = ("\r\rRestaurar Registro Selecionado?");
                    MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                    MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                    DialogResult diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);

                    if (diagResult == DialogResult.Yes)
                    {
                        ClsUsers u = new ClsUsers();

                        ClsUsers.StatusUser StatusSelected = ClsUsers.StatusUser.Enabled;

                        string msgResult = u.UpdateStatusForName(nameSelectedOnGrid, StatusSelected);

                        if (msgResult == Boolean.FalseString)
                        {
                            MessageBox.Show("Erro ao Restaurar Usuario");
                        }
                        else if (msgResult == Boolean.TrueString)
                        {
                            this.btnRestoreUsers.Text = ((String)btnDeleteUsers.Tag);
                            this.btnRestoreUsers.PerformClick();
                            msg_Title = String.Format("{0}{1}", (nameSelectedOnGrid), " :)");
                            msg_Text = String.Format("{0}{1}", "\r\r", "Restaurado com Sucesso");
                            msg_Buttons = MessageBoxButtons.OK;
                            msg_Icon = MessageBoxIcon.None;
                            msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                            diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
                        };
                    };
                }
                else
                {
                    MessageBox.Show("Selecione um Registo");
                };
            };
        }

        private void btnRestoreUsers_Click(object sender, EventArgs e)
        {
            this.RestoreUsers();
        }

        private void btnCloseRestore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}