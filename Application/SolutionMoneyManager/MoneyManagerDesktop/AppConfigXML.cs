namespace MoneyManagerDesktop
{
    #region ---> ( Using )
    using MoneyManagerDesktop.Properties;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using System.Xml;
    #endregion

    class AppConfigXML
    {
        public AppConfigXML()
        {
        }

        #region ---> ( Set AppConfig )
        /// <summary>
        /// #Save String for stringSQLModel
        /// </summary>
        public void SetAppConfigFileConnectionsString(string key, string value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region ---> ( Get AppConfig )
        /// <summary>
        /// #Read  String for stringSQLModel
        /// #Read On "C:\Users\%UserName%\AppData\Local\"
        /// </summary>
        public string GetAppConfigFileConnectionsString(string key)
        {
            String returnResult = "";
            returnResult = (Properties.Settings.Default[key].ToString());
            return returnResult;
        }
        #endregion
    }
}