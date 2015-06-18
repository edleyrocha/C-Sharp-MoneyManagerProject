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
    using System.Globalization;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using MetroFramework;
    using MetroFramework.Forms;
    using System.Windows.Forms;
    #endregion
    public partial class frmColor : MetroForm
    {
        public frmColor()
        {
            InitializeComponent();
            SetConfigStartColors();
        }
        private void SetConfigStartColors()
        {
            this.Text = ("Temas do Aplicativo");
            this.btnClose.Text = ("&Sair");
            this.btnSalvar.Text = ("&Salvar");
            this.Tag = (Convert.ToString(4));

            List<String> NameColors = new List<String>(); //List Colors
            NameColors.Add(Convert.ToString(MetroColorStyle.Default));      //0
            NameColors.Add(Convert.ToString(MetroColorStyle.Black));        //1
            NameColors.Add(Convert.ToString(MetroColorStyle.White));        //2
            NameColors.Add(Convert.ToString(MetroColorStyle.Silver));       //3
            NameColors.Add(Convert.ToString(MetroColorStyle.Blue));         //4
            NameColors.Add(Convert.ToString(MetroColorStyle.Green));        //5
            NameColors.Add(Convert.ToString(MetroColorStyle.Lime));         //6
            NameColors.Add(Convert.ToString(MetroColorStyle.Teal));         //7
            NameColors.Add(Convert.ToString(MetroColorStyle.Orange));       //8
            NameColors.Add(Convert.ToString(MetroColorStyle.Brown));        //9
            NameColors.Add(Convert.ToString(MetroColorStyle.Pink));         //10
            NameColors.Add(Convert.ToString(MetroColorStyle.Magenta));      //11
            NameColors.Add(Convert.ToString(MetroColorStyle.Purple));       //12
            NameColors.Add(Convert.ToString(MetroColorStyle.Red));          //13
            NameColors.Add(Convert.ToString(MetroColorStyle.Yellow));       //14

            for (int item = 0; item < NameColors.Count; item++)
            {
                switch (item)
                {
                    case 0:
                        {
                            this.rbt0.Text = (NameColors[item].ToString());
                            this.rbt0.Style = (MetroColorStyle)item;
                            this.rbt0.Tag = (Convert.ToString(item));
                            this.metroTile0.Text = (NameColors[item].ToString());
                            this.metroTile0.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 1:
                        {
                            this.rbt1.Text = (NameColors[item].ToString());
                            this.rbt1.Style = (MetroColorStyle)item;
                            this.rbt1.Tag = (Convert.ToString(item));
                            this.metroTile1.Text = (NameColors[item].ToString());
                            this.metroTile1.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 2:
                        {
                            this.rbt2.Text = (NameColors[item].ToString());
                            this.rbt2.Style = (MetroColorStyle)item;
                            this.rbt2.Tag = (Convert.ToString(item));
                            this.metroTile2.Text = (NameColors[item].ToString());
                            this.metroTile2.Style = (MetroColorStyle)item;
                            break;
                        }
                    case 3:
                        {
                            this.rbt3.Text = (NameColors[item].ToString());
                            this.rbt3.Style = (MetroColorStyle)item;
                            this.rbt3.Tag = (Convert.ToString(item));
                            this.metroTile3.Text = (NameColors[item].ToString());
                            this.metroTile3.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 4:
                        {
                            this.rbt4.Text = (NameColors[item].ToString());
                            this.rbt4.Style = (MetroColorStyle)item;
                            this.rbt4.Tag = (Convert.ToString(item));
                            this.metroTile4.Text = (NameColors[item].ToString());
                            this.metroTile4.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 5:
                        {
                            this.rbt5.Text = (NameColors[item].ToString());
                            this.rbt5.Style = (MetroColorStyle)item;
                            this.rbt5.Tag = (Convert.ToString(item));
                            this.metroTile5.Text = (NameColors[item].ToString());
                            this.metroTile5.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 6:
                        {
                            this.rbt6.Text = (NameColors[item].ToString());
                            this.rbt6.Style = (MetroColorStyle)item;
                            this.rbt6.Tag = (Convert.ToString(item));
                            this.metroTile6.Text = (NameColors[item].ToString());
                            this.metroTile6.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 7:
                        {
                            this.rbt7.Text = (NameColors[item].ToString());
                            this.rbt7.Style = (MetroColorStyle)item;
                            this.rbt7.Tag = (Convert.ToString(item));
                            this.metroTile7.Text = (NameColors[item].ToString());
                            this.metroTile7.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 8:
                        {
                            this.rbt8.Text = (NameColors[item].ToString());
                            this.rbt8.Style = (MetroColorStyle)item;
                            this.rbt8.Tag = (Convert.ToString(item));
                            this.metroTile8.Text = (NameColors[item].ToString());
                            this.metroTile8.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 9:
                        {
                            this.rbt9.Text = (NameColors[item].ToString());
                            this.rbt9.Style = (MetroColorStyle)item;
                            this.rbt9.Tag = (Convert.ToString(item));
                            this.metroTile9.Text = (NameColors[item].ToString());
                            this.metroTile9.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 10:
                        {
                            this.rbt10.Text = (NameColors[item].ToString());
                            this.rbt10.Style = (MetroColorStyle)item;
                            this.rbt10.Tag = (Convert.ToString(item));
                            this.metroTile10.Text = (NameColors[item].ToString());
                            this.metroTile10.Style = (MetroColorStyle)item;
                            break;
                        };
                    case 11:
                        {
                            this.rbt11.Text = (NameColors[item].ToString());
                            this.rbt11.Style = (MetroColorStyle)item;
                            this.rbt11.Tag = (Convert.ToString(item));
                            this.metroTile11.Text = (NameColors[item].ToString());
                            this.metroTile11.Style = (MetroColorStyle)item;
                            this.metroTile11.Refresh();
                            break;
                        };
                    case 12:
                        {
                            this.rbt12.Text = (NameColors[item].ToString());
                            this.rbt12.Style = (MetroColorStyle)item;
                            this.rbt12.Tag = (Convert.ToString(item));
                            this.metroTile12.Text = (NameColors[item].ToString());
                            this.metroTile12.Style = (MetroColorStyle)item;
                            this.metroTile12.Refresh();
                            break;
                        };
                    case 13:
                        {
                            this.rbt13.Text = (NameColors[item].ToString());
                            this.rbt13.Style = (MetroColorStyle)item;
                            this.rbt13.Tag = (Convert.ToString(item));
                            this.metroTile13.Text = (NameColors[item].ToString());
                            this.metroTile13.Style = (MetroColorStyle)item;
                            this.metroTile13.Refresh();
                            break;
                        };
                    case 14:
                        {
                            this.rbt14.Text = (NameColors[item].ToString());
                            this.rbt14.Style = (MetroColorStyle)item;
                            this.rbt14.Tag = (Convert.ToString(item));
                            this.metroTile14.Text = (NameColors[item].ToString());
                            this.metroTile14.Style = (MetroColorStyle)item;
                            break;
                        };
                    default:
                        {
                            break;
                        };
                };
            };
        }

        private void MudarCores(object sender, EventArgs e)
        {
            // SEND BUTTON id
            MetroFramework.Controls.MetroRadioButton rbt = sender as MetroFramework.Controls.MetroRadioButton;
            // USE BUTTON TAG
            int rbtMyTagID = (int.Parse(rbt.Tag.ToString()));
            switch (rbtMyTagID)
            {
                case 0:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 1:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 2:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 3:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 4:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 5:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    }
                case 6:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 7:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 8:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 9:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 10:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 11:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 12:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 13:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                case 14:
                    {
                        this.Style = (MetroColorStyle)rbtMyTagID;
                        break;
                    };
                default:
                    {
                        break;
                    };
            };
            this.Tag = rbt.Tag;
            this.Refresh();
        }

        private void metroToggle_Fundo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Theme == MetroThemeStyle.Dark)
            {
                this.Theme = MetroThemeStyle.Light;
                this.mtl_Backgroud.Tag = ("1");
            }
            else if (this.Theme == MetroThemeStyle.Light)
            {
                this.Theme = MetroThemeStyle.Dark;
                this.mtl_Backgroud.Tag = ("2");
            }

            metroPanelColor.Theme = this.Theme;

            //btn
            btnClose.Theme = this.Theme;
            btnSalvar.Theme = this.Theme;
            //rbt
            rbt0.Theme = this.Theme;
            rbt1.Theme = this.Theme;
            rbt2.Theme = this.Theme;
            rbt3.Theme = this.Theme;
            rbt4.Theme = this.Theme;
            rbt5.Theme = this.Theme;
            rbt6.Theme = this.Theme;
            rbt7.Theme = this.Theme;
            rbt8.Theme = this.Theme;
            rbt9.Theme = this.Theme;
            rbt10.Theme = this.Theme;
            rbt11.Theme = this.Theme;
            rbt12.Theme = this.Theme;
            rbt13.Theme = this.Theme;
            rbt14.Theme = this.Theme;

            this.Refresh();
        }

        private void metroButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String themeID = ("");
            themeID = ((String)this.mtl_Backgroud.Tag);
            themeID = MetroThemeStyle.Light == ((MetroThemeStyle)int.Parse(themeID)) ? MetroThemeStyle.Light.ToString() : MetroThemeStyle.Dark.ToString();

            String colorID = ("");
            colorID = ((String)this.Tag);
            colorID = ((MetroColorStyle)int.Parse(colorID)).ToString();

            String msg_Text = string.Format("\r\tFundo:\t{0}" +
                                           "\r\tEstilo:\t{1}" +
                                           "\r\rDeseja Salvar esta Cor Selecionada?", themeID, colorID);

            String msg_Title = (this.Text);

            MessageBoxButtons msg_Buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon msg_Icon = MessageBoxIcon.None;
            MessageBoxDefaultButton msg_ButtonsDefault = MessageBoxDefaultButton.Button1;
            DialogResult msgResult = MetroMessageBox.Show(this, msg_Text, msg_Title, msg_Buttons, msg_Icon, msg_ButtonsDefault);
            if (msgResult == DialogResult.Yes)
            {
                colorID = ("");
                themeID = ("");
                colorID = ((String)this.Tag);
                themeID = ((String)this.mtl_Backgroud.Tag);
                AppConfigXML appConfigXML = new AppConfigXML();
                appConfigXML.SetAppConfigXML("ThemeColorID", themeID);
                appConfigXML.SetAppConfigXML("StyleColorID", colorID);
                this.Close();
            };
        }
    }
}