using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Gestion_bibliotheque
{
    public partial class Emprunter : Form
    {
        public Emprunter()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void emprunter_btn_Click(object sender, EventArgs e)
        {

            var connString = "Server=localhost;User ID=root;Password=;Database=biblio";
            var connection = new MySqlConnection(connString);
            try
            {
                connection.Open();

                this.empr.Visible = false;
                string id = id_txt.Text;
                string cin = cin_txt.Text;
                
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO emprunter (CIN, id_Livres, Date_empr) VALUES (@cin, @id,CURDATE());UPDATE livres SET Quantite disponible = Quantite disponible - 1 WHERE id_livres = @id";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@cin", cin);
                command.ExecuteNonQuery();
                MessageBox.Show("Livre Emprunté!");
                





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

        private void Emprunter_Load(object sender, EventArgs e)
        {
            
        }
    }
}
