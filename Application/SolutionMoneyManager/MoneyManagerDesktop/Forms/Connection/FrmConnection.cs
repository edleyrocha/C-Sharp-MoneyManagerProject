﻿///////////////////////////////////////////////
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
        #region ---> (Form FrmConnectio)
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = e.SuppressKeyPress = true; //No Send KeyPress
        }
        #endregion

        #region ---> (BTN Save)
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewSQLConnectionString();
        }
        private void NewSQLConnectionString()
        {
            ClsConnection objClsConnection = new ClsConnection();
            if (objClsConnection.NewSQLConnectionString()) // IF NewSQLConnectionString (TRUE) Load Config
            {
                this.btnLoad.Text = ("Carregar Conexão");
                this.LoadSQLConnectionString();
            };
            this.txtBoxString.Focus();
        }
        #endregion

        #region ---> (BTN Load)
        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.LoadSQLConnectionString();
        }

        private void LoadSQLConnectionString()
        {
            GetConnection objGetSQLConnectionString = new GetConnection();
            ClsConnection objClsConnection = new ClsConnection();

            if ((this.btnLoad.Text) == ("Carregar Conexão"))
            {
                this.txtBoxSource.Text = (objGetSQLConnectionString.FromMSSQLServerString(Chose.SQLConnectionString.GetDataSource));
                this.txtBoxProvider.Text = (objGetSQLConnectionString.FromMSSQLServerString(Chose.SQLConnectionString.GetDataProvider));
                this.txtBoxString.Text = (objGetSQLConnectionString.FromMSSQLServerString(Chose.SQLConnectionString.GetConnectionString));
                this.btnLoad.Text = ("Testar Conexão");
            }
            else if ((this.btnLoad.Text) == ("Testar Conexão"))
            {
                string connectionString = (this.txtBoxString.Text);
                objClsConnection.LoadSQLConnectionString(connectionString);
                this.btnLoad.Text = ("Carregar Conexão");
            };
            this.txtBoxString.Focus();
        }
        #endregion
    }
}