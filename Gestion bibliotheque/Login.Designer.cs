namespace Gestion_bibliotheque
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CIN = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.CINtxt = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.sinscrire = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CIN
            // 
            this.CIN.AutoSize = true;
            this.CIN.BackColor = System.Drawing.Color.Transparent;
            this.CIN.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIN.ForeColor = System.Drawing.Color.LightSalmon;
            this.CIN.Location = new System.Drawing.Point(7, 28);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(84, 39);
            this.CIN.TabIndex = 0;
            this.CIN.Text = "CIN";
            this.CIN.Click += new System.EventHandler(this.CIN_Click);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.BackColor = System.Drawing.Color.Transparent;
            this.Pass.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.LightSalmon;
            this.Pass.Location = new System.Drawing.Point(7, 79);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(172, 39);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Password";
            this.Pass.Click += new System.EventHandler(this.label2_Click);
            // 
            // CINtxt
            // 
            this.CINtxt.Location = new System.Drawing.Point(273, 37);
            this.CINtxt.Name = "CINtxt";
            this.CINtxt.Size = new System.Drawing.Size(167, 22);
            this.CINtxt.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(273, 94);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(167, 22);
            this.Password.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Chartreuse;
            this.Submit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(394, 222);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(105, 40);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Login";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // sinscrire
            // 
            this.sinscrire.BackColor = System.Drawing.Color.Yellow;
            this.sinscrire.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinscrire.Location = new System.Drawing.Point(203, 222);
            this.sinscrire.Name = "sinscrire";
            this.sinscrire.Size = new System.Drawing.Size(105, 40);
            this.sinscrire.TabIndex = 5;
            this.sinscrire.Text = "S\'inscrire";
            this.sinscrire.UseVisualStyleBackColor = false;
            this.sinscrire.Click += new System.EventHandler(this.sinscrire_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.CINtxt);
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.CIN);
            this.groupBox1.Location = new System.Drawing.Point(29, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 138);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(547, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sinscrire);
            this.Controls.Add(this.Submit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CIN;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox CINtxt;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button sinscrire;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}