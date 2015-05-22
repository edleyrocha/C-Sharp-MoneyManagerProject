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
            this.txtBoxSource.Text = "";
            this.txtBoxProvider.Text = "";
            this.txtBoxString.Text = "";
            this.btnLoad.Text = ("Carregar");
            this.btnNovo.Text = ("Novo");
            this.btnTest.Text = ("Testar");
            this.btnClose.Text = ("Sair");
            this.pbxDataBaseLogo.Image = MoneyManagerDesktop.Forms.Connection.resConnection.db_add72;
        }
         private void btnClose_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void btnNovo_Click(object sender, EventArgs e)
         {
             clsConnection c = new clsConnection();
             if ((c.SetSQLConnectionString()) == (Boolean.TrueString))
             {
                 btnLoad.PerformClick();
             };
         }
         private void btnLoad_Click(object sender, EventArgs e)
         {
             clsConnection c = new clsConnection();
             txtBoxSource.Text = c.GetSQLConnectionString((clsConnection.ChoiceGetSQLConnectionString)0);
             txtBoxProvider.Text = c.GetSQLConnectionString((clsConnection.ChoiceGetSQLConnectionString)1);
             txtBoxString.Text = c.GetSQLConnectionString((clsConnection.ChoiceGetSQLConnectionString)2);
         }
 
         private void txtBox_KeyDown(object sender, KeyEventArgs e)
         {
             e.Handled = e.SuppressKeyPress = true; //No Send KeyPress
         }
    }
}