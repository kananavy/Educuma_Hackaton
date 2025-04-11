using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Educma_Hackaton.models
{

    public partial class pageCours : UserControl
    {

        public event Action<UserControl>? OnUserControlRequested;
        public pageCours()
        {
            InitializeComponent();

        }

        private void boutonAjoutEmploiDuTemps_Click(object sender, EventArgs e)
        {
            OnUserControlRequested?.Invoke(new Educma_Hackaton.models.emploiDuTempCreation());
        }

        private void boutonForum_Click(object sender, EventArgs e)
        {
            OnUserControlRequested?.Invoke(new Educma_Hackaton.models.pageChatGroup());
        }
    }
}
