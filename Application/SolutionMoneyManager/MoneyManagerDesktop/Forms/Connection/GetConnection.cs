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
    using System;
    using Microsoft.Data.ConnectionUI;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    #endregion

    class GetConnection
    {
        #region ---> (Connection SQL Server)
        /// <summary>
        /// # Return from FromMSSQLServer
        /// </summary>
        private SqlConnection returnSqlConnection = (new SqlConnection());
        /// <summary>
        /// # AppConfigXML 
        /// </summary>
        private AppConfigXML objAppConfigXML = (new AppConfigXML());
        /// <summary>
        /// # Return SqlConnection  ( True=Open  |  False=Close )
        /// </summary>
        /// <returns></returns>
        public SqlConnection FromMSSQLServer(bool TrueOpenFalseClose)
        {
            if ((TrueOpenFalseClose) == (true))
            {
                try
                {
                    String myStringSQL = (objAppConfigXML.GetAppConfigXML("SQLStringConnection"));

                    if ((String.IsNullOrEmpty(myStringSQL)) == (false))
                    {
                        Boolean StateConeection = ((returnSqlConnection.State) == (ConnectionState.Closed));

                        if (StateConeection)
                        {
                            returnSqlConnection = (new SqlConnection(myStringSQL));
                            returnSqlConnection.Open();
                        };
                    }
                    else if (String.IsNullOrEmpty(myStringSQL) == (true))
                    {
                        returnSqlConnection.ConnectionString = (String.Empty);
                    };
                }
                catch
                {
                    returnSqlConnection.ConnectionString = (String.Empty);
                };
            }
            else if ((TrueOpenFalseClose) == (false))
            {
                Boolean StateConeection = ((returnSqlConnection.State) == (ConnectionState.Open));

                if (StateConeection)
                {
                    try
                    {
                        returnSqlConnection.Close();
                    }
                    finally
                    {
                        returnSqlConnection.Dispose();
                    };
                };
            };
            return (returnSqlConnection);
        }
        /// <summary>
        ///  # FromMSSQLServerString
        /// </summary>
        /// <returns></returns>
        public string FromMSSQLServerString(Chose.SQLConnectionString SQLConnectionString)
        {
            DataSource objDataSource = (new DataSource("MicrosoftSqlServer", "Microsoft SQL Server"));
            DataConnectionDialog objDataConnectionDialog = (new DataConnectionDialog());

            objDataSource.Providers.Add(DataProvider.SqlDataProvider);
            objDataConnectionDialog.DataSources.Add(objDataSource);
            objDataConnectionDialog.ConnectionString = (objAppConfigXML.GetAppConfigXML("SQLStringConnection"));
            //Return
            String returnStringSQLConnection = (String.Empty);
            //Choice
            switch (SQLConnectionString)
            {
                case (Chose.SQLConnectionString.GetDataSource):
                    {
                        returnStringSQLConnection = (objDataConnectionDialog.SelectedDataSource.DisplayName);
                        break;
                    };
                case (Chose.SQLConnectionString.GetDataProvider):
                    {
                        returnStringSQLConnection = (objDataConnectionDialog.SelectedDataProvider.DisplayName);
                        break;
                    };
                case (Chose.SQLConnectionString.GetConnectionString):
                    {
                        returnStringSQLConnection = (objDataConnectionDialog.ConnectionString);
                        break;
                    };
                default:
                    {
                        break;
                    };
            };
            return (returnStringSQLConnection);
        }
        #endregion
    }
}