using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Educma_Hackaton.models
{
    public partial class Attendance : UserControl
    {
        

        public Attendance()
        {
            InitializeComponent();
            RefreshData();

        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
        }
    }
}
