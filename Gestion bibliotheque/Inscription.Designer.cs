namespace Gestion_bibliotheque
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.CIN = new System.Windows.Forms.TextBox();
            this.Inscri = new System.Windows.Forms.Button();
            this.Num_Tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Erreur = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Connecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(247, 88);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(200, 22);
            this.Nom.TabIndex = 1;
            this.Nom.TextChanged += new System.EventHandler(this.Nom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(247, 136);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(200, 22);
            this.Prenom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "CIN";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(247, 181);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(200, 22);
            this.Age.TabIndex = 6;
            // 
            // CIN
            // 
            this.CIN.Location = new System.Drawing.Point(247, 272);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(200, 22);
            this.CIN.TabIndex = 7;
            // 
            // Inscri
            // 
            this.Inscri.BackColor = System.Drawing.Color.Yellow;
            this.Inscri.Location = new System.Drawing.Point(529, 193);
            this.Inscri.Name = "Inscri";
            this.Inscri.Size = new System.Drawing.Size(116, 40);
            this.Inscri.TabIndex = 9;
            this.Inscri.Text = "S\'inscrire";
            this.Inscri.UseVisualStyleBackColor = false;
            this.Inscri.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Num_Tel
            // 
            this.Num_Tel.Location = new System.Drawing.Point(247, 228);
            this.Num_Tel.Name = "Num_Tel";
            this.Num_Tel.Size = new System.Drawing.Size(200, 22);
            this.Num_Tel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Num Tel";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Erreur
            // 
            this.Erreur.AutoSize = true;
            this.Erreur.BackColor = System.Drawing.Color.Transparent;
            this.Erreur.Enabled = false;
            this.Erreur.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erreur.ForeColor = System.Drawing.Color.DarkRed;
            this.Erreur.Location = new System.Drawing.Point(584, 262);
            this.Erreur.Name = "Erreur";
            this.Erreur.Size = new System.Drawing.Size(192, 30);
            this.Erreur.TabIndex = 12;
            this.Erreur.Text = "Erreur de saisie";
            this.Erreur.Visible = false;
            this.Erreur.Click += new System.EventHandler(this.label6_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(247, 314);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(200, 22);
            this.Passwordtxt.TabIndex = 14;
            this.Passwordtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(147, 314);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 13;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Connecter
            // 
            this.Connecter.BackColor = System.Drawing.Color.Chartreuse;
            this.Connecter.Location = new System.Drawing.Point(661, 193);
            this.Connecter.Name = "Connecter";
            this.Connecter.Size = new System.Drawing.Size(172, 40);
            this.Connecter.TabIndex = 15;
            this.Connecter.Text = "Se connecter";
            this.Connecter.UseVisualStyleBackColor = false;
            this.Connecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(875, 478);
            this.Controls.Add(this.Connecter);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Erreur);
            this.Controls.Add(this.Num_Tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Inscri);
            this.Controls.Add(this.CIN);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Inscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox CIN;
        private System.Windows.Forms.Button Inscri;
        private System.Windows.Forms.TextBox Num_Tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Erreur;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Connecter;
    }
}

