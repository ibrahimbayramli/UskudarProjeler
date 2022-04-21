using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCenter
{
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
        }

        private void Market_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa a2 = new Anasayfa();
            a2.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa a2 = new Anasayfa();
            a2.Show();
        }
    }
}
