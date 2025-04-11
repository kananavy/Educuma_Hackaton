using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Educma_Hackaton.models
{
    public partial class pageChatGroup : UserControl
    {
        public pageChatGroup()
        {
            InitializeComponent();
        }

        public event Action<UserControl>? OnUserControlRequested;//add



        private async void ChatGroup_Load(object? sender, EventArgs e)
        {
            UserControl? pageSender = sender as UserControl;
            try
            {
                ApiServiceOfCreationEmploi apiService2 = new ApiServiceOfCreationEmploi();
                string res = await apiService2.RecupererGroupeListInfo();
                ChatGroups? newChatGroups = JsonConvert.DeserializeObject<ChatGroups>(res);



                for (int i = 0; i < newChatGroups?.chatGroups?.Length; i++)
                {
                    string itemsText = $"          \n         {newChatGroups?.chatGroups[i].groupSchool} {newChatGroups?.chatGroups[i].groupLevel} {newChatGroups?.chatGroups[i].groupDepartment}";
                    foreach (Control ctrl in pageSender.Controls)
                    {
                        if (ctrl == listBox1)
                        {
                            listBox1.Items.Add(itemsText);
                        }
                    }

                    //pageSender?.Controls.Add();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 60;
        }
        //add
        private void listBox_1_Click(object sender, EventArgs e)
        {
            OnUserControlRequested?.Invoke(new Educma_Hackaton.models.Attendance());
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();

            Brush textBrush = new SolidBrush(e.ForeColor);

            string? itemText = listBox1.Items[e.Index].ToString();

            Size textSize = TextRenderer.MeasureText(itemText, new Font("Arial", 12, FontStyle.Bold));
            int y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;


            e.Graphics.DrawString(itemText, new Font("Calibri", 12), textBrush, e.Bounds);

            e.DrawFocusRectangle();
        }
    }
}
