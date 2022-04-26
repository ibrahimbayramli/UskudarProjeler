using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesORM.Entity;
using BussinesORM.Facade;

namespace KTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["AdSoyad"].Value.ToString();
            textBox1.Tag = row.Cells["HastaId"].Value.ToString();
            textBox2.Text = row.Cells["Telefon"].Value.ToString();
            textBox3.Text = row.Cells["Adres"].Value.ToString();
            textBox4.Text = row.Cells["Guvence"].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Hastalar.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hasta hasta1 = new Hasta();
            hasta1.AdSoyad = textBox1.Text;
            hasta1.Telefon = textBox2.Text;
            hasta1.Adres = textBox3.Text;
            hasta1.Guvence = textBox4.Text;
            if (Hastalar.Ekle(hasta1)) MessageBox.Show("Eklendi.");
            dataGridView1.DataSource = Hastalar.Listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow==null) return;
            Hasta sil = new Hasta();
            sil.HasatId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HastaId"].Value);
            if (Hastalar.Sil(sil))
            {
                MessageBox.Show("Silindi.");
            }
            dataGridView1.DataSource = Hastalar.Listele(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hasta update = new Hasta();
            update.AdSoyad = textBox1.Text;
            update.HasatId = Convert.ToInt32(textBox1.Tag);
            update.Telefon = textBox2.Text;
            update.Adres = textBox3.Text;
            update.Guvence = textBox4.Text;
            if (Hastalar.Guncelle(update)) MessageBox.Show("Güncellendi.");
            dataGridView1.DataSource = Hastalar.Listele();
        }

        
    }
}
