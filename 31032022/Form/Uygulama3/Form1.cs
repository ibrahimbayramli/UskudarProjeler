using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();

                Form2 f2 = new Form2();
                f2.Show();

            }
            else
            {
                MessageBox.Show("Giriş başarısız. Tekrar giriniz.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
