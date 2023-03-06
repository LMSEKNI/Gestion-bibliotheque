using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Gestion_bibliotheque
{
    public partial class recherche : Form
    {
        public recherche()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            var connString = "Server=localhost;User ID=root;Password=;Database=biblio";
            var connection = new MySqlConnection(connString);
            try
            {
                this.res.Visible = false;
                this.empr.Visible= false;
                string titre = "%"+titre_txt.Text +"%";
                string auteur = "%"+auteur_txt.Text +"%";
                connection.Open();
                string query = "SELECT * FROM livres WHERE Titre LIKE @titre And Auteur LIKE @aut";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@titre", titre);
                command.Parameters.AddWithValue("@aut", auteur);

                MySqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    this.res.Visible= true;
                    this.empr.Visible= true;    

                    this.res.Rows.Clear();
                    while (reader.Read())
                    {
                        this.res.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }

                    reader.Close();

                }
                else
                {
                    // User is not logged in
                    MessageBox.Show("Ce livre n'existe pas !");
                }

                reader.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Emprunter empr = new Emprunter();
            this.Hide();
            empr.ShowDialog();
        }

        private void res_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
