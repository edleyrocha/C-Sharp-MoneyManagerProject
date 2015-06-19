///////////////////////////////////////////////
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
    public partial class FrmMainBase : MetroForm
    {
        public FrmMainBase()
        {
            InitializeComponent();
            SetConfigStartMainBase();
        }
        Boolean CancelClose = true;
        public void SetConfigStartMainBase()
        {
            //frm
            this.Text = ("Money Manager");
            this.WindowState = (FormWindowState.Maximized);
            //frm img top
            this.BackMaxSize = (50);
            this.BackImagePadding = new Padding(210, 10, 0, 0);
            this.BackImage = (MoneyManagerDesktop.Forms.MainBase.RessMainBase.CoinsMoney128);
            //mnu
            this.mnuEntries.Text = ("&Cadastros");

            this.mnuUsers.Text = ("Usuario");
            this.mnuUsers.Image = (MoneyManagerDesktop.Forms.Users.RessUsers.UsersAll32);
            this.mnuUsersSelect.Text = ("Listar");
            this.mnuUsersSelect.Image = (MoneyManagerDesktop.Forms.Users.RessUsers.UsersFind32);
            this.mnuUsersInsert.Text = ("Novo");
            this.mnuUsersInsert.Image = (MoneyManagerDesktop.Forms.Users.RessUsers.UsersNew32);
            this.mnuUsersUpdate.Text = ("Atualizar");
            this.mnuUsersUpdate.Image = (MoneyManagerDesktop.Forms.Users.RessUsers.UsersUpdate32);
            this.mnuUsersDelete.Text = ("Deletar");
            this.mnuUsersDelete.Image = (MoneyManagerDesktop.Forms.Users.RessUsers.UsersDelete32);
            this.mnuUsersRetore.Text = ("Restaurar");
            this.mnuUsersRetore.Image = (MoneyManagerDesktop.Forms.Users.RessUsers.UsersRecover32);

            this.mnuClose.Text = ("&Sair");
            this.mnuClose.Image = (MoneyManagerDesktop.Forms.MainBase.RessMainBase.ExitClose32);

            this.mnuConfig.Text = ("&Configurações");
            this.mnuColors.Text = ("&Cores");
            this.mnuColors.Image = (MoneyManagerDesktop.Forms.Color.RessColor.ColorsSwatch32);
            this.mnuDataBase.Text = ("&Banco De Dados");
            this.mnuDataBase.Image = (MoneyManagerDesktop.Forms.Connection.RessConnection.DataBaseAdd32);

            this.btnHelp.Text = ("&Ajuda");
            this.mnuAbout.Text = ("&Sobre");
            this.mnuAbout.Image = (MoneyManagerDesktop.Forms.About.RessAbout.HelpAbout32);
        }
        private void mnuUsersSelect_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersSelect = (new FrmUsers((FrmUsers.ChoseActionForm)(0))); //Select Users
            objFrmUsersSelect.ShowDialog();
        }
        private void mnuUsersInsert_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersInsert = (new FrmUsers((FrmUsers.ChoseActionForm)(1))); //Insert Users
            objFrmUsersInsert.ShowDialog();
        }
        private void mnuUsersUpdate_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersUpdate = (new FrmUsers((FrmUsers.ChoseActionForm)(2))); //Update Users
            objFrmUsersUpdate.ShowDialog();
        }
        private void mnuUsersDelete_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersDelete = (new FrmUsers((FrmUsers.ChoseActionForm)(3))); //Delete Users (Only Disabled)
            objFrmUsersDelete.ShowDialog();
        }
        private void mnuUsersRetore_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersRestore = (new FrmUsers((FrmUsers.ChoseActionForm)(4)));  //Restore Users (Only Enabled)
            objFrmUsersRestore.ShowDialog();
        }
        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuColors_Click(object sender, EventArgs e)
        {
            FrmmColor objfrmColor = (new FrmmColor());
            objfrmColor.ShowDialog();
        }
        private void mnuDataBase_Click(object sender, EventArgs e)
        {
            FrmmConnection objfrmConnection = (new FrmmConnection());
            objfrmConnection.ShowDialog();
        }
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            FrmmAbout objFrmAbout = (new FrmmAbout());
            objFrmAbout.ShowDialog();
        }
        private void CancelClosing()
        {
            String msg_Title = (this.Text + "   :)");
            String msg_Text = ("\r\rDeseja Realmente (Sair)?");
            MessageBoxButtons msg_Buttons = (MessageBoxButtons.YesNo);
            MessageBoxIcon msg_Icon = (MessageBoxIcon.None);
            MessageBoxDefaultButton msg_ButtonsDefault = (MessageBoxDefaultButton.Button1);
            DialogResult diagResult = (MetroMessageBox.Show((this), (msg_Text), (msg_Title), (msg_Buttons), (msg_Icon), (msg_ButtonsDefault)));
            if ((diagResult) == (DialogResult.Yes))
            {
                CancelClose = (false);
            };
        }
        private void frmMainBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelClosing();
            e.Cancel = (CancelClose);
        }
        private void frmMainMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode) == (Keys.Escape))
            {
                this.Close();
            };
        }
    }
}