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
            DeleteUsers = 2
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
                            this.Size = new Size(423, 372);
                            this.mtpInsert.Text = String.Format("{0}{1}{1}{1}{1}{1}", "Novo Usuario", "                  ");
                            this.mtcUsers.TabPages.Add(mtpInsert);
                            this.btnCloseInsert.Text = ("Sair");
                            this.btnSaveInsert.Text = ("Salvar");
                            this.metroTile_UserInsert.Text = ("");
                            this.txtNameInsert.Text = ("");
                            this.txtLoginInsert.Text = ("");
                            this.txtPasswordInsert.Text = ("");
                        };
                        break;
                    };
                case ChoseActionForm.UpdateUsers:
                    {
                        if (!this.mtcUsers.TabPages.Contains(mtpUpdate))
                        {
                            this.mtpUpdate.Text = String.Format("{0}{1}{1}{1}{1}{1}", "Alterar Usuario", "                  ");
                            this.mtcUsers.TabPages.Add(mtpUpdate);
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
                default:
                    {
                        break;
                    };
            };
            this.mtcUsers.ResumeLayout();
        }
        private void InsertUser()
        {
            clsUsers u = new clsUsers();
            u.nome = (txtNameInsert.Text);
            u.login = (txtLoginInsert.Text);
            u.password = (txtPasswordInsert.Text);
            u.status = (Convert.ToString(clsUsers.StatusUser.Enabled));
            string msgResult = u.InsertUsersCommand();
            if (Boolean.FalseString == msgResult)
            {
                MessageBox.Show("Erro ao Cadastrar novo Usuario");
            }
            else
            {
                String msg_Title = String.Format("{0}{1}", "Usuario", "       :)");
                String msg_Text = String.Format("{0}{1}", "\r\r", "Cadastrado com Sucesso");
                MessageBoxButtons msg_Buttons = MessageBoxButtons.OK;
                MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                DialogResult diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.InsertUser();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}