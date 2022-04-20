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
        NorthwindEntities islem = new NorthwindEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities islem = new NorthwindEntities();
            var sonuc = from urun in islem.Urunlers
                        join tedarikci in islem.Tedarikcilers on urun.TedarikciID equals tedarikci.TedarikciID
                        select new
                        {
                            urun.UrunAdi,
                            urun.BirimFiyati,
                            urun.HedefStokDuzeyi,
                            tedarikci.SirketAdi,
                            tedarikci.Sehir,
                            tedarikci.Telefon
                        };
            dataGridView1.DataSource = sonuc.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sonuc = from urun in islem.Urunlers orderby urun.BirimFiyati select urun;
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sonuc = from urun in islem.Urunlers orderby urun.UrunAdi descending select urun;
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = from urun in islem.Urunlers
                        join kategori in islem.Kategorilers on urun.KategoriID equals kategori.KategoriID
                        select new
                        {
                            urun.UrunAdi,
                            urun.BirimFiyati,
                            urun.HedefStokDuzeyi,
                            kategori.KategoriID,
                            kategori.KategoriAdi,
                            kategori.Tanimi
                        };
            dataGridView1.DataSource = sonuc.ToList();
        }
    }
}
