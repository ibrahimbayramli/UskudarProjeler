using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama6
{
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
            
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;

            if (comboBox3.Text == "Evet")
            {
                groupBox2.Visible = true;

            }
            else
            {
                groupBox2.Visible = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fiyat = 0;
            Form1 f1 = new Form1();
            
            string musteriAdi = f1.textBox1.Text;
            string musteriSoyadi = f1.textBox2.Text;
            string odemeSekli = f1.comboBox1.Text;
            string siparisNo = f1.textBox4.Text;

            
        }
    }
}
