namespace Gestion_bibliotheque
{
    partial class Consulter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulter));
            this.Affichage = new System.Windows.Forms.DataGridView();
            this.lister = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Affichage)).BeginInit();
            this.SuspendLayout();
            // 
            // Affichage
            // 
            this.Affichage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Affichage.BackgroundColor = System.Drawing.Color.Tan;
            this.Affichage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Affichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Affichage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titre,
            this.Auteur,
            this.Prix,
            this.Pages,
            this.Quantite_Disponible});
            this.Affichage.Location = new System.Drawing.Point(118, 39);
            this.Affichage.Name = "Affichage";
            this.Affichage.RowHeadersWidth = 51;
            this.Affichage.RowTemplate.Height = 24;
            this.Affichage.Size = new System.Drawing.Size(820, 357);
            this.Affichage.TabIndex = 0;
            this.Affichage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lister
            // 
            this.lister.Location = new System.Drawing.Point(967, 441);
            this.lister.Name = "lister";
            this.lister.Size = new System.Drawing.Size(105, 44);
            this.lister.TabIndex = 1;
            this.lister.Text = "Lister livres";
            this.lister.UseVisualStyleBackColor = true;
            this.lister.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Titre";
            this.Titre.MinimumWidth = 6;
            this.Titre.Name = "Titre";
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.MinimumWidth = 6;
            this.Auteur.Name = "Auteur";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            // 
            // Pages
            // 
            this.Pages.HeaderText = "Pages";
            this.Pages.MinimumWidth = 6;
            this.Pages.Name = "Pages";
            // 
            // Quantite_Disponible
            // 
            this.Quantite_Disponible.HeaderText = "Quantité disponible";
            this.Quantite_Disponible.MinimumWidth = 6;
            this.Quantite_Disponible.Name = "Quantite_Disponible";
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(804, 441);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(103, 44);
            this.rechercher.TabIndex = 2;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = true;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // Consulter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1147, 524);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.lister);
            this.Controls.Add(this.Affichage);
            this.Name = "Consulter";
            this.Text = "Consulter";
            ((System.ComponentModel.ISupportInitialize)(this.Affichage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Affichage;
        private System.Windows.Forms.Button lister;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite_Disponible;
        private System.Windows.Forms.Button rechercher;
    }
}