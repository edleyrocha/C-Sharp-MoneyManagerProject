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
    //using System.Resources;
    //using System.Reflection;
    #endregion
    public partial class frmLogin : MetroForm
    {
        public enum AcessLoginStatus
        {
            AllowedDenied = 1,
            AllowedAccess = 2

        }

        public AcessLoginStatus myLoginStatus { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            SetConfigStartLogin();
        }
        public void SetConfigStartLogin()
        {
            this.Text = ("Money Manager");
            this.mtpLogin.Text = String.Format("{0}{1}{1}{1}{1}", "Login", "                  ");
            this.txt_Login.Text = ("Usuario");
            this.txt_Password.Text = ("Senha");
            this.metroTile_Foto.Text = ("");
            this.btnLogin.Text = ("Login");
            this.Refresh();
        }
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            MetroFramework.Components.MetroStyleManager metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            metroStyleManager.Owner = (this);
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
            this.Theme = this.Theme == MetroFramework.MetroThemeStyle.Light ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;
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
        private void txt_Login_Click(object sender, EventArgs e)
        {
            txt_Login.Text = ("");
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.Text = ("");
        }
        private void txt_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
            };
        }
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
                btnLogin.PerformClick();
                e.Handled = e.SuppressKeyPress = true;
            };
        }
        private void txt_Login_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Login.Text) || ((txt_Login.Text == ("Usuario"))))
            {
                txt_Login.Text = ("Usuario");
                imgStatusLogin.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else
            {
                imgStatusLogin.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_accept16;
            };
        }
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Password.Text) || ((txt_Password.Text == ("Senha"))))
            {
                txt_Password.Text = ("Senha");
                imgStatusPassword.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_exclamation16;
            }
            else
            {
                imgStatusPassword.Image = MoneyManagerDesktop.Forms.Users.resUsers.User_accept16;
            };

        }
        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar == (false))
            {
                txt_Password.UseSystemPasswordChar = (true);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            myLoginStatus = AcessLoginStatus.AllowedAccess;
            this.Close();
            
        }
    }
}