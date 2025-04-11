namespace Educma_Hackaton.models
{
    partial class pageChatGroup
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            listBox1 = new ListBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.NoControl;
            listBox1.IntegralHeight = false;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(50, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(743, 417);
            listBox1.TabIndex = 0;
            listBox1.TabStop = false;
            listBox1.UseTabStops = false;
            listBox1.DrawItem += listBox1_DrawItem;
            listBox1.MeasureItem += listBox1_MeasureItem;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.WhiteSmoke;
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(50, 38);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(743, 89);
            guna2Panel1.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Sitka Display", 18F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.OrangeRed;
            guna2HtmlLabel1.Location = new Point(281, 34);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(212, 37);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Groupe de discussions";
            // 
            // pageChatGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(guna2Panel1);
            Controls.Add(listBox1);
            Name = "pageChatGroup";
            Size = new Size(839, 566);
            Load += ChatGroup_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
