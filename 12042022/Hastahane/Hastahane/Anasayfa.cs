using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastahane
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poliklinikler p1 = new Poliklinikler();
            p1.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doktorlar d1 = new Doktorlar();
            d1.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hastalar h1 = new Hastalar();
            h1.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receteler r1 = new Receteler();
            r1.Show();
        }

    }
}
