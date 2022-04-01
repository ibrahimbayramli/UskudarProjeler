using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama5
{
    public partial class Apartman : Form
    {
        public Apartman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bilgiler b1 = new Bilgiler();
            b1.Show();
            b1.listBox1.Items.Add($"Apartman adı: {textBox1.Text}");
            b1.listBox1.Items.Add("");
            b1.listBox1.Items.Add($"Apartman no: {textBox2.Text}");
            b1.listBox1.Items.Add("");
            b1.listBox1.Items.Add($"Kat sayısı: {textBox3.Text}");
            b1.listBox1.Items.Add("");
            b1.listBox1.Items.Add($"Oda sayısı: {textBox1.Text}");
            b1.listBox1.Items.Add("");
            b1.listBox1.Items.Add($"Fiyat: {textBox1.Text}");

        }
    }
}
