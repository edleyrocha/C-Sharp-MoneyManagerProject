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
//-------------------------------------------//
///////////////////////////////////////////////
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
            this.BackImage = (MoneyManagerDesktop.Forms.MainBase.ResMainBase.CoinsMoney128);
            // mnu
            this.mnuEntries.Text = ("&Cadastros");

            this.mnuUsers.Text = (String.Format(("{0}"),("Usuarios")));
            this.mnuUsers.Image = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersAll32);

            this.mnuUsersSelect.Text = (String.Format("{0} {1}", ("Listar"), (this.mnuUsers.Text)));
            this.mnuUsersSelect.Image = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersFind32);

            this.mnuUsersInsert.Text = (String.Format("{0} {1}", ("Adicionar"), (this.mnuUsers.Text)));
            this.mnuUsersInsert.Image = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersNew32);

            this.mnuUsersUpdate.Text = (String.Format("{0} {1}", ("Atualizar"), (this.mnuUsers.Text)));
            this.mnuUsersUpdate.Image = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersUpdate32);

            this.mnuUsersDelete.Text = (String.Format("{0} {1}", ("Deletar"), (this.mnuUsers.Text)));
            this.mnuUsersDelete.Image = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersDelete32);

            this.mnuUsersRestore.Text = (String.Format("{0} {1}", ("Restaurar"), (this.mnuUsers.Text)));
            this.mnuUsersRestore.Image = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersRecover32);

            this.mnuCategories.Text = (String.Format(("{0}"), ("Ca&tegorias"))); 
            this.mnuCategories.Image = (MoneyManagerDesktop.Forms.Categories.ResCategories.category32);

            this.mnuCategoriesSelect.Text = (String.Format("{0} {1}", ("Listar"), (this.mnuCategories.Text)));
            this.mnuCategoriesSelect.Image = (MoneyManagerDesktop.Forms.Categories.ResCategories.categoryFind32);

            this.mnuCategoriesInsert.Text = (String.Format("{0} {1}", ("Adicionar"), (this.mnuCategories.Text)));
            this.mnuCategoriesInsert.Image = (MoneyManagerDesktop.Forms.Categories.ResCategories.categoryAdd32);

            this.mnuCategoriesUpdate.Text = (String.Format("{0} {1}", ("Atualizar"), (this.mnuCategories.Text)));
            this.mnuCategoriesUpdate.Image = (MoneyManagerDesktop.Forms.Categories.ResCategories.categoryUpdate32);

            this.mnuCategoriesDelete.Text = (String.Format("{0} {1}", ("Deletar"), (this.mnuCategories.Text)));
            this.mnuCategoriesDelete.Image = (MoneyManagerDesktop.Forms.Categories.ResCategories.categoryDelete32);

            this.mnuCategoriesRestore.Text = (String.Format("{0} {1}", ("Restaurar"), (this.mnuCategories.Text)));
            this.mnuCategoriesRestore.Image = (MoneyManagerDesktop.Forms.Categories.ResCategories.categoryRestore32);

            this.mnuClose.Text = ("&Sair");
            this.mnuClose.Image = (MoneyManagerDesktop.Forms.MainBase.ResMainBase.ExitClose32);

            this.mnuConfig.Text = ("&Configurações");
            this.mnuColors.Text = ("&Cores");
            this.mnuColors.Image = (MoneyManagerDesktop.Forms.Color.ResColor.ColorsSwatch32);

            this.mnuDataBase.Text = ("&Banco De Dados");
            this.mnuDataBase.Image = (MoneyManagerDesktop.Forms.Connection.ResConnection.DataBaseAdd32);

            this.btnHelp.Text = ("&Ajuda");
            this.mnuAbout.Text = ("&Sobre");
            this.mnuAbout.Image = (MoneyManagerDesktop.Forms.About.ResAbout.HelpAbout32);
        }
        private void mnuUsersSelect_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersSelect = (new FrmUsers((ChoseActionForm)(0))); //Select Users
            objFrmUsersSelect.ShowDialog();
        }
        private void mnuUsersInsert_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersInsert = (new FrmUsers((ChoseActionForm)(1))); //Insert Users
            objFrmUsersInsert.ShowDialog();
        }
        private void mnuUsersUpdate_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersUpdate = (new FrmUsers((ChoseActionForm)(2))); //Update Users
            objFrmUsersUpdate.ShowDialog();
        }
        private void mnuUsersDelete_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersDelete = (new FrmUsers((ChoseActionForm)(3))); //Delete Users (Only Disabled)
            objFrmUsersDelete.ShowDialog();
        }
        private void mnuUsersRetore_Click(object sender, EventArgs e)
        {
            FrmUsers objFrmUsersRestore = (new FrmUsers((ChoseActionForm)(4)));  //Restore Users (Only Enabled)
            objFrmUsersRestore.ShowDialog();
        }
        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuColors_Click(object sender, EventArgs e)
        {
            FrmColor objfrmColor = (new FrmColor());
            objfrmColor.ShowDialog();
        }
        private void mnuDataBase_Click(object sender, EventArgs e)
        {
            FrmConnection objfrmConnection = (new FrmConnection());
            objfrmConnection.ShowDialog();
        }
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            FrmAbout objFrmAbout = (new FrmAbout());
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