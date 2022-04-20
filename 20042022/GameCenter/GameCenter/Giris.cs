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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) groupBox2.Visible = true;
            else groupBox2.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;

        }
    }
}
