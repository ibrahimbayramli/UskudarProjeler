using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Okul
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //SqlConnection con = new SqlConnection("Server=.;Database=Okul,uid=sa,pwd=1234"); sql server authenticaton
        SqlConnection con1 = new SqlConnection("Server=DESKTOP-MO5HLC4\\SQLEXPRESS;Database=Okul;Integrated Security=true"); //windows authenticaton
        private void button4_Click(object sender, EventArgs e)
        {
            Goster(); 
        }
        public void Goster()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OG";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OAdd";
            komut.Parameters.AddWithValue("AdSoyad", textBox2.Text);
            komut.Parameters.AddWithValue("TcNo", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("Telefon", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("Mail", textBox5.Text);
            komut.Parameters.AddWithValue("DersNo", textBox7.Text);
            komut.Parameters.AddWithValue("Adres", textBox6.Text);
            komut.ExecuteNonQuery();
            con1.Close();
            Goster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OSL";
            komut.Parameters.AddWithValue("OgrenciNo", textBox1.Text);
            komut.ExecuteNonQuery();
            con1.Close();
            Goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OY";
            komut.Parameters.AddWithValue("OgrenciNo", textBox1.Text);
            komut.Parameters.AddWithValue("AdSoyad", textBox2.Text);
            komut.Parameters.AddWithValue("TcNo", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("Telefon", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("Mail", textBox5.Text);
            komut.Parameters.AddWithValue("DersNo", textBox7.Text);
            komut.Parameters.AddWithValue("Adres", textBox6.Text);
            komut.ExecuteNonQuery();
            con1.Close();
            Goster();
        }
        private void dataGridView1_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
        }
    }
}
