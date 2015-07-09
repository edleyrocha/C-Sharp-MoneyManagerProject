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
    using MetroFramework;
    using MetroFramework.Forms;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    #endregion

    public partial class FrmCategories : MetroForm
    {
        public FrmCategories(Chose.ActionForm ChoseAction)
        {
            this.InitializeComponent();
            this.SelectedAction = (ChoseAction);
            this.SetConfigStartUsers();
        }

        #region ---> (Form Categories)

        Chose.ActionForm SelectedAction;

        private void SetConfigStartUsers()
        {
            this.Text = ("Categorias");
            this.mtcCategories.TabPages.Clear();
            switch (SelectedAction)
            {
                case (Chose.ActionForm.ActionSelect):
                    {
                        this.Size = (new Size(535, 330));
                        this.mtcCategories.Size = (new Size(490, 280));
                        this.mtcCategories.TabPages.Add(this.mtpSelect);
                        this.mtpSelect.Text = (String.Format(("{0} {1} {2}"), ("Listar"), (this.Text), ("                                                                                                            ")));
                        this.imgSelect.Text = ("");

                        this.lblCoutSelect.Text = (this.imgSelect.Text);
                        this.lblGridSelect.Text = (this.imgSelect.Text);

                        this.cbxSelect.Location = (new Point(322, 139));
                        this.btnSelect.Location = (new Point(322, 174));
                        this.btnCloseSelect.Location = (new Point(403, 174));

                        break;
                    };
                case (Chose.ActionForm.ActionInsert):
                    {
                        this.Size = (new Size(535, 330));
                        this.mtcCategories.Size = (new Size(490, 280));
                        this.mtcCategories.TabPages.Add(this.mtpSelect);
                        this.mtpSelect.Text = (String.Format(("{0} {1} {2}"), ("Adicionar"), (this.Text), ("                                                                                                            ")));
                        this.imgSelect.Text = ("");

                        this.lblCoutSelect.Text = (this.imgSelect.Text);
                        this.lblGridSelect.Text = (this.imgSelect.Text);

                        this.cbxSelect.Dispose();


                        break;
                    };
                case (Chose.ActionForm.ActionUpdate):
                    {
                        this.Size = (new Size(535, 300));
                        this.mtcCategories.Size = (new Size(490, 250));
                        this.mtcCategories.TabPages.Add(this.mtpUpdate);
                        this.mtpSelect.Text = (String.Format(("{0} {1} {2}"), ("Atualizar"), (this.Text), ("                                                                                                            ")));

                        break;
                    };
                case (Chose.ActionForm.ActionDelete):
                    {
                        this.Size = (new Size(535, 300));
                        this.mtcCategories.Size = (new Size(490, 250));
                        this.mtcCategories.TabPages.Add(this.mtpDelete);
                        this.mtpSelect.Text = (String.Format(("{0} {1} {2}"), ("Deletar"), (this.Text), ("                                                                                                            ")));

                        break;
                    };
                case (Chose.ActionForm.ActionRestore):
                    {
                        this.Size = (new Size(535, 300));
                        this.mtcCategories.Size = (new Size(490, 250));
                        this.mtcCategories.TabPages.Add(this.mtpRestore);
                        this.mtpSelect.Text = (String.Format(("{0} {1} {2}"), ("Restaurar"), (this.Text), ("                                                                                                            ")));

                        break;
                    };
            };
            this.mtcCategories.ResumeLayout();
        }
        #endregion

        private void btnCloseSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            cbxSelect.Dispose();
        }
    }
}