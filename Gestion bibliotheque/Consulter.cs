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
using MySqlConnector;

namespace Gestion_bibliotheque
{
    public partial class Consulter : Form
    {
        public Consulter()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            // Establish a connection to the MySQL database
            var connString = "Server=localhost;User ID=root;Password=;Database=biblio";
            MySqlConnection connection = new MySqlConnection(connString);

            //Display all the books


            try
                {
                    connection.Open();

                    // Select all rows and columns from the variables table
                    string query = "SELECT * FROM livres";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows == true) 
                {
                    this.Affichage.Rows.Clear();
                    while (reader.Read())
                    {
                        this.Affichage.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("La Bibliotheques est vide !");
                }
                    
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

        private void rechercher_Click(object sender, EventArgs e)
        {
            recherche recherche = new recherche();
            this.Hide();
            recherche.ShowDialog();
        }
    }
    
}
