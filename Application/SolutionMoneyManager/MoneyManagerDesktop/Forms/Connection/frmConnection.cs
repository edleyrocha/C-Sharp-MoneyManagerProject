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
    public partial class FrmConnection : MetroForm
    {

        public FrmConnection()
        {
            this.InitializeComponent();
            this.SetConfigStartConnections();
        }
        private void SetConfigStartConnections()
        {
            // FORM SIZE = 386; 330 Default
            this.Text = ("Data Base");
            this.btnNew.Text = ("Nova Conexão");
            this.btnClose.Text = ("Sair");
            this.btnLoad.Text = ("Carregar Conexão");
            this.txtBoxSource.Text = ("");
            this.txtBoxProvider.Text = ("");
            this.txtBoxProvider.Multiline = (true);
            this.txtBoxString.Text = ("");
            this.txtBoxString.Multiline = (true);
            this.img_LogoDB.Text = ("");
            this.img_LogoDB.UseTileImage = (true);
            this.img_LogoDB.TileImageAlign = ContentAlignment.MiddleCenter;
            this.img_LogoDB.TileImage = MoneyManagerDesktop.Forms.Connection.ResConnection.DataBaseAdd128;
        }
        private void NewSQLConnectionString()
        {
            clsConnection objC = new clsConnection();
            if (objC.NewSQLConnectionString()) // IF NewSQLConnectionString (TRUE) Load Config
            {
                this.btnLoad.PerformClick();
            };
            this.txtBoxString.Focus();
        }
        private void LoadSQLConnectionString()
        {
            clsConnection objC = new clsConnection();
            if ((this.btnLoad.Text) == ("Carregar Conexão"))
            {
                this.txtBoxSource.Text = (objC.GetSQLConnectionString(clsConnection.ChoiceSQLConnectionString.GetDataSource));
                this.txtBoxProvider.Text = (objC.GetSQLConnectionString(clsConnection.ChoiceSQLConnectionString.GetDataProvider));
                this.txtBoxString.Text = (objC.GetSQLConnectionString(clsConnection.ChoiceSQLConnectionString.GetConnectionString));
                this.btnLoad.Text = ("Testar Conexão");
            }
            else if ((this.btnLoad.Text) == ("Testar Conexão"))
            {
                string connectionString = (this.txtBoxString.Text);
                objC.LoadSQLConnectionString(connectionString);
                this.btnLoad.Text = ("Carregar Conexão");
            };
            this.txtBoxString.Focus();
        }
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = e.SuppressKeyPress = true; //No Send KeyPress
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewSQLConnectionString();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.LoadSQLConnectionString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}