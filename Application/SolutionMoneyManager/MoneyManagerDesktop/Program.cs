﻿///////////////////////////////////////////////
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
            // FrmLogin
            FrmLogin objFrmLogin = (new FrmLogin());
            objFrmLogin.ShowDialog();
            // FrmMainBase
            if ((objFrmLogin.myLoginStatus) == (Chose.AcessLoginStatus.AllowedAccess))
            {
                Application.Run(new FrmMainBase(objFrmLogin.myLoginID, objFrmLogin.myLoginName));
                objFrmLogin.Dispose();
            };
        }
    }
}