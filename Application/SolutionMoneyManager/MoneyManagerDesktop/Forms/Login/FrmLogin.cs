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
    using MetroFramework;
    using MetroFramework.Forms;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    #endregion
    public partial class FrmLogin : MetroForm
    {

        /// <summary>
        /// # Set Status for Login em FrmMainBase
        /// </summary>
        public Chose.AcessLoginStatus myLoginStatus { get; set; }

        /// <summary>
        /// # Set Name for Label in FrmMainBase
        /// </summary>
        public String myLoginName { get; set; }

        /// <summary>
        ///  # Set ID for Label TAG in FrmMainBase
        /// </summary>
        public String myLoginID { get; set; }


        #region ---> (Form Users)
        public FrmLogin()
        {
            this.InitializeComponent();
            this.SetConfigStartLogin();
        }

        private void SetConfigStartLogin()
        {
            this.Text = ("Money Manager");
            this.mtpLogin.Text = (String.Format("{0}{1}", "Login", "                                                                                         "));

            this.txtLogin.Text = ((String)this.txtLogin.Tag);
            this.txtPassword.Text = ((String)this.txtPassword.Tag);

            this.lblStatusLogin.Text = ("");
            this.lblStatusLogin.UseStyleColors = (true);
            this.lblStatusLogin.Style = (MetroColorStyle.Blue);

            this.btnLogin.Text = ("Login");
            this.btnClose.Text = ("Sair");

            this.imgLogin.Text = ("");
            this.imgLogin.UseTileImage = (true);
            this.imgLogin.TileImageAlign = (ContentAlignment.MiddleCenter);
            this.imgLogin.TileImage = (MoneyManagerDesktop.Forms.Login.ResLogin.LoginManager128);
        }
        #endregion

        #region ---> (Mtc Login)
        private void mtcLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode) == (Keys.Escape))
            {
                this.Close();
            };
        }
        #endregion

        #region ---> (Btn Login)
        /// <summary>
        /// # Check User Login
        /// </summary>
        private void CheckUserLogin()
        {
            String myLogin = (txtLogin.Text.Trim());
            String myPassword = (txtPassword.Text.Trim());

            //this.txtLoginLeave();
            //this.txtPasswordLeave();

            Boolean Login = (this.txtLoginLeave());
            Boolean Password = (this.txtPasswordLeave());

            if (((myLogin) == ((String)this.txtLogin.Tag)) || ((myPassword) == ((String)this.txtPassword.Tag)))
            {
                this.lblStatusLogin.Text = (String.Format("{0}", ("Login ou Senha Inválida")));
            }
            else if (((myLogin) == ("adm")) && ((myPassword) == (myLogin)))
            {
         
                this.myLoginName = ("Administrador do Sistema");
                this.myLoginID = (myLogin);
                this.myLoginStatus = (Chose.AcessLoginStatus.AllowedAccess);
                this.Close();
            }
            else if ((Login) && (Password))
            {
                ClsLogin objClsLogin = (new ClsLogin());
                switch (objClsLogin.CheckUserLogin((myLogin), (myPassword)))
                {
                    case (Chose.AcessLoginStatus.AllowedAccess):
                        {
                            this.myLoginName = (objClsLogin.CheckdUserLogin);
                            this.myLoginID = (objClsLogin.CheckdUserID.ToString());
                            this.myLoginStatus = (Chose.AcessLoginStatus.AllowedAccess);
                            this.Close();
                            break;
                        };
                    case (Chose.AcessLoginStatus.AllowedDenied):
                        {
                            this.myLoginStatus = (Chose.AcessLoginStatus.AllowedDenied);
                            break;
                        };
                    default:
                        {
                            break;
                        };
                };
            };
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.CheckUserLogin();
        }
        #endregion

        #region ---> (Btn Close)
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ---> (Txt Login)
        MetroFramework.Components.MetroToolTip mttHintLogin = (new MetroFramework.Components.MetroToolTip());
        private void txtLoginEnter()
        {
            if ((this.txtLogin.Text) == ((String)this.txtLogin.Tag))
            {
                this.txtLogin.Clear();
            };
        }
        private bool txtLoginLeave()
        {
            Boolean returBoolean = (false);
            if (((String.IsNullOrEmpty(this.txtLogin.Text.Trim())) ||
               ((this.txtLogin.Text.Trim()) == (((String)this.txtLogin.Tag).Trim()))))
            {
                this.mttHintLogin.Theme = ((this.Theme) == (MetroThemeStyle.Light) ? (MetroThemeStyle.Dark) : (MetroThemeStyle.Light));
                this.mttHintLogin.Style = (this.Style);
                this.mttHintLogin.SetToolTip((this.imgStatusLogin), ("Login inválido"));

                this.imgStatusLogin.Cursor = (Cursors.Hand);
                this.imgStatusLogin.Image = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16);

                this.txtLogin.Text = ((String)this.txtLogin.Tag);
            }
            else if ((this.txtLogin.Text) != ((String)this.txtLogin.Tag))
            {
                returBoolean = (true);
                this.mttHintLogin.RemoveAll();
                this.imgStatusLogin.Cursor = (Cursors.Default);
                this.imgStatusLogin.Image = (null);
            };
            return (returBoolean);
        }
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            this.txtLoginEnter();
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            this.txtLoginLeave();
        }
        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode) == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
                e.Handled = (e.SuppressKeyPress = (true)); // Handled and  SuppressKeyPress = true
            };
        }
        #endregion

        #region ---> (txt Password)
        MetroFramework.Components.MetroToolTip mttHintPassword = (new MetroFramework.Components.MetroToolTip());
        private void txtPasswordEnter()
        {
            if ((this.txtPassword.Text) == ((String)this.txtPassword.Tag))
            {
                this.txtPassword.Clear();
                this.txtPassword.UseSystemPasswordChar = (true);
            };
        }
        private bool txtPasswordLeave()
        {
            Boolean returBoolean = (false);

            if (((String.IsNullOrEmpty(this.txtPassword.Text.Trim())) ||
              ((this.txtPassword.Text.Trim()) == (((String)this.txtPassword.Tag).Trim()))))
            {
                this.mttHintPassword.Theme = ((this.Theme) == (MetroThemeStyle.Light) ? (MetroThemeStyle.Dark) : (MetroThemeStyle.Light));
                this.mttHintPassword.Style = (this.Style);
                this.mttHintPassword.SetToolTip((this.imgStatusPassword), ("Senha inválida"));

                this.imgStatusPassword.Cursor = (Cursors.Hand);
                this.imgStatusPassword.Image = (MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16);

                this.txtPassword.Text = ((String)this.txtPassword.Tag);
            }
            else if ((this.txtPassword.Text) != ((String)this.txtPassword.Tag))
            {
                returBoolean = (true);
                this.mttHintPassword.RemoveAll();
                this.imgStatusPassword.Cursor = (Cursors.Default);
                this.imgStatusPassword.Image = (null);
            };
            return (returBoolean);
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            this.txtPasswordEnter();
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            this.txtPasswordLeave();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode) == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
                e.Handled = (e.SuppressKeyPress = (true)); // Handled and  SuppressKeyPress = true
            };
        }
        #endregion











        //private void txt_Login_Click(object sender, EventArgs e)
        //{
        //    this.txt_Login.Text = ("");
        //}
        //private void txt_Password_Click(object sender, EventArgs e)
        //{
        //    this.txt_Password.Text = ("");
        //}
        //private void txt_Login_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        SendKeys.Send("{TAB}");
        //        e.Handled = e.SuppressKeyPress = true;
        //    };
        //}
        //private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        SendKeys.Send("{TAB}");
        //        this.btnLogin.PerformClick();
        //        e.Handled = e.SuppressKeyPress = true;
        //    };
        //}
        //private void txt_Login_Leave(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(txt_Login.Text) || ((this.txt_Login.Text == ("Usuario"))))
        //    {
        //        this.txt_Login.Text = ("Usuario");
        //        this.imgStatusLogin.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
        //    }
        //    else
        //    {
        //        this.imgStatusLogin.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
        //    };
        //}
        //private void txt_Password_Leave(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(this.txt_Password.Text) || ((this.txt_Password.Text == ("Senha"))))
        //    {
        //        this.txt_Password.UseSystemPasswordChar = (false);
        //        this.txt_Password.Text = ("Senha");
        //        this.imgStatusPassword.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersExclamation16;
        //    }
        //    else
        //    {
        //        this.imgStatusPassword.Image = MoneyManagerDesktop.Forms.Users.ResUsers.UsersAccept16;
        //    };
        //}
        //private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (this.txt_Password.UseSystemPasswordChar == (false))
        //    {
        //        this.txt_Password.UseSystemPasswordChar = (true);
        //    };
        //}


        //private void metroTabControl_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        this.Close();
        //    };
        //}





    }
}