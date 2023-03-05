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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   

            var connString = "Server=localhost;User ID=root;Password=;Database=biblio";
            var connection = new MySqlConnection(connString);
            try
            {
                string cin_in = CINtxt.Text;
                string pass_in = Password.Text;
                connection.Open();
                string query = "SELECT CIN, Password FROM utilisateur WHERE CIN = @cin and Password= @pass";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@cin", cin_in);
                command.Parameters.AddWithValue("@pass", pass_in);

                MySqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    // User is logged in
                    
                    Index Index = new Index();
                    this.Hide();
                    Index.ShowDialog();
                }
                else
                {
                    // User is not logged in
                    MessageBox.Show("Invalid username or password.");
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

        private void CIN_Click(object sender, EventArgs e)
        {

        }

        private void sinscrire_Click(object sender, EventArgs e)
        {
            Inscription inscri = new Inscription();
            this.Hide();
            inscri.ShowDialog();
        }
    }
}
