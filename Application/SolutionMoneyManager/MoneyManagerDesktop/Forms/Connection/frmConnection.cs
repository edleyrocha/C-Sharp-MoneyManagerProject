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
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using MetroFramework.Forms;
    using MetroFramework;
    using Microsoft.Data.ConnectionUI;
    using System.Data.SqlClient;
    #endregion
    public partial class frmConnection : MetroForm
    {
        public frmConnection()
        {
            InitializeComponent();
            SetConfigStartConnections();
        }
         public void SetConfigStartConnections()
        {
            this.Text = ("Data Base");
            textBoxSource.Text = "";
            textBoxProvider.Text = "";
            textBoxString.Text = "";
            this.btnLoad.Text = ("Carregar");
            this.btnNovo.Text = ("Novo");
            this.btnTest.Text = ("Testar");
            this.btnClose.Text = ("Sair");
            pbxDataBaseLogo.Image = MoneyManagerDesktop.Forms.Connection.resConnection.db_add72;
        }
         private void btnClose_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void btnNovo_Click(object sender, EventArgs e)
         {
             DataSource sqlDataSource = new DataSource("MicrosoftSqlServer", "Microsoft SQL Server");
             sqlDataSource.Providers.Add(DataProvider.SqlDataProvider);
             DataConnectionDialog dcd = new DataConnectionDialog();
             dcd.DataSources.Add(sqlDataSource);
             dcd.SelectedDataProvider = DataProvider.SqlDataProvider;
             dcd.SelectedDataSource = sqlDataSource;

             // DIALOG DataConnection
             if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
             {
                 textBoxSource.Text = dcd.SelectedDataSource.DisplayName;
                 textBoxProvider.Text = dcd.SelectedDataProvider.DisplayName;
                 textBoxString.Text = dcd.ConnectionString;

                 // MSG SAVE
                 String msg_Title = (this.Text + " Conexão");
                 String msg_Text = ("\r\r\t\tDeseja Salvar esta Conexão?");
                 MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
                 MessageBoxIcon msg_Icon = MessageBoxIcon.None;
                 MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
                 DialogResult msgResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
                 if (msgResult == DialogResult.Yes)
                 {
                     AppConfigXML appConfigXML = new AppConfigXML();
                     appConfigXML.SetAppConfigFileConnectionsString("SQLStringConnection", dcd.ConnectionString);
                 };
             };
             //dcd.Dispose();
         }
         private void btnLoad_Click(object sender, EventArgs e)
         {
             DataSource sqlDataSource = new DataSource("MicrosoftSqlServer", "Microsoft SQL Server");
             sqlDataSource.Providers.Add(DataProvider.SqlDataProvider);
             DataConnectionDialog dcd = new DataConnectionDialog();
             dcd.DataSources.Add(sqlDataSource);
             AppConfigXML appConfigXML = new AppConfigXML();
             dcd.ConnectionString = appConfigXML.GetAppConfigFileConnectionsString("SQLStringConnection");
             textBoxSource.Text = dcd.SelectedDataSource.DisplayName;
             textBoxProvider.Text = dcd.SelectedDataProvider.DisplayName;
             textBoxString.Text = dcd.ConnectionString;
         }

         private void btnTest_Click(object sender, EventArgs e)
         {

         }
    }
}