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
    public partial class frmMainBase : MetroForm
    {
        public frmMainBase()
        {
            InitializeComponent();
            SetConfigStartMainBase();
        }
        Boolean CancelClose = true;

        public void SetConfigStartMainBase()
        {
            this.Text = ("Money Manager");

            //mnu
            this.mnuConfig.Text = ("&Configurações");
            this.mnuColors.Text = ("&Cores");
            this.mnuDataBase.Text = ("&Banco De Dados");
            this.btnHelp.Text = ("&Ajuda");
            this.mnuAbout.Text = ("&Sobre");

            this.WindowState = FormWindowState.Maximized;

            ptbMoney.Image = MoneyManagerDesktop.Forms.MainBase.resMainBase.coins48;
            mnuSair.Image = MoneyManagerDesktop.Forms.MainBase.resMainBase.exit16;

            frmLogin f = new frmLogin();
            f.ShowDialog();

        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuColors_Click(object sender, EventArgs e)
        {
            frmColor fcolor = new frmColor();
            fcolor.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

        private void frmMainBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelClosing();
            e.Cancel = CancelClose;
        }
        private void CancelClosing()
        {
            String msg_Title = (this.Text);
            String msg_Text = ("\r\r\r\rDeseja Realmente Sair?");
            MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon msg_Icon = MessageBoxIcon.None;
            MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
            DialogResult msgResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
            if (msgResult == DialogResult.Yes)
            {
                CancelClose = (false);
            };
        }

        private void mnuDataBase_Click(object sender, EventArgs e)
        {
            frmConnection f = new frmConnection();
            f.ShowDialog();
        }
    }
}