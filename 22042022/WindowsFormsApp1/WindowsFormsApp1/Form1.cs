using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        OkulEntities con = new OkulEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.OG();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["AdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["TcNo"].Value.ToString();
            textBox3.Text = satir.Cells["Telefon"].Value.ToString();
            textBox4.Text = satir.Cells["Mail"].Value.ToString();
            textBox5.Text = satir.Cells["Adres"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler ekle = new Ogrenciler();
            ekle.AdSoyad = textBox1.Text;
            ekle.TcNo = textBox2.Text;
            ekle.Telefon = textBox3.Text;
            ekle.Mail = textBox4.Text;
            ekle.Adres = textBox5.Text;
            con.OAdd(ekle.AdSoyad, ekle.TcNo, ekle.Telefon, ekle.Mail, ekle.Adres);
            con.SaveChanges();
            dataGridView1.DataSource = con.OG().ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            Ogrenciler yenile = new Ogrenciler();
            yenile.AdSoyad = textBox1.Text;
            yenile.TcNo = textBox2.Text;
            yenile.Telefon = textBox3.Text;
            yenile.Mail = textBox4.Text;
            yenile.Adres = textBox5.Text;
            con.OY(id, yenile.AdSoyad, yenile.TcNo, yenile.Telefon, yenile.Mail, yenile.Adres);

        }
    }
}
