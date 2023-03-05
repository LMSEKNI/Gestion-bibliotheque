namespace Gestion_bibliotheque
{
    partial class recherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recherche));
            this.rech = new System.Windows.Forms.GroupBox();
            this.rechercher = new System.Windows.Forms.Button();
            this.auteur_txt = new System.Windows.Forms.TextBox();
            this.titre_txt = new System.Windows.Forms.TextBox();
            this.auteur = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empr = new System.Windows.Forms.Button();
            this.rech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.res)).BeginInit();
            this.SuspendLayout();
            // 
            // rech
            // 
            this.rech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rech.BackgroundImage")));
            this.rech.Controls.Add(this.rechercher);
            this.rech.Controls.Add(this.auteur_txt);
            this.rech.Controls.Add(this.titre_txt);
            this.rech.Controls.Add(this.auteur);
            this.rech.Controls.Add(this.titre);
            this.rech.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rech.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rech.Location = new System.Drawing.Point(25, 12);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(581, 260);
            this.rech.TabIndex = 0;
            this.rech.TabStop = false;
            this.rech.Text = "Rechercher";
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.Cornsilk;
            this.rechercher.ForeColor = System.Drawing.Color.Black;
            this.rechercher.Location = new System.Drawing.Point(342, 215);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(203, 39);
            this.rechercher.TabIndex = 1;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // auteur_txt
            // 
            this.auteur_txt.Location = new System.Drawing.Point(260, 134);
            this.auteur_txt.Name = "auteur_txt";
            this.auteur_txt.Size = new System.Drawing.Size(225, 36);
            this.auteur_txt.TabIndex = 3;
            // 
            // titre_txt
            // 
            this.titre_txt.Location = new System.Drawing.Point(260, 55);
            this.titre_txt.Name = "titre_txt";
            this.titre_txt.Size = new System.Drawing.Size(225, 36);
            this.titre_txt.TabIndex = 2;
            // 
            // auteur
            // 
            this.auteur.AutoSize = true;
            this.auteur.BackColor = System.Drawing.Color.Transparent;
            this.auteur.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteur.ForeColor = System.Drawing.Color.Black;
            this.auteur.Location = new System.Drawing.Point(65, 134);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(76, 27);
            this.auteur.TabIndex = 1;
            this.auteur.Text = "Auteur";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.Transparent;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.Black;
            this.titre.Location = new System.Drawing.Point(65, 64);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(57, 27);
            this.titre.TabIndex = 0;
            this.titre.Text = "Titre";
            this.titre.Click += new System.EventHandler(this.label1_Click);
            // 
            // res
            // 
            this.res.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.res.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.res.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.res.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Prix,
            this.Pages,
            this.Quantite_Disponible});
            this.res.Location = new System.Drawing.Point(25, 310);
            this.res.Name = "res";
            this.res.RowHeadersWidth = 51;
            this.res.RowTemplate.Height = 24;
            this.res.Size = new System.Drawing.Size(593, 211);
            this.res.TabIndex = 2;
            this.res.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Auteur";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // empr
            // 
            this.empr.Location = new System.Drawing.Point(776, 252);
            this.empr.Name = "empr";
            this.empr.Size = new System.Drawing.Size(164, 57);
            this.empr.TabIndex = 3;
            this.empr.Text = "Emprunter";
            this.empr.UseVisualStyleBackColor = true;
            this.empr.Visible = false;
            this.empr.Click += new System.EventHandler(this.button1_Click);
            // 
            // recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1040, 554);
            this.Controls.Add(this.empr);
            this.Controls.Add(this.res);
            this.Controls.Add(this.rech);
            this.Name = "recherche";
            this.Text = "recherche";
            this.rech.ResumeLayout(false);
            this.rech.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.res)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rech;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label auteur;
        private System.Windows.Forms.TextBox auteur_txt;
        private System.Windows.Forms.TextBox titre_txt;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.DataGridView res;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite_Disponible;
        private System.Windows.Forms.Button empr;
    }
}