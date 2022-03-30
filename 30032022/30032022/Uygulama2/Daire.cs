using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Daire : Ev
    {
        public string cephe;
        public string daireDurumu;
        public int katSayisi;
        public int balkonSayisi;
        
        public void EvVerileri()
        {
            
            Console.Write("Cephe bilgisi giriniz: ");
            cephe = Console.ReadLine();
            Console.Write("Daire durumu giriniz: ");
            daireDurumu = Console.ReadLine();
            Console.Write("Kat sayısını giriniz: ");
            katSayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Balkon sayısını giriniz: ");
            balkonSayisi = Convert.ToInt32(Console.ReadLine());
            AylikOdeme(cephe, balkonSayisi, daireDurumu);
            VeriCek();
        }

        public void AylikOdeme(string cephe,int banyoSayisi,string daireDurumu)
        {
            if(cephe=="güney" && banyoSayisi > 3)
            {
                fiyat = fiyat + aidat + yoneticiUcret;
                Console.WriteLine($"Yıllık ödenecek tutar: {fiyat/10}");
            }else if(cephe=="kuzey" && daireDurumu == "site")
            {
                Console.WriteLine("1- Yıllık ödeme");
                Console.WriteLine("2- Aylık ödeme");
                int secenek = Convert.ToInt32(Console.ReadLine());
                switch (secenek)
                {
                    case 1:
                        
                        Console.WriteLine($"Yıllık ödenecek tutar: {fiyat / 10}");
                        break;
                    case 2:
                        Console.WriteLine($"Aylık ödenecek tutar: {fiyat / 120}");
                        break;
                }
            }
        }

        public override void Teklifler(double fiyat)
        {
            Console.WriteLine("0- Boş");
            Console.WriteLine("1- Bahçe");
            Console.WriteLine("2- Ebeveyn Banyosu");
            Console.WriteLine("3- Şömine");
            Console.Write("Seçim yapınız: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 0:
                    Console.WriteLine($"Dairenizin fiyatı: {fiyat}");
                    break;
                case 1:
                    fiyat *= 1.2f;
                    Console.WriteLine($"Dairenizin fiyatı: {fiyat}");
                    break;
                case 2:
                    fiyat *= 1.03f;
                    Console.WriteLine($"Dairenizin fiyatı: {fiyat}");
                    break;
                case 3:
                    fiyat *= 1.08f;
                    Console.WriteLine($"Dairenizin fiyatı: {fiyat}");
                    break;

            }
        }
    }
}
