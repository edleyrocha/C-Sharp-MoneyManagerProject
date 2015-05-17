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
    using System.Resources;
    using System.Reflection;
    #endregion
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            SetConfigStartLogin();
        }
        public void SetConfigStartLogin()
        {
            this.Text = ("Money Manager");
            mtpLogin.Text = ("Login");
            txt_Login.Text = ("Usuario");
            txt_Password.Text = ("Senha");
            metroTile_Foto.Text = ("");
            
            this.Refresh();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmColors f = new frmColors();
            f.ShowDialog();
        }
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            MetroFramework.Components.MetroStyleManager metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            metroStyleManager.Owner = (this);
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
            
            this.Theme = this.Theme == MetroFramework.MetroThemeStyle.Light ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;
            metroProgressSpinner.Theme = this.Theme;
            metroTabControl.Theme = this.Theme;
            mtpLogin.Theme = this.Theme;
            txt_Login.Theme = this.Theme;
            txt_Password.Theme = this.Theme;
            btnLogin.Theme = this.Theme;

            this.Refresh();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            MetroFramework.Components.MetroStyleManager metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            metroStyleManager.Owner = (this);
            metroStyleManager.Style = (MetroColorStyle)next;
            this.Style = (MetroColorStyle)next;
            this.Refresh();
            txt_Login.Focus();
        }
        private void metroTextBox_Clean(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox mtb = sender as MetroFramework.Controls.MetroTextBox;
            switch (((string)mtb.Tag))
            {
                case "1": // txt_Login 1
                    {
                        txt_Login.Text = ("");
                        break;
                    };
                case "2": // txt_Password 2
                    {
                        txt_Password.Text = ("");
                        break;
                    };
            };

        }
        private void metroTextBox_EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void metroTextBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar != (true))
            {
                txt_Password.UseSystemPasswordChar = (true);
            }
        }
    }
}