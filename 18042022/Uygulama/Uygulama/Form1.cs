using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OkulEntities con = new OkulEntities();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Listele()
        {
            dataGridView1.DataSource = con.Ogrencilers.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogrenciler ekle = new Ogrenciler();

            ekle.AdSoyad = textBox2.Text;
            ekle.TcNo = textBox3.Text;
            ekle.Telefon = textBox4.Text;
            ekle.Mail = textBox5.Text;
            ekle.Adres = textBox6.Text;
            con.Ogrencilers.Add(ekle);
            con.SaveChanges();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["OgrenciNo"].Value.ToString();
            textBox2.Text = satir.Cells["AdSoyad"].Value.ToString();
            textBox3.Text = satir.Cells["TcNo"].Value.ToString();
            textBox4.Text = satir.Cells["Telefon"].Value.ToString();
            textBox5.Text = satir.Cells["Mail"].Value.ToString();
            textBox6.Text = satir.Cells["Adres"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Ogrenciler yenile = con.Ogrencilers.SingleOrDefault(a => a.OgrenciNo == id);
            yenile.AdSoyad = textBox2.Text;
            yenile.TcNo = textBox3.Text;
            yenile.Telefon = textBox4.Text;
            yenile.Mail = textBox5.Text;
            yenile.Adres = textBox6.Text;
            con.SaveChanges();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Ogrenciler sil = con.Ogrencilers.SingleOrDefault(a => a.OgrenciNo == id);
            con.Ogrencilers.Remove(sil);
            con.SaveChanges();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            Listele();
        }
    }
}
