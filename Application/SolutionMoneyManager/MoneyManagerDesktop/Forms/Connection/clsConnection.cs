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
        public clsConnection()
        {

        }
       #region ---> ( Get and Set StringSQLConnection)
        DataSource sqlDataSource = new DataSource("MicrosoftSqlServer", "Microsoft SQL Server");
        DataConnectionDialog dcd = new DataConnectionDialog();
        AppConfigXML appConfigXML = new AppConfigXML();
        public enum ChoiceGetSQLConnectionString
        {
            GetDataSource = 0,
            GetDataProvider = 1,
            GetConnectionString = 2
        }
        public string GetSQLConnectionString(ChoiceGetSQLConnectionString choiceGetSQLConnectionString)
        {
            sqlDataSource.Providers.Add(DataProvider.SqlDataProvider);
            dcd.DataSources.Add(sqlDataSource);
            dcd.ConnectionString = appConfigXML.GetAppConfigFileConnectionsString("SQLStringConnection");
            //Return
            String returnStringSQLConnection = (String.Empty);
            //Choice
            switch (choiceGetSQLConnectionString)
            {
                case ChoiceGetSQLConnectionString.GetDataSource:
                    {
                        returnStringSQLConnection = dcd.SelectedDataSource.DisplayName;
                        break;
                    };
                case ChoiceGetSQLConnectionString.GetDataProvider:
                    {
                        returnStringSQLConnection = dcd.SelectedDataProvider.DisplayName;
                        break;
                    };
                case ChoiceGetSQLConnectionString.GetConnectionString:
                    {
                        returnStringSQLConnection = dcd.ConnectionString;
                        break;
                    };
                default:
                    {
                        break;
                    };
            };
            return returnStringSQLConnection;
        }
        public string SetSQLConnectionString()
        {
            sqlDataSource.Providers.Add(DataProvider.SqlDataProvider);
            dcd.DataSources.Add(sqlDataSource);
            dcd.SelectedDataProvider = DataProvider.SqlDataProvider;
            dcd.SelectedDataSource = sqlDataSource;
            String returnStrigOfBool = Boolean.FalseString;
            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
            {
                String msg_Title = String.Format("{0}", "Data Base Conexão");
                String msg_Text = String.Format("{0}{1}", "\r\r\t\t", "Deseja Salvar esta Conexão?");
                MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                DialogResult msgResult = MetroMessageBox.Show(Form.ActiveForm, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
                if (msgResult == DialogResult.Yes)
                {
                   appConfigXML.SetAppConfigFileConnectionsString("SQLStringConnection", dcd.ConnectionString);
                   returnStrigOfBool = Boolean.TrueString;
                };
            };
            return returnStrigOfBool;
        }
        #endregion
    }
}