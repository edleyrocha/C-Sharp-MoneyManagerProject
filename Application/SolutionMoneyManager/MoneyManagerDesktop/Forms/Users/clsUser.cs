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
    class clsUsers
    {

        //Strings Fields [dbo].[tblUsers]
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string status { get; set; }

        /// <summary>
        /// Users Status
        /// </summary>
        public enum StatusUser
        {
            Enabled = 0,
            Disabled = 1
        }

        /// <summary>
        /// Insert New Users
        /// </summary>
        /// <returns></returns>
        public String InsertNewUsersCommand()
        {
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = ("");
            myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");

            SqlConnection connSQL = new SqlConnection(myStringSQL);

            //INSERT INTO [tblUsers] VALUES (@Nome,@Login,@Password,@StatusEnabled);
            StringBuilder myCommandStringSQL = new StringBuilder();
            myCommandStringSQL.Append("INSERT INTO [tblUsers] VALUES (");
            myCommandStringSQL.Append("@Nome,");
            myCommandStringSQL.Append("@Login,");
            myCommandStringSQL.Append("@Password,");
            myCommandStringSQL.Append("@StatusEnabled);");

            SqlCommand cmdSQL = new SqlCommand((Convert.ToString(myCommandStringSQL)), connSQL);

            cmdSQL.Parameters.AddWithValue("@Nome", name);
            cmdSQL.Parameters.AddWithValue("@Login", login);
            cmdSQL.Parameters.AddWithValue("@Password", password);
            cmdSQL.Parameters.AddWithValue("@StatusEnabled", status);

            String returnString = (Boolean.FalseString);
            try
            {
                connSQL.Open();
                cmdSQL.ExecuteNonQuery();
                returnString = Boolean.TrueString;
            }
            catch
            {
                returnString = Boolean.FalseString;
            }
            finally
            {
                connSQL.Close();
            };
            //returnString = myCommandStringSQL.ToString(); // Return String  myCommandStringSQL (for Debug)
            return (returnString);
        }

        /// <summary>
        /// Update Name, Login and Password for Name
        /// </summary>
        /// <returns></returns>
        public String UpdateNameLoginPasswordForName(String myName)
        {
            String returnString = (Boolean.FalseString);
            DataTable returnDataTable = new DataTable();
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");

            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String myCommandStringSQL = String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}",
                                                         ("UPDATE [tblUsers] SET [Name] = ('"),
                                                         (name),
                                                         ("'), [Login] = ('"),
                                                         (login),
                                                         ("'), [Password] = ('"),
                                                         (password),
                                                         ("') WHERE [Name] = ('"),
                                                         (myName),
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
                            returnString = Boolean.TrueString;
                        };
                    }
                    catch
                    {
                        returnString = (Boolean.FalseString);
                    }
                    finally
                    {
                        connSQL.Close();
                    };
                };
            };
            return (returnString);
        }

        /// <summary>
        /// Update Status for Name
        /// </summary>
        /// <returns></returns>
        public String UpdateStatusForName(String myName, StatusUser myNewStatus)
        {
            String returnString = (Boolean.FalseString);
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
                                                          (myName),
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
                            returnString = Boolean.TrueString;
                        }
                    }
                    catch
                    {
                        returnString = (Boolean.FalseString);
                    }
                    finally
                    {
                        connSQL.Close();
                    };
                };
            };
            return returnString;
        }

        /// <summary>
        /// Check if User Exist
        /// </summary>
        /// <returns></returns>
        public String CheckUserNameInsertExist()
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
            myCommandStringSQL.Append("@Nome;");

            SqlCommand cmdSQL = new SqlCommand((Convert.ToString(myCommandStringSQL)), connSQL);

            cmdSQL.Parameters.AddWithValue("@Nome", name);

            String returnString = (Boolean.FalseString);

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
                    returnString = Boolean.TrueString; // NOT EXIST (Name)
                }
                else if ((countRowsLines) >= (1))
                {
                    returnString = Boolean.FalseString;// EXIST (Name)
                };
            }
            catch
            {
                returnString = Boolean.FalseString;
            }
            finally
            {
                connSQL.Close();
            };
            // returnString = myCommandStringSQL.ToString(); // Return String  myCommandStringSQL (for Debug)
            return (returnString);
        }

        /// <summary>
        /// Check if Login Exist
        /// </summary>
        /// <returns></returns>
        public String CheckUserLoginInsertExist()
        {
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");
            SqlConnection connSQL = new SqlConnection(myStringSQL);

            //SELECT [Name] FROM [tblUsers] WHERE [Login] = @Login;
            StringBuilder myCommandStringSQL = new StringBuilder();
            myCommandStringSQL.Append("SELECT [Login] FROM [tblUsers] ");
            myCommandStringSQL.Append("WHERE ");
            myCommandStringSQL.Append("[Login] ");
            myCommandStringSQL.Append("= ");
            myCommandStringSQL.Append("@Login;");

            SqlCommand cmdSQL = new SqlCommand((Convert.ToString(myCommandStringSQL)), connSQL);

            cmdSQL.Parameters.AddWithValue("@Login", login);

            String returnString = (Boolean.FalseString);

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
                    returnString = Boolean.TrueString;// NOT EXIST (Login)
                }
                else if ((countRowsLines) >= (1))
                {
                    returnString = Boolean.FalseString; // EXIST (Login)
                };
            }
            catch
            {
                returnString = Boolean.FalseString;
            }
            finally
            {
                connSQL.Close();
            };
            //returnString = myCommandStringSQL.ToString(); // Return String  myCommandStringSQL (for Debug)
            return (returnString);
        }

        /// <summary>
        /// List Names for Status
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNameForStatus(StatusUser myStatus)
        {
            DataTable returnDataTable = new DataTable();
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");

            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String Status = (myStatus.ToString());
                String myCommandStringSQL = String.Format(("{0}{1}{2}"),
                                                         ("SELECT [Name] AS [Nome Completo] FROM [tblUsers] WHERE [Status] = ('"),
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
                        DataColumn dataColumn = returnDataTable.Columns.Add("Erro ao Listar", typeof(Int32));
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
        /// List Names and Login for Status
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNameLoginForStatus(StatusUser myStatus)
        {
            DataTable returnDataTable = new DataTable();
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");
            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String Status = ((myStatus).ToString());

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
                        DataColumn dataColumn = returnDataTable.Columns.Add("Erro ao Listar", typeof(Int32));
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
        ///  List Name, Login And Password for Name and Status
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNameLoginPasswordForStatus(String myName, StatusUser myStatus)
        {
            DataTable returnDataTable = new DataTable();
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigXML("SQLStringConnection");

            using (SqlConnection connSQL = new SqlConnection(myStringSQL))
            {
                String Status = (myStatus.ToString());
                String myCommandStringSQL = String.Format(("{0}{1}{2}{3}{4}"),
                                                         ("SELECT [Name], [Login], [Password], [Status] FROM [tblUsers] WHERE [Name] = ('"),
                                                         (myName),
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
                        DataColumn dataColumn = returnDataTable.Columns.Add("Erro ao Listar", typeof(Int32));
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