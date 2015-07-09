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

    #region ---> ( Using )
    using MoneyManagerDesktop.Properties;
    using System;
    #endregion

    class AppConfigXML
    {

        #region ---> ( Set AppConfig )
        /// <summary>
        /// # Edit AppConfigXML (string key, string value)
        /// # Edit On "C:\Users\%UserName%\AppData\Local\"
        /// </summary>
        public void SetAppConfigXML(string key, string value)
        {
            Settings.Default[key] = value;
            Settings.Default.Save();
        }
        #endregion

        #region ---> ( Get AppConfig )
        /// <summary>
        /// # Read String for stringSQLModel (string key)
        /// # Read On "C:\Users\%UserName%\AppData\Local\"
        /// </summary>
        public string GetAppConfigXML(string key)
        {
            string returnResult = (String.Empty);
            returnResult = (Properties.Settings.Default[key].ToString());
            return returnResult;
        }
        #endregion
    }
}