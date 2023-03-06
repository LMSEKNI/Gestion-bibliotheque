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
    public partial class Rendre : Form
    {
        public Rendre()
        {
            InitializeComponent();
        }

        private void emprunter_btn_Click(object sender, EventArgs e)
        {
            var connString = "Server=localhost;User ID=root;Password=;Database=biblio";
            var connection = new MySqlConnection(connString);
            try
            {
                
                string id = idrend_txt.Text;
                string cin = cinrend_txt.Text;
                connection.Open();
                string query = "DELETE FROM emprunter WHERE id_livres = @id AND CIN = @cin"+
                "UPDATE livres SET Quantite disponible = Quantite disponible + 1 WHERE id_livres = @id";

                MySqlCommand command = new MySqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@cin", cin);
                command.ExecuteNonQuery();
                MessageBox.Show("Livre rendu!");





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
    }
    
}
