using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;



namespace Educma_Hackaton.Design
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void login_signupBtn_Click_1(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public class ReponsLogin
        {
            public int id { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string password { get; set; }
            public string matricule { get; set; }
            public string email { get; set; }
            public string phone { get; set; }

            // Remplacer string[] par une List<ChatGroups>
            public List<ChatGroups> chatGroups { get; set; }
        }

        public class ChatGroups
        {
            public int id { get; set; }
            public string groupName { get; set; }
            public string groupSubject { get; set; }
        }
        public class login  // Changez de 'class' à 'public class'
        {
            public string password { get; set; }
            public string email { get; set; }
        }
        private async void login_btn_Click_1(object sender, EventArgs e)
        {

            string url = "http://192.168.43.173:8080/auth/login";
            using (HttpClient client = new HttpClient())
            {
                var updatedEnsegnent = new login
                {
                    email = Email.Text.Trim(),
                    password = Password.Text.Trim()
                };
                string json = JsonConvert.SerializeObject(updatedEnsegnent);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                Console.WriteLine(content);
                HttpResponseMessage response = await client.PostAsync(url, content);

                string responseContent = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    // Désérialisation de la réponse JSON en objet `Ensegnent`
                    ReponsLogin ensegnent = JsonConvert.DeserializeObject<ReponsLogin>(responseContent);
                    MessageBox.Show($"Matricule : {ensegnent.matricule}", "Connexion Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Educma regForm = new Educma();
                    regForm.Show();
                    this.Hide();
                    Console.WriteLine("Employé mis à jour avec succès !");
                }
                else
                {
                    Console.WriteLine("Erreur lors de la mise à jour !");
                }
            }


        }
    }
}
