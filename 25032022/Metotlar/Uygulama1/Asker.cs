using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Asker
    {
        // Asker classı aç adsoyad, yaş, meslek, mezuniyet, günlük maaşını 
        // 2 tane metod olacak
        // return bölümüne göre günlük ücret miktarından maaş hesaplayan 
        // void meslek mühendis ve doktor olanlar haftasonu çarşıya çıkabilsin.
        // diğer meslek sahipleri 2 haftada bir çarşıya çıkabilsin.

        public string adSoyad, meslek, mezuniyet;
        public int yas, gunluk;

        public void CarsiIzni(string meslek)
        {
            if (meslek == "Doktor" || meslek == "doktor" || meslek == "Mühendis" || meslek == "mühendis")
            {
                Console.WriteLine("Haftasonları çarşıya çıkabilir.");
            }
            else
            {
                Console.WriteLine("2 haftada bir çarşı iznine çıkabilir.");
            }
        }
        public int MaasHesapla(int gunluk)
        {
            int maas = gunluk * 30;
            return maas;
        }


    }
}
