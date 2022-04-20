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
        MalzemelerContainer baglanti = new MalzemelerContainer();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             dataGridView1.DataSource = baglanti.Malzeme.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Malzeme ekle = new Malzeme();
            ekle.MalzemeAdi = textBox2.Text;
            ekle.MalzemeAdet = Convert.ToInt32(textBox3.Text);
            ekle.MalzemeFiyat = Convert.ToDecimal(textBox4.Text);
            ekle.MalzemeDepoAdi = textBox5.Text;
            baglanti.Malzeme.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.Malzeme.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Tag = satir.Cells["MalzemeId"].Value.ToString();
            textBox2.Text = satir.Cells["MalzemeAdi"].Value.ToString();
            textBox3.Text = satir.Cells["MalzemeAdet"].Value.ToString();
            textBox4.Text = satir.Cells["MalzemeFiyat"].Value.ToString();
            textBox5.Text = satir.Cells["MalzemeDepoAdi"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Tag);
            Malzeme yenile = baglanti.Malzeme.SingleOrDefault(c => c.MalzemeId == id);
            yenile.MalzemeAdi = textBox2.Text;
            yenile.MalzemeAdet = Convert.ToInt32(textBox3.Text);
            yenile.MalzemeFiyat = Convert.ToDecimal(textBox4.Text);
            yenile.MalzemeDepoAdi = textBox5.Text;
            
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.Malzeme.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Tag);
            Malzeme sil = baglanti.Malzeme.SingleOrDefault(c => c.MalzemeId == id);
            baglanti.Malzeme.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.Malzeme.ToList();
        }
    }
}
