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
    using System.Linq;
    using System.Windows.Forms;
    #endregion
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // my Login
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();

            // MyForm
            if( (fLogin.myLoginStatus) == (frmLogin.AcessLoginStatus.AllowedAccess))
            {
                Application.Run(new frmMainMaster());
            }
        
           
        }
    }
}