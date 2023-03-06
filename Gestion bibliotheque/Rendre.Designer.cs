namespace Gestion_bibliotheque
{
    partial class Rendre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rendre));
            this.rend = new System.Windows.Forms.GroupBox();
            this.rendre_btn = new System.Windows.Forms.Button();
            this.cinrend_txt = new System.Windows.Forms.TextBox();
            this.idrend_txt = new System.Windows.Forms.TextBox();
            this.cin_util = new System.Windows.Forms.Label();
            this.id_liv = new System.Windows.Forms.Label();
            this.rend.SuspendLayout();
            this.SuspendLayout();
            // 
            // rend
            // 
            this.rend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rend.BackgroundImage")));
            this.rend.Controls.Add(this.rendre_btn);
            this.rend.Controls.Add(this.cinrend_txt);
            this.rend.Controls.Add(this.idrend_txt);
            this.rend.Controls.Add(this.cin_util);
            this.rend.Controls.Add(this.id_liv);
            this.rend.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rend.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rend.Location = new System.Drawing.Point(86, 91);
            this.rend.Name = "rend";
            this.rend.Size = new System.Drawing.Size(629, 268);
            this.rend.TabIndex = 5;
            this.rend.TabStop = false;
            this.rend.Text = "Rendre Livre";
            // 
            // rendre_btn
            // 
            this.rendre_btn.BackColor = System.Drawing.Color.Cornsilk;
            this.rendre_btn.ForeColor = System.Drawing.Color.Black;
            this.rendre_btn.Location = new System.Drawing.Point(342, 215);
            this.rendre_btn.Name = "rendre_btn";
            this.rendre_btn.Size = new System.Drawing.Size(203, 39);
            this.rendre_btn.TabIndex = 1;
            this.rendre_btn.Text = "Rendre";
            this.rendre_btn.UseVisualStyleBackColor = false;
            this.rendre_btn.Click += new System.EventHandler(this.emprunter_btn_Click);
            // 
            // cinrend_txt
            // 
            this.cinrend_txt.Location = new System.Drawing.Point(260, 134);
            this.cinrend_txt.Name = "cinrend_txt";
            this.cinrend_txt.Size = new System.Drawing.Size(225, 36);
            this.cinrend_txt.TabIndex = 3;
            // 
            // idrend_txt
            // 
            this.idrend_txt.Location = new System.Drawing.Point(260, 55);
            this.idrend_txt.Name = "idrend_txt";
            this.idrend_txt.Size = new System.Drawing.Size(225, 36);
            this.idrend_txt.TabIndex = 2;
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
            // Rendre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rendre";
            this.Text = "Rendre";
            this.rend.ResumeLayout(false);
            this.rend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rend;
        private System.Windows.Forms.Button rendre_btn;
        private System.Windows.Forms.TextBox cinrend_txt;
        private System.Windows.Forms.TextBox idrend_txt;
        private System.Windows.Forms.Label cin_util;
        private System.Windows.Forms.Label id_liv;
    }
}