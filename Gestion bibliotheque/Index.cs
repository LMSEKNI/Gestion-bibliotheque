using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_bibliotheque
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emprunter empr = new Emprunter();
            this.Hide();
            empr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rendre rend = new Rendre();
            this.Hide();
            rend.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consulter consulter = new Consulter();
            this.Hide();
            consulter.ShowDialog();
        }
    }
}
