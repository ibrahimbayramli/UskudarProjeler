using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void bankaHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KH kh1 = new KH();
            kh1.Show();
            this.Hide();
        }

        private void kullanıcıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KK k1 = new KK();
            k1.Show();
            this.Hide();
        }
    }
}
