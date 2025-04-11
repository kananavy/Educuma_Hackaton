using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educma_Hackaton.Design
{
    public partial class Educma : Form
    {


        public Educma()
        {
            InitializeComponent();
        }


        private void boutonQuitter_Click(object sender, EventArgs e)
        {
            DialogResult reponseMessageBox = MessageBox.Show("Ëtes-vous sûre de vouloir quitter ?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reponseMessageBox == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void PaintToDeepSkyBlueTheBtn(Guna.UI2.WinForms.Guna2Button? btn)
        {
            if (btn != null)
            {
                if (btn.FillColor != Color.DeepSkyBlue)
                {
                    foreach (Guna.UI2.WinForms.Guna2Button otherBtn in panelLeft.Controls)
                    {
                        if (otherBtn.FillColor == Color.DeepSkyBlue)
                        {
                            otherBtn.FillColor = Color.Transparent;
                            otherBtn.ForeColor = Color.Black;
                            otherBtn.BackColor = Color.Transparent;

                        }
                    }

                    btn.FillColor = Color.DeepSkyBlue;
                    btn.ForeColor = Color.White;
                }
            }
        }

        private void LoadPageOfPanelContainer(UserControl page)
        {
            panelContainerPage.Controls.Clear();
            panelContainerPage.Controls.Add(page);
        }


        private void menuCourses_Click(object? sender, EventArgs e)
        {

            Guna.UI2.WinForms.Guna2Button? btnCours = sender as Guna.UI2.WinForms.Guna2Button;
            PaintToDeepSkyBlueTheBtn(btnCours);
            panelContainerPage.Controls.Clear();
            Educma_Hackaton.models.pageCours pageCourses = new Educma_Hackaton.models.pageCours();

            pageCourses.OnUserControlRequested += HandleUserControlChange;

            panelContainerPage.Controls.Add(pageCourses);

        }

        private void HandleUserControlChange(UserControl uc)
        {
            panelContainerPage.Controls.Clear();
            panelContainerPage.Controls.Add(uc);

            //if(uc is )

        }

        private void menuDashboard_Click(object? sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button? btnDashboard = sender as Guna.UI2.WinForms.Guna2Button;
            PaintToDeepSkyBlueTheBtn(btnDashboard);
            LoadPageOfPanelContainer(new Educma_Hackaton.models.pageDashboard());
        }

        private void menuEmploiDuTemps_Click(object? sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button? btnEmploi = sender as Guna.UI2.WinForms.Guna2Button;
            PaintToDeepSkyBlueTheBtn(btnEmploi);
            LoadPageOfPanelContainer(new Educma_Hackaton.models.pageEmploisDuTemps());
        }

        private void menuGestionNotes_Click(object? sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button? btnGestionNotes = sender as Guna.UI2.WinForms.Guna2Button;
            PaintToDeepSkyBlueTheBtn(btnGestionNotes);
            LoadPageOfPanelContainer(new Educma_Hackaton.models.GestionDesNote());

        }

        private void Deconnexion_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.DeepSkyBlue;
            Connexion regForm = new Connexion();
            regForm.Show();
            this.Hide();
        }
    }

}
