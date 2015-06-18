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
    using MetroFramework;
    using Microsoft.Data.ConnectionUI;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    #endregion
    class clsConnection
    {
        #region ---> ( Get and Set StringSQLConnection)

        DataSource objDataSource = new DataSource("MicrosoftSqlServer", "Microsoft SQL Server");
        DataConnectionDialog objDataConnectionDialog = new DataConnectionDialog();
        AppConfigXML objAppConfigXML = new AppConfigXML();

        public enum ChoiceSQLConnectionString
        {
            GetDataSource = 0,
            GetDataProvider = 1,
            GetConnectionString = 2
        }
        private bool SaveSQLConnectionString()
        {
            bool returnTrueOrFalse = (false); // Return False for DataConnectionDialog
            if (DataConnectionDialog.Show(objDataConnectionDialog) == DialogResult.OK)
            {
                String msg_Title = String.Format("{0}", "Data Base Conexão");
                String msg_Text = String.Format("{0}{1}", "\r\r\t\t", "Deseja Salvar esta Conexão?");
                MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                DialogResult msgResult = MetroMessageBox.Show(Form.ActiveForm, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);

                if (msgResult == DialogResult.Yes)
                {
                    this.objAppConfigXML.SetAppConfigXML("SQLStringConnection", objDataConnectionDialog.ConnectionString);
                    returnTrueOrFalse = (true); // DataConnectionDialog and SQLStringConnection Is OK
                };
            };
            return returnTrueOrFalse;
        }
        public bool NewSQLConnectionString()
        {
            this.objDataSource.Providers.Add(DataProvider.SqlDataProvider);
            this.objDataConnectionDialog.DataSources.Add(objDataSource);
            this.objDataConnectionDialog.SelectedDataProvider = (DataProvider.SqlDataProvider);
            this.objDataConnectionDialog.SelectedDataSource = (objDataSource);

            bool returnTrueOrFalse = (false); // Default for DataConnectionDialog

            returnTrueOrFalse = (this.SaveSQLConnectionString());

            this.objDataConnectionDialog.Dispose();

            return returnTrueOrFalse;
        }
        public bool LoadSQLConnectionString(string connectionString)
        {
            this.objDataSource.Providers.Add(DataProvider.SqlDataProvider);
            this.objDataConnectionDialog.DataSources.Add(this.objDataSource);
            this.objDataConnectionDialog.ConnectionString = connectionString;

            bool returnTrueOrFalse = (false); // Return False for DataConnectionDialog

            returnTrueOrFalse = (this.SaveSQLConnectionString());

            this.objDataConnectionDialog.Dispose();

            return returnTrueOrFalse;
        }
        public string GetSQLConnectionString(ChoiceSQLConnectionString choiceSQLConnectionString)
        {
            objDataSource.Providers.Add(DataProvider.SqlDataProvider);
            objDataConnectionDialog.DataSources.Add(objDataSource);
            objDataConnectionDialog.ConnectionString = objAppConfigXML.GetAppConfigXML("SQLStringConnection");
            //Return
            String returnStringSQLConnection = (String.Empty);
            //Choice
            switch (choiceSQLConnectionString)
            {
                case ChoiceSQLConnectionString.GetDataSource:
                    {
                        returnStringSQLConnection = objDataConnectionDialog.SelectedDataSource.DisplayName;
                        break;
                    };
                case ChoiceSQLConnectionString.GetDataProvider:
                    {
                        returnStringSQLConnection = objDataConnectionDialog.SelectedDataProvider.DisplayName;
                        break;
                    };
                case ChoiceSQLConnectionString.GetConnectionString:
                    {
                        returnStringSQLConnection = objDataConnectionDialog.ConnectionString;
                        break;
                    };
                default:
                    {
                        break;
                    };
            };
            return returnStringSQLConnection;
        }
        #endregion
    }
}