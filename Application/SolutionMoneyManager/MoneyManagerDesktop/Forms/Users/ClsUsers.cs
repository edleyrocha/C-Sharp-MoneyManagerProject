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
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Data.SqlClient;
    #endregion
    class ClsUsers
    {

        //Strings Fields [dbo].[tblUsers]
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string status { get; set; }

        /// <summary>
        /// # Users Status
        /// </summary>
        public enum StatusUser
        {
            Enabled = 0,
            Disabled = 1
        }

        /// <summary>
        /// # Insert New Users
        /// </summary>
        /// <returns></returns>
        public bool InsertNewUsersCommand(String myNewName, String myNewLogin, String myNewPassword, String myNewStatus)
        {
            AppConfigXML appConfigXML = (new AppConfigXML());
            String myStringSQL = (appConfigXML.GetAppConfigXML("SQLStringConnection"));
            SqlConnection connSQL = (new SqlConnection(myStringSQL));

            //INSERT INTO [tblUsers] VALUES (@Name,@Login,@Password,@StatusEnabled);
            StringBuilder myCommandStringSQL = new StringBuilder();
            myCommandStringSQL.Append("INSERT INTO [tblUsers] VALUES (");
            myCommandStringSQL.Append("@Name,");
            myCommandStringSQL.Append("@Login,");
            myCommandStringSQL.Append("@Password,");
            myCommandStringSQL.Append("@StatusEnabled);");

            SqlCommand cmdSQL = new SqlCommand((Convert.ToString(myCommandStringSQL)), connSQL);

            cmdSQL.Parameters.AddWithValue("@Name", myNewName);
            cmdSQL.Parameters.AddWithValue("@Login", myNewLogin);
            cmdSQL.Parameters.AddWithValue("@Password", myNewPassword);
            cmdSQL.Parameters.AddWithValue("@StatusEnabled", myNewStatus);

            Boolean returnBool = (false);
            try
            {
                connSQL.Open();

                cmdSQL.ExecuteNonQuery();

                returnBool = (true);
            }
            catch
            {
                returnBool = (false);
            }
            finally
            {
                connSQL.Close();
            };
            return (returnBool);
        }

        /// <summary>
        /// # Update Name, Login and Password for Name
        /// </summary>
        /// <returns></returns>
        public bool UpdateNameLoginPasswordForName(String updateMyName, String myNewName, String myNewLogin, String myNewPassword)
        {
            Boolean returnBool = (false);
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");

            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String myCommandStringSQL = String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}",
                                                         ("UPDATE [tblUsers] SET [Name] = ('"),
                                                         (myNewName),
                                                         ("'), [Login] = ('"),
                                                         (myNewLogin),
                                                         ("'), [Password] = ('"),
                                                         (myNewPassword),
                                                         ("') WHERE [Name] = ('"),
                                                         (updateMyName),
                                                         ("');"));

                using (SqlCommand cmdSQL = new SqlCommand((myCommandStringSQL), connSQL))
                {
                    try
                    {
                        connSQL.Open();

                        int AffectedLines = (0); ;

                        AffectedLines = (cmdSQL.ExecuteNonQuery());

                        if ((AffectedLines) == (1))
                        {
                            returnBool = (true);
                        };
                    }
                    catch
                    {
                        returnBool = (false);
                    }
                    finally
                    {
                        connSQL.Close();
                    };
                };
            };
            return (returnBool);
        }

        /// <summary>
        /// # Update Status for Name
        /// </summary>
        /// <returns></returns>
        public bool UpdateStatusForName(String updateMyName, StatusUser myNewStatus)
        {
            Boolean returnBool = (false);
            DataTable returnDataTable = new DataTable();
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");

            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String newStatus = ((myNewStatus).ToString());

                String myCommandStringSQL = String.Format(("{0}{1}{2}{3}{4}"),
                                                          ("UPDATE [tblUsers] SET [Status] = ('"),
                                                          (newStatus),
                                                          ("') WHERE [Name] = ('"),
                                                          (updateMyName),
                                                          ("');"));

                using (SqlCommand cmdSQL = new SqlCommand((myCommandStringSQL), connSQL))
                {
                    try
                    {
                        connSQL.Open();

                        int AffectedLines = (0);

                        AffectedLines = (cmdSQL.ExecuteNonQuery());

                        if ((AffectedLines) == (1))
                        {
                            returnBool = (true);
                        }
                    }
                    catch
                    {
                        returnBool = (false);
                    }
                    finally
                    {
                        connSQL.Close();
                    };
                };
            };
            return returnBool;
        }

        /// <summary>
        /// # Check if User Name Exist
        /// </summary>
        /// <returns></returns>
        public bool CheckUserNameExist(String checkMyName)
        {
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");
            SqlConnection connSQL = new SqlConnection(myStringSQL);

            //SELECT [Name] FROM [tblUsers] WHERE [Name] = @Nome;
            StringBuilder myCommandStringSQL = new StringBuilder();
            myCommandStringSQL.Append("SELECT [Name] FROM [tblUsers] ");
            myCommandStringSQL.Append("WHERE ");
            myCommandStringSQL.Append("[Name] ");
            myCommandStringSQL.Append("= ");
            myCommandStringSQL.Append("@Name;");

            SqlCommand cmdSQL = new SqlCommand((Convert.ToString(myCommandStringSQL)), connSQL);

            cmdSQL.Parameters.AddWithValue("@Name", checkMyName);

            Boolean returnBool = (false);

            try
            {
                connSQL.Open();

                SqlDataReader drSQL = cmdSQL.ExecuteReader();

                int countRowsLines = (0);

                while (drSQL.Read())
                {
                    countRowsLines++;
                };

                if ((countRowsLines) == (0))
                {
                    returnBool = (true); // NOT EXIST (Name)
                }
                else if ((countRowsLines) >= (1))
                {
                    returnBool = (false);// EXIST (Name)
                };
            }
            catch
            {
                returnBool = (false); // ERROR connSQL OR drSQL
            }
            finally
            {
                connSQL.Close();
            };
            return (returnBool);
        }

        /// <summary>
        /// # Check if User Login Exist
        /// </summary>
        /// <returns></returns>
        public bool CheckUserLoginExist(String checkMyLogin)
        {
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");
            SqlConnection connSQL = new SqlConnection(myStringSQL);

            //SELECT [Login] FROM [tblUsers] WHERE [Login] = @Login;
            StringBuilder myCommandStringSQL = new StringBuilder();
            myCommandStringSQL.Append("SELECT [Login] FROM [tblUsers] ");
            myCommandStringSQL.Append("WHERE ");
            myCommandStringSQL.Append("[Login] ");
            myCommandStringSQL.Append("= ");
            myCommandStringSQL.Append("@Login;");

            SqlCommand cmdSQL = new SqlCommand((Convert.ToString(myCommandStringSQL)), connSQL);

            cmdSQL.Parameters.AddWithValue("@Login", checkMyLogin);

            Boolean returnBool = (false);

            try
            {
                connSQL.Open();
                SqlDataReader drSQL = cmdSQL.ExecuteReader();
                int countRowsLines = (0);

                while (drSQL.Read())
                {
                    countRowsLines++;
                };

                if ((countRowsLines) == (0))
                {
                    returnBool = (true);// NOT EXIST (Login)
                }
                else if ((countRowsLines) >= (1))
                {
                    returnBool = (false); // EXIST (Login)
                };
            }
            catch
            {
                returnBool = (false); // Error
            }
            finally
            {
                connSQL.Close();
            };
            return (returnBool);
        }

        /// <summary>
        /// # List Names for Status
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNameForStatus(StatusUser listMyStatus)
        {
            DataTable returnDataTable = new DataTable();
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");

            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String Status = (listMyStatus.ToString());
                String myCommandStringSQL = String.Format(("{0}{1}{2}"),
                                                         ("SELECT [Name] AS [Nome Completo] FROM [tblUsers] WHERE [Status] = ('"),
                                                         (Status), ("');"));

                using (SqlCommand cmdSQL = new SqlCommand((myCommandStringSQL), (connSQL)))
                {
                    try
                    {
                        connSQL.Open();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdSQL);

                        sqlDataAdapter.Fill(returnDataTable);
                    }
                    catch
                    {
                        returnDataTable.Columns.Add(("Erro ao Listar"), (typeof(Int32)));
                    }
                    finally
                    {
                        connSQL.Close();
                    };
                };
            };
            return (returnDataTable);
        }

        /// <summary>
        /// # List Names and Login for Status
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNameLoginForStatus(StatusUser listMyStatus)
        {
            DataTable returnDataTable = new DataTable();
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");
            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String Status = ((listMyStatus).ToString());

                String myCommandStringSQL = String.Format(("{0}{1}{2}"),
                                                         ("SELECT [Name] AS [Nome Completo], [Login] AS [Login de Acesso] FROM [tblUsers] WHERE [Status] = ('"),
                                                         (Status), ("');"));

                using (SqlCommand cmdSQL = new SqlCommand((myCommandStringSQL), connSQL))
                {
                    try
                    {
                        connSQL.Open();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdSQL);

                        sqlDataAdapter.Fill(returnDataTable);
                    }
                    catch
                    {
                        returnDataTable.Columns.Add("Erro ao Listar", typeof(Int32));
                    }
                    finally
                    {
                        connSQL.Close();
                    };
                };
            };
            return (returnDataTable);
        }

        /// <summary>
        /// # List Name, Login And Password for Name and Status
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNameLoginPasswordForStatus(String listMyName, StatusUser listMyStatus)
        {
            DataTable returnDataTable = new DataTable();
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");

            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String Status = (listMyStatus.ToString());
                String myCommandStringSQL = String.Format(("{0}{1}{2}{3}{4}"),
                                                         ("SELECT [Name], [Login], [Password], [Status] FROM [tblUsers] WHERE [Name] = ('"),
                                                         (listMyName),
                                                         ("') AND [Status] = ('"),
                                                         (Status),
                                                         ("');"));

                using (SqlCommand cmdSQL = new SqlCommand((myCommandStringSQL), connSQL))
                {
                    try
                    {
                        connSQL.Open();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdSQL);

                        sqlDataAdapter.Fill(returnDataTable);
                    }
                    catch
                    {
                        returnDataTable.Columns.Add("Erro ao Listar", typeof(Int32));
                    }
                    finally
                    {
                        connSQL.Close();
                    };
                };
            };
            return (returnDataTable);
        }
    }
}