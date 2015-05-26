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
    using System.Text;
    using System.Data;
    using System.Data.SqlClient;

    #endregion
    class clsUsers
    {

        //Strings Fields [dbo].[tblUsers]
        public int id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string status { get; set; }

        public enum StatusUser
        {
            Enabled = 0,
            Disabled = 1,
            Deleted = 2
        }

        public enum ChoseActionFormUsers
        {
            Insert = 0,
            Update = 1,
            Delete = 2
        }
        public String InsertUsersCommand()
        {
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = ("");
            myStringSQL = appConfigXML.GetAppConfigFileConnectionsString("SQLStringConnection");

            SqlConnection connSQL = new SqlConnection(myStringSQL);

            //INSERT INTO [tblUsers] VALUES (@Nome,@Login,@Password,@Status);
            StringBuilder myCommandStringSQL = new StringBuilder();
            myCommandStringSQL.Append("INSERT INTO [tblUsers] VALUES (");
            myCommandStringSQL.Append("@Nome,");
            myCommandStringSQL.Append("@Login,");
            myCommandStringSQL.Append("@Password,");
            myCommandStringSQL.Append("@Status);");

            SqlCommand cmdSQL = new SqlCommand((Convert.ToString(myCommandStringSQL)), connSQL);

            cmdSQL.Parameters.AddWithValue("@Nome", nome);
            cmdSQL.Parameters.AddWithValue("@Login", login);
            cmdSQL.Parameters.AddWithValue("@Password", password);
            cmdSQL.Parameters.AddWithValue("@Status", status);

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

        public String CheckUserNameInsertExist()
        {
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigFileConnectionsString("SQLStringConnection");
            SqlConnection connSQL = new SqlConnection(myStringSQL);

            //SELECT [Name] FROM [tblUsers] WHERE [Name] = @Nome;
            StringBuilder myCommandStringSQL = new StringBuilder();
            myCommandStringSQL.Append("SELECT [Name] FROM [tblUsers] ");
            myCommandStringSQL.Append("WHERE ");
            myCommandStringSQL.Append("[Name] ");
            myCommandStringSQL.Append("= ");
            myCommandStringSQL.Append("@Nome;");

            SqlCommand cmdSQL = new SqlCommand((Convert.ToString(myCommandStringSQL)), connSQL);

            cmdSQL.Parameters.AddWithValue("@Nome", nome);
            String returnString = (Boolean.FalseString);
            try
            {
                connSQL.Open();
                SqlDataReader drSQL = cmdSQL.ExecuteReader();
                int countRowsLines = (0);

                if (drSQL.HasRows == (true))
                {
                    countRowsLines++;
                };

                if ((countRowsLines) == (0))
                {
                    returnString = Boolean.TrueString;
                }
                else if ((countRowsLines) >= (1))
                {
                    returnString = Boolean.FalseString;
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

        public String CheckUserLoginInsertExist()
        {
            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQL = appConfigXML.GetAppConfigFileConnectionsString("SQLStringConnection");
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

                if (drSQL.HasRows == (true))
                {
                    countRowsLines++;
                };

                if ((countRowsLines) == (0))
                {
                    returnString = Boolean.TrueString;
                }
                else if ((countRowsLines) >= (1))
                {
                    returnString = Boolean.FalseString;
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
 
    }
}
