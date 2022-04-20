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

        private void button5_Click(object sender, EventArgs e)
        {
            var sonuc = from personel in islem.Personellers
                        join satis in islem.Satislars on personel.PersonelID equals satis.PersonelID
                        group satis by personel.Adi into grup
                        select new
                        {
                            personelAdi = grup.Key,
                            toplamSatis = grup.Count()
                        };
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sonuc = from satis in islem.Satislars
                        join musteri in islem.Musterilers on satis.MusteriID equals musteri.MusteriID
                        select new
                        {
                            satis.SatisTarihi,
                            satis.SevkAdresi,
                            satis.OdemeTarihi,
                            satis.SevkSehri,
                            musteri.MusteriAdi,
                            musteri.MusteriUnvani,
                            musteri.Telefon,
                            musteri.Ulke,
                            musteri.Sehir
                        };
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sonuc = from satislar in islem.Satislars
                        join nakliyeciler in islem.Nakliyecilers on satislar.ShipVia equals nakliyeciler.NakliyeciID
                        group nakliyeciler by nakliyeciler.SirketAdi into grup
                        select new
                        {
                            NakliyeciAdi = grup.Key,
                            ToplamNakliye = grup.Count()
                        };

            dataGridView1.DataSource = sonuc.ToList();
        }
    }
}
