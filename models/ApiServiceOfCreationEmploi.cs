using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Educma_Hackaton.models
{
    internal class ApiServiceOfCreationEmploi
    {
        private readonly HttpClient _client;

        public ApiServiceOfCreationEmploi()
        {
            _client = new HttpClient();
        }


        public async Task<bool> CreationEmploiAsync(string idTeach, string univName, string parcours, string niveau, string jour, string heureDeb,
            string heureFin, string mat)
        {
            var Info = new InfoCreationSchedule()
            {
                matiere = mat,
                jour = jour,
                heureStart = heureDeb,
                heureEnd = heureFin,
                idTeacher = idTeach,
                univName = univName,
                parcours = parcours,
                niveau = niveau
            };

            string json = JsonConvert.SerializeObject(Info);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync("http://192.168.43.173:8080/schedule", content);

            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show("Emploi du temps creé avec succès !", "" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Erreur : " + error);
                return false;
            }
        }


        public async Task<string> RecupererGroupeListInfo()
        {
            HttpResponseMessage response = await _client.GetAsync("http://192.168.43.173:8080/auth/teacher/2");
            string? task = "";
            if (response.IsSuccessStatusCode)
            {

                Task<string> tasks = response.Content.ReadAsStringAsync();
                task = await tasks;
                //ChatGroups? newChatGroups = JsonConvert.DeserializeObject<ChatGroups>(task);
                

                //Console.WriteLine(newChatGroups?.chatGroups?[0].groupSubject);
            }
            return task;
           
            
        }

    }
}
