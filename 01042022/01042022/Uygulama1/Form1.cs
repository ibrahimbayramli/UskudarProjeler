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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string sifre = textBox2.Text;
            if(kadi=="admin" && sifre == "12345")
            {
                MessageBox.Show($"Giriş başarılı. Hoşgeldiniz Sayın {kadi}");
                Admin ad = new Admin();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız. Tekrar deneyiniz.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
