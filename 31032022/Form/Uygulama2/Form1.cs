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

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            button5.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int topla = sayi1 + sayi2;
            button5.Text = Convert.ToString(topla) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int topla = sayi1 - sayi2;
            button5.Text = Convert.ToString(topla);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int topla = sayi1 * sayi2;
            button5.Text = Convert.ToString(topla);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int topla = sayi1 / sayi2;
            button5.Text = Convert.ToString(topla);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            button5.Visible = false;
            textBox1.Text = " ";
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menuler git = new Menuler();
            git.Show();
            this.Hide();
        }
    }
}
