using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-MO5HLC4\\SQLEXPRESS;Database=Pastane;Integrated Security=true");
        public void Listele(string baglan)
        {
            SqlDataAdapter dr = new SqlDataAdapter(baglan, baglanti);
            DataSet doldur = new DataSet();
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele("Select * From Urunler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Urunler (UrunAdi,UrunFiyat,KullanimTarihi,UretimTarihi,SaticiNo) values (@UrunAdi,@UrunFiyat,@KullanimTarihi,@UretimTarihi,@SaticiNo)", baglanti);
            komut.Parameters.AddWithValue("@UrunAdi", textBox2.Text);
            komut.Parameters.AddWithValue("@UrunFiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@KullanimTarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@UretimTarihi", dateTimePicker2.Text);
            komut.Parameters.AddWithValue("@SaticiNo", textBox6.Text);
            komut.ExecuteNonQuery();
            Listele("select * from Urunler");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"Update Urunler set UrunFiyat='"+textBox3.Text+"' where UrunNo='"+textBox1.Text+"'",baglanti);

            komut.ExecuteNonQuery();
            Listele("select * from Urunler");
            baglanti.Close();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Urunler where UrunNo like'%" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
