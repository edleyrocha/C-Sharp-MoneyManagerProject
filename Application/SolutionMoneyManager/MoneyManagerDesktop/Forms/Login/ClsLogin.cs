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
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Data.SqlClient;
    #endregion

    /// <summary>
    ///  #Class Login
    /// </summary>
    class ClsLogin
    {
        public int CheckdUserID;
        public string CheckdUserLogin;
        public Chose.AcessLoginStatus CheckUserLogin(String login, String password)
        {
            Chose.AcessLoginStatus returnAcessLoginStatus = (Chose.AcessLoginStatus.AllowedDenied);

            String myStatus = (StatusUser.Enabled.ToString());
            String myLogin = (login.Trim());
            String myPassword = (password.Trim());

            String myCommandStringSQL = String.Format(("{0} {1} {2}"),
                                                         ("SELECT [Id], [Name], [Login], [Password], [Status]"),
                                                         ("FROM [tblUsers]"),
                                                         ("WHERE [Status] = (@myStatus) AND [Login] = (@myLogin) AND [Password] = (@myPassword);"));
            GetConnection objGetConnection = (new GetConnection());
            try
            {
                using (SqlCommand cmdSQL = new SqlCommand((myCommandStringSQL), (objGetConnection.FromMSSQLServer(true))))
                {
                    // Simple and Advanced modes
                    //1
                    cmdSQL.Parameters.AddWithValue(("@myStatus"), (myStatus)); // 1
                    //2
                    cmdSQL.Parameters.AddWithValue(("@myLogin"), (SqlDbType.NVarChar)).Value = (myLogin); // 2 
                    //3
                    cmdSQL.Parameters.AddWithValue("@myPassword", (SqlDbType.NVarChar));//3
                    cmdSQL.Parameters["@myPassword"].Value = (myPassword);

                    SqlDataAdapter sqlDataAdapter = (new SqlDataAdapter(cmdSQL));
                    DataTable dataTable = (new DataTable());

                    sqlDataAdapter.Fill(dataTable);

                    if ((dataTable.Rows.Count) == (1))
                    {
                        Boolean checkLogin = ((myLogin) == (dataTable.Rows[0][2].ToString()));
                        Boolean checkPassword = ((myPassword) == (dataTable.Rows[0][3].ToString()));
                        Boolean checkStatus = ((myStatus) == (dataTable.Rows[0][4].ToString()));

                        if ((checkStatus) && (checkLogin) && (checkPassword))
                        {
                            CheckdUserID = ((int)(dataTable.Rows[0][0]));
                            CheckdUserLogin = (dataTable.Rows[0][1].ToString());
                            returnAcessLoginStatus = (Chose.AcessLoginStatus.AllowedAccess);
                        }
                    }
                }
            }
            catch
            {
                returnAcessLoginStatus = (Chose.AcessLoginStatus.AllowedDenied);
            }
            finally
            {
                objGetConnection.FromMSSQLServer(false);
            }
            return (returnAcessLoginStatus);
        }


    }
}
