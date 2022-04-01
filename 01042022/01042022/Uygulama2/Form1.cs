using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float maas = Convert.ToSingle(textBox1.Text);
            float mesaiSaati = Convert.ToSingle(textBox2.Text);
            float mesaiUcreti = Convert.ToSingle(textBox3.Text);
            float ucret = maas + mesaiSaati * mesaiUcreti;

            listBox1.Items.Add($"Hakedişiniz: {ucret}");
        }
    }
}
