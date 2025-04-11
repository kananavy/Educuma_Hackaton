using System;
using System.Windows.Forms;

namespace Educma_Hackaton.Design
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
            // Initialisation du Timer
            // timer1.Interval = 50; // Définir un intervalle si nécessaire
            timer1.Start();
            timer1.Tick += timer1_Tick; // Associer l'événement Tick
        }

        // Méthode publique pour obtenir l'état du Timer
        public bool IsTimerRunning()
        {
            return timer1.Enabled;
        }

        // Méthode publique pour obtenir la valeur de ProgressBar
        public int GetProgressBarValue()
        {
            return progressBar2.Value;
        }

        // Méthode publique pour simuler le tick du Timer
        public void SimulateTimerTick()
        {
            timer1_Tick(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value < 100)
            {
                progressBar2.Value += 1;
            }
            else
            {
                while (progressBar2.Visible)
                {
                    timer1.Stop();
                    Connexion loginForm = new Connexion();
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Event handler can be left empty if not needed for tests
        }
    }
}
