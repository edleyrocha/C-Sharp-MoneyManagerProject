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
    #endregion
    public partial class frmUser : MetroForm
    {
        public frmUser()
        {
            InitializeComponent();
            SetConfigStartUser();
        }
         public void SetConfigStartUser()
        {
            this.Text = ("Usuario");
        }
    }
}
