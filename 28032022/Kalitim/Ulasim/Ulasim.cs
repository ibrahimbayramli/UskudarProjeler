using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasim
{
    class Ulasim
    {
        private int koltukNumarasi;
        private string koltukKonum;
        private float biletFiyat;
        private bool rezervasyon;
        private string durakBilgisi;
        private string durakAdlari;

        public int KoltukNumarasi
        {
            get { return koltukNumarasi; }
            set { koltukNumarasi = value; }
        }
        public string KoltukKonum
        {
            get { return koltukKonum; }
            set { koltukKonum = value; }
        }
        public float BiletFiyat
        {
            get { return biletFiyat; }
            set { biletFiyat = value; }
        }
        public bool Rezervasyon
        {
            get { return rezervasyon; }
            set { rezervasyon = value; }
        }
        public string DurakBilgisi
        {
            get { return durakBilgisi; }
            set { durakBilgisi = value; }
        }
        public string DurakAdlari
        {
            get { return durakAdlari; }
            set { durakAdlari = value; }
        }

        public void Istek()
        {
            Console.WriteLine("a) Hava Yolları");
            Console.WriteLine("b) Kara Yolları");
            Console.WriteLine("c) Demir Yolları");
            Console.WriteLine("d) Deniz Yolları");
        }

        public float BiletFiyatHesapla(float fiyat, int durakSayisi)
        {
            return fiyat * durakSayisi;
        }
        public void UlasimEkstra(string koltukKonum)
        {
            if (koltukKonum == "kuzey")
            {
                Console.WriteLine("Rezervasyon yapamazsınız.");
            }
            else
            {
                Console.WriteLine($"{koltukKonum} rezervasyon yapabilirsiniz.");
            }
        }





    }
}
