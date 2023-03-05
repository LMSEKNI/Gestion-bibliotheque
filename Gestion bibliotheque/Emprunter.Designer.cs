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
            this.res = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empr = new System.Windows.Forms.GroupBox();
            this.emprunter_btn = new System.Windows.Forms.Button();
            this.cin_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.cin_util = new System.Windows.Forms.Label();
            this.id_liv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.res)).BeginInit();
            this.empr.SuspendLayout();
            this.SuspendLayout();
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
            this.res.Location = new System.Drawing.Point(22, 12);
            this.res.Name = "res";
            this.res.RowHeadersWidth = 51;
            this.res.RowTemplate.Height = 24;
            this.res.Size = new System.Drawing.Size(593, 211);
            this.res.TabIndex = 3;
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
            this.empr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empr.BackgroundImage")));
            this.empr.Controls.Add(this.emprunter_btn);
            this.empr.Controls.Add(this.cin_txt);
            this.empr.Controls.Add(this.id_txt);
            this.empr.Controls.Add(this.cin_util);
            this.empr.Controls.Add(this.id_liv);
            this.empr.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empr.ForeColor = System.Drawing.Color.LavenderBlush;
            this.empr.Location = new System.Drawing.Point(22, 229);
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
            this.ClientSize = new System.Drawing.Size(864, 520);
            this.Controls.Add(this.empr);
            this.Controls.Add(this.res);
            this.Name = "Emprunter";
            this.Text = "Emprunter";
            ((System.ComponentModel.ISupportInitialize)(this.res)).EndInit();
            this.empr.ResumeLayout(false);
            this.empr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView res;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite_Disponible;
        private System.Windows.Forms.GroupBox empr;
        private System.Windows.Forms.Button emprunter_btn;
        private System.Windows.Forms.TextBox cin_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label cin_util;
        private System.Windows.Forms.Label id_liv;
    }
}