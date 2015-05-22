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
    public partial class frmMainMaster : MetroForm
    {
        public frmMainMaster()
        {
            InitializeComponent();
            SetConfigStartMainBase();
        }
        Boolean CancelClose = true;

        public void SetConfigStartMainBase()
        {
            //frm
            this.Text = ("Money Manager");
            this.WindowState = FormWindowState.Maximized;
            this.ptbMoney.Image = MoneyManagerDesktop.Forms.MainBase.resMainBase.coins48;
            //mnu
            this.mnuEntries.Text = ("&Cadastros");

            this.mnuUsers.Text = ("Usuario");
            this.mnuUsersInsert.Text = ("Novo");
            this.mnuUsersUpdate.Text = ("Atualizar");
            this.mnuUsersDelete.Text = ("Deletar");

            this.mnuClose.Text = ("&Sair");
            this.mnuClose.Image = MoneyManagerDesktop.Forms.MainBase.resMainBase.exit16;

            this.mnuConfig.Text = ("&Configurações");
            this.mnuColors.Text = ("&Cores");
            this.mnuDataBase.Text = ("&Banco De Dados");
            this.btnHelp.Text = ("&Ajuda");
            this.mnuAbout.Text = ("&Sobre");

        }

        private void mnuUsersInsert_Click(object sender, EventArgs e)
        {
            frmUsers fUser = new frmUsers((frmUsers.ChoseActionForm)(0)); //InsertUsers
            fUser.ShowDialog();
        }
        private void mnuUsersUpdate_Click(object sender, EventArgs e)
        {
            frmUsers fUser = new frmUsers((frmUsers.ChoseActionForm)(1)); //UpdateUsers
            fUser.ShowDialog();
        }
        private void mnuUsersDelete_Click(object sender, EventArgs e)
        {
            frmUsers fUser = new frmUsers((frmUsers.ChoseActionForm)(2)); //DeleteUsers
            fUser.ShowDialog();
        }
        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuColors_Click(object sender, EventArgs e)
        {
            frmColor fcolor = new frmColor();
            fcolor.ShowDialog();
        }
        private void mnuDataBase_Click(object sender, EventArgs e)
        {
            frmConnection f = new frmConnection();
            f.ShowDialog();
        }
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.ShowDialog();
        }
        private void CancelClosing()
        {
            String msg_Title = (this.Text + "   :)");
            String msg_Text = ("\r\rDeseja Realmente (Sair)?");
            MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon msg_Icon = MessageBoxIcon.None;
            MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
            DialogResult diagResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
            if (diagResult == DialogResult.Yes)
            {
                CancelClose = (false);
            };
        }
        private void frmMainBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelClosing();
            e.Cancel = CancelClose;
        }
    }
}