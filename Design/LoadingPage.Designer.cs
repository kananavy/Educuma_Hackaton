namespace Educma_Hackaton.Design
{
    partial class LoadingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            progressBar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(441, 502);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "100%";
            label2.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaShell;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(guna2Panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 378);
            panel1.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackgroundImage = (Image)resources.GetObject("guna2Panel2.BackgroundImage");
            guna2Panel2.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.Location = new Point(301, 170);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(81, 74);
            guna2Panel2.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.CustomizableEdges = customizableEdges3;
            progressBar2.Dock = DockStyle.Bottom;
            progressBar2.FillColor = SystemColors.Control;
            progressBar2.Location = new Point(0, 377);
            progressBar2.Margin = new Padding(4, 3, 4, 3);
            progressBar2.Name = "progressBar2";
            progressBar2.ProgressColor = Color.RoyalBlue;
            progressBar2.ProgressColor2 = Color.RoyalBlue;
            progressBar2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            progressBar2.Size = new Size(702, 21);
            progressBar2.TabIndex = 0;
            progressBar2.Text = "guna2ProgressBar1";
            progressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // LoadingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 398);
            Controls.Add(progressBar2);
            Controls.Add(panel1);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoadingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addprint";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}