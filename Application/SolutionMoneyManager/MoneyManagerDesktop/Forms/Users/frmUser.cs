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
            SelectedAction = choseAction;
            SetConfigStartUser();
        }
        public void SetConfigStartUser()
        {
            // Hide Tabs
            mtcUsers.SuspendLayout();
            mtcUsers.TabPages.Clear();

            switch (SelectedAction)
            {
                case ChoseActionForm.InsertUsers:
                    {
                        if (!mtcUsers.TabPages.Contains(mtpInsert))
                        {
                            this.Text = ("Cadastro");
                            this.mtpInsert.Text = String.Format("{0}{1}{1}{1}{1}{1}", "Usuario", "                  ");
                            this.mtcUsers.TabPages.Add(mtpInsert);
                            this.btnCloseNew.Text = ("Sair");
                            this.btnSaveNew.Text = ("Salvar");
                        };
                        break;
                    };
                case ChoseActionForm.UpdateUsers:
                    {
                        if (!mtcUsers.TabPages.Contains(mtpUpdate))
                        {
                            mtcUsers.TabPages.Add(mtpUpdate);
                        };
                        break;
                    };
                case ChoseActionForm.DeleteUsers:
                    {
                        if (!mtcUsers.TabPages.Contains(mtpDelete))
                        {
                            mtcUsers.TabPages.Add(mtpDelete);
                        };
                        break;
                    };
                default:
                    {
                        break;
                    };
            };
           mtcUsers.ResumeLayout();
        }

        private void InsertUser()
        {
            clsUsers u = new clsUsers();

            u.nome = (txtName.Text);
            u.login = (txtLogin.Text);
            u.password = (txtPassword.Text);
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
            InsertUser();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
