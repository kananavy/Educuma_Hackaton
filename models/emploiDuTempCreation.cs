using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Guna.UI2.WinForms;

namespace Educma_Hackaton.models
{
    public partial class emploiDuTempCreation : UserControl
    {
        public emploiDuTempCreation()
        {
            InitializeComponent();
        }

        private async void boutonCreerEmploi_Click(object sender, EventArgs e)
        {
            //Get champ
            string idTeach = "2";
            string universite = Convert.ToString(selectionUniv.Text);
            string parcours = Convert.ToString(selectionParcours.Text);
            string niveau = Convert.ToString(selectionNiveau.Text);
            string jour = Convert.ToString(selectionJour.Text);
            string heureDebut = Convert.ToString(inputHeureDebut.Text);
            string heureFin= Convert.ToString(inputHeureFin.Text);
            string matiere = Convert.ToString(selectionMatiere.Text);

            //Verification champ
            if(string.IsNullOrWhiteSpace(universite) || string.IsNullOrWhiteSpace(parcours) ||
                string.IsNullOrWhiteSpace(niveau) || string.IsNullOrWhiteSpace(jour) ||
                string.IsNullOrWhiteSpace(heureDebut) || string.IsNullOrWhiteSpace(heureFin) || string.IsNullOrWhiteSpace(matiere))
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                ApiServiceOfCreationEmploi apiService = new ApiServiceOfCreationEmploi();
                await apiService.CreationEmploiAsync(idTeach, universite, parcours, niveau, jour, heureDebut, heureFin, matiere);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            



        }
    }
}
