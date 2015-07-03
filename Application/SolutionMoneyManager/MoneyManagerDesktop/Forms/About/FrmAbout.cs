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
    using MetroFramework.Forms;
    using System;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;
    #endregion
    public partial class FrmAbout : MetroForm
    {
        public FrmAbout()
        {
            InitializeComponent();
            SetConfigStartAbout();
        }
        #region ---> (Assembly Attribute Accessors)

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
        public void SetConfigStartAbout()
        {
            this.Text = ("Sobre");
            this.btnClose.Text = ("&Sair");
            this.lbl_Product.Text = AssemblyProduct;
            this.lbl_Version.Text = String.Format("Version {0}", AssemblyVersion);
            this.lbl_Ringht.Text = AssemblyCopyright;
            this.lbl_Company.Text = AssemblyCompany;
            this.rtbDescription.Text = AssemblyDescription;
            this.imgHelpAbout.Text = ("");
            this.imgHelpAbout.UseTileImage = (true);
            this.imgHelpAbout.TileImageAlign = ContentAlignment.MiddleCenter;
            this.imgHelpAbout.TileImage = MoneyManagerDesktop.Forms.About.ResAbout.HelpAbout128;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rtbDescription_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = e.SuppressKeyPress = (true);
        }
    }
}