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
            String returnString = (String.Empty);

            AppConfigXML appConfigXML = new AppConfigXML();
            String myStringSQLConnection = (String.Empty);
            myStringSQLConnection = appConfigXML.GetAppConfigFileConnectionsString("SQLStringConnection");

            //myCommandStringSQL
            //INSERT INTO [tblUsers] VALUES (@Nome,@Login,@Password,@Status);
            //SELECT (@@IDENTITY) AS [returnMyNewID];
            StringBuilder myCommandStringSQL = new StringBuilder();
            myCommandStringSQL.Clear();
            myCommandStringSQL.Append("INSERT INTO [tblUsers] VALUES (");
            myCommandStringSQL.Append("@Nome, ");
            myCommandStringSQL.Append("@Login, ");
            myCommandStringSQL.Append("@Password, ");
            myCommandStringSQL.Append("@Status); ");
            myCommandStringSQL.AppendLine("");
            myCommandStringSQL.Append("SELECT (@@IDENTITY) AS [returnMyNewID];");

            SqlConnection connSQL = new SqlConnection();
            connSQL.ConnectionString = (""); //FORCE CLEAR ConnectionString
            connSQL.ConnectionString = myStringSQLConnection;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.Parameters.Clear(); //FORCE CLEAR Parameters

            cmdSQL.Connection = (connSQL);

            cmdSQL.CommandType = (CommandType.Text);
            cmdSQL.CommandText = (Convert.ToString(myCommandStringSQL));

            cmdSQL.Parameters.AddWithValue("@Nome", nome);
            cmdSQL.Parameters.AddWithValue("@Login", login);
            cmdSQL.Parameters.AddWithValue("@Password", password);
            cmdSQL.Parameters.AddWithValue("@Status", status);

            try
            {
                connSQL.Open();
                returnString = (Convert.ToString(cmdSQL.ExecuteScalar())); // returnString @@IDENTITY  of InsertUsers
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