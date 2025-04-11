using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using Microsoft.CSharp;


namespace Educma_Hackaton.Design
{
    public partial class RegisterForm : Form
    {
        private static readonly string BaseUrl = "http://192.168.43.173:8080";
        private HttpClient client = new HttpClient();
        private string selectedImagePath = "";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void signup_btn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signup_name.Text) || string.IsNullOrWhiteSpace(signup_password.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUser = new Register
            {
                name = signup_name.Text.Trim(),
                surname = signup_username.Text.Trim(),
                password = signup_password.Text.Trim(),
                matricule = signup_matricul.Text.Trim(),
                email = signup_mail.Text.Trim(),
                phone = signup_contact.Text.Trim()
            };

            Task.Run(async () =>
            {
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    string imageUrl = await UploadImageAsync(selectedImagePath);
                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        newUser.pictureUri = imageUrl;
                    }
                }
                await RegisterUserAsync(newUser);
            });
        }

        private async Task<string> UploadImageAsync(string imagePath)
        {
            string uploadUrl = $"{BaseUrl}/file/";

            using (var formData = new MultipartFormDataContent())
            {
                using (var imageStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    var imageContent = new StreamContent(imageStream);
                    imageContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                    formData.Add(imageContent, "file", Path.GetFileName(imagePath));

                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(uploadUrl, formData);
                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            dynamic result = JsonConvert.DeserializeObject(jsonResponse);
                            MessageBox.Show($"Erreur HTTP : {result.viewUrl}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return result.viewUrl;

                        }
                        else
                        {
                            MessageBox.Show($"Erreur HTTP : {response.StatusCode}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur d'upload : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return "";
        }


        private async Task RegisterUserAsync(Register newUser)
        {
            string apiUrl = $"{BaseUrl}/auth/register/teacher";
            string json = JsonConvert.SerializeObject(newUser);
            var jsonContent = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync(apiUrl, jsonContent);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Utilisateur enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEmployee_importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;
                addEmployee_picture.ImageLocation = selectedImagePath;
            }
        }
    }

    public class Register
    {
        internal string profilePicture;

        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string matricule { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string pictureUri { get; set; } // URL de l'image après upload
    }
}
