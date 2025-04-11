using System;
using System.Drawing;
using System.Windows.Forms;


namespace Educma_Hackaton.models
{
    public partial class pageEmploisDuTemps : UserControl
    {
        public pageEmploisDuTemps()
        {
            InitializeComponent();
            this.Size = new Size(839, 566); // Taille fixe
            GenererEmploiDuTemps();
        }
        // Exemple de données
        List<EmploiDuTemps> emplois = new List<EmploiDuTemps>
{
    new EmploiDuTemps("Algo", "07:00:00", "09:00:00", "Jeudi", "ISSTM", "Genie informatique", "M1"),
    //new EmploiDuTemps("Maths", "10:00:00", "12:00:00", "Lundi", "Educma", "Mathématiques", "Master"),
};


        public class EmploiDuTemps
        {
            public string Subject { get; set; }        // Matière
            public string Start { get; set; }          // Heure de début
            public string End { get; set; }            // Heure de fin
            public string Day { get; set; }            // Jour
            public string School { get; set; }         // École
            public string Department { get; set; }     // Département
            public string Level { get; set; }          // Niveau

            public EmploiDuTemps(string subject, string start, string end, string day, string school, string department, string level)
            {
                Subject = subject;
                Start = start;
                End = end;
                Day = day;
                School = school;
                Department = department;
                Level = level;
            }

            public override string ToString()
            {
                return $"{Day}: {Subject} de {Start} à {End} ({School} - {Department} - {Level})";
            }
        }

        private void GenererEmploiDuTemps()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 12, // 11 créneaux horaires + entête
                ColumnCount = 8, // 7 jours + entête
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                AutoSize = true
            };

            // Ajuster la largeur des colonnes pour optimiser l'affichage
            for (int i = 0; i < 8; i++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, i == 0 ? 15F : 12F));

            // Ajuster la hauteur des lignes
            for (int i = 0; i < 12; i++)
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.5F));

            this.Controls.Add(tableLayoutPanel);

            // Ajouter les entêtes des colonnes (jours)
            string[] jours = { "", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            for (int i = 0; i < jours.Length; i++)
            {
                Label label = new Label
                {
                    Text = jours[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.RoyalBlue,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    Margin = new Padding(2)
                };
                tableLayoutPanel.Controls.Add(label, i, 0);
            }

            // Ajouter les horaires en première colonne
            int heureDebut = 7;
            for (int i = 1; i <= 11; i++)
            {
                int heureFin = heureDebut + 1;
                Label label = new Label
                {
                    Text = $"{heureDebut}h - {heureFin}h",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 9, FontStyle.Regular),
                    BackColor = Color.RoyalBlue
                };
                tableLayoutPanel.Controls.Add(label, 0, i);
                heureDebut++;
            }

            // Remplir la table avec les matières aux bons emplacements
            for (int j = 1; j < jours.Length; j++) // Pour chaque jour de la semaine
            {
                for (int i = 1; i <= 11; i++) // Pour chaque créneau horaire
                {
                    int heureActuelle = 7 + (i - 1);

                    var emploi = emplois.FirstOrDefault(e =>
                        int.Parse(e.Start.Split(':')[0]) == heureActuelle && e.Day == jours[j]);

                    if (emploi != null)
                    {
                        // Calculer la durée en heures du cours
                        int heureDebutEmploi = int.Parse(emploi.Start.Split(':')[0]);
                        int heureFin = int.Parse(emploi.End.Split(':')[0]);
                        int duree = heureFin - heureDebutEmploi; // Nombre de cases à fusionner

                        // Vérifier si une case n'est pas déjà occupée (éviter les doublons)
                        bool dejaAjoute = tableLayoutPanel.GetControlFromPosition(j, i) != null;
                        if (dejaAjoute) continue;

                        // Créer le bouton du cours
                        Button btn = new Button
                        {
                            Text = $"{emploi.Subject}\n{emploi.School} - {emploi.Department} - {emploi.Level}",
                            Dock = DockStyle.Fill,
                            Font = new Font("Arial", 8, FontStyle.Bold),
                            BackColor = Color.White,
                            ForeColor = Color.Black
                        };

                        // Ajouter le bouton à la cellule
                        tableLayoutPanel.Controls.Add(btn, j, i);

                        // Fusionner les cellules pour couvrir toute la durée
                        tableLayoutPanel.SetRowSpan(btn, duree);
                    }
                    else
                    {
                        // Vérifier si la cellule est déjà fusionnée par un autre cours
                        if (tableLayoutPanel.GetControlFromPosition(j, i) == null)
                        {
                            Label emptyCell = new Label
                            {
                                Text = "", // Case vide
                                Dock = DockStyle.Fill,
                                Font = new Font("Arial", 8, FontStyle.Regular),
                                BackColor = Color.White
                            };
                            tableLayoutPanel.Controls.Add(emptyCell, j, i);
                        }
                    }
                }
            }




        }
    }
}

 