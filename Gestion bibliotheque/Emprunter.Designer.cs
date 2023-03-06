namespace Gestion_bibliotheque
{
    partial class Emprunter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emprunter));
            this.empr = new System.Windows.Forms.GroupBox();
            this.emprunter_btn = new System.Windows.Forms.Button();
            this.cin_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.cin_util = new System.Windows.Forms.Label();
            this.id_liv = new System.Windows.Forms.Label();
            this.empr.SuspendLayout();
            this.SuspendLayout();
            // 
            // empr
            // 
            this.empr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empr.BackgroundImage")));
            this.empr.Controls.Add(this.emprunter_btn);
            this.empr.Controls.Add(this.cin_txt);
            this.empr.Controls.Add(this.id_txt);
            this.empr.Controls.Add(this.cin_util);
            this.empr.Controls.Add(this.id_liv);
            this.empr.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empr.ForeColor = System.Drawing.Color.LavenderBlush;
            this.empr.Location = new System.Drawing.Point(106, 114);
            this.empr.Name = "empr";
            this.empr.Size = new System.Drawing.Size(629, 268);
            this.empr.TabIndex = 4;
            this.empr.TabStop = false;
            this.empr.Text = "Emprunter";
            // 
            // emprunter_btn
            // 
            this.emprunter_btn.BackColor = System.Drawing.Color.Cornsilk;
            this.emprunter_btn.ForeColor = System.Drawing.Color.Black;
            this.emprunter_btn.Location = new System.Drawing.Point(342, 215);
            this.emprunter_btn.Name = "emprunter_btn";
            this.emprunter_btn.Size = new System.Drawing.Size(203, 39);
            this.emprunter_btn.TabIndex = 1;
            this.emprunter_btn.Text = "Emprunter";
            this.emprunter_btn.UseVisualStyleBackColor = false;
            this.emprunter_btn.Click += new System.EventHandler(this.emprunter_btn_Click);
            // 
            // cin_txt
            // 
            this.cin_txt.Location = new System.Drawing.Point(260, 134);
            this.cin_txt.Name = "cin_txt";
            this.cin_txt.Size = new System.Drawing.Size(225, 36);
            this.cin_txt.TabIndex = 3;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(260, 55);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(225, 36);
            this.id_txt.TabIndex = 2;
            // 
            // cin_util
            // 
            this.cin_util.AutoSize = true;
            this.cin_util.BackColor = System.Drawing.Color.Transparent;
            this.cin_util.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin_util.ForeColor = System.Drawing.Color.Black;
            this.cin_util.Location = new System.Drawing.Point(65, 134);
            this.cin_util.Name = "cin_util";
            this.cin_util.Size = new System.Drawing.Size(52, 27);
            this.cin_util.TabIndex = 1;
            this.cin_util.Text = "CIN";
            // 
            // id_liv
            // 
            this.id_liv.AutoSize = true;
            this.id_liv.BackColor = System.Drawing.Color.Transparent;
            this.id_liv.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_liv.ForeColor = System.Drawing.Color.Black;
            this.id_liv.Location = new System.Drawing.Point(65, 64);
            this.id_liv.Name = "id_liv";
            this.id_liv.Size = new System.Drawing.Size(95, 27);
            this.id_liv.TabIndex = 0;
            this.id_liv.Text = "ID Livre";
            // 
            // Emprunter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 520);
            this.Controls.Add(this.empr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emprunter";
            this.Text = "Emprunter";
            this.Load += new System.EventHandler(this.Emprunter_Load);
            this.empr.ResumeLayout(false);
            this.empr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox empr;
        private System.Windows.Forms.Button emprunter_btn;
        private System.Windows.Forms.TextBox cin_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label cin_util;
        private System.Windows.Forms.Label id_liv;
    }
}