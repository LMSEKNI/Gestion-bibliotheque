using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MySqlConnector;

namespace Gestion_bibliotheque
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            string num_tel = Num_Tel.Text;
            string age = Age.Text;
            string cin = CIN.Text;
            string pass = Passwordtxt.Text;
            

            if (cin!="" && pass!="")
            {   
                Erreur.Visible = false;

                var connString = "Server=localhost;User ID=root;Password=;Database=biblio";
                var connection = new MySqlConnection(connString);
                try
                {
                    connection.Open();

                    // Insert some data
                    var cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO utilisateur (CIN, Nom, Prenom, Numero_Tel, Age,  Password) VALUES (@cin, @n, @p, @num, @age,  @pass)";
                    cmd.Parameters.AddWithValue("@cin", cin);
                    cmd.Parameters.AddWithValue("@n", nom);
                    cmd.Parameters.AddWithValue("@p", prenom);
                    cmd.Parameters.AddWithValue("@num", num_tel);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur ajouté");
                }
                catch (MySqlException ex) 
                {
                    Console.WriteLine("Error connecting to the database: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }











            }
            else
            {
                Erreur.Visible = true;
            }
        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
