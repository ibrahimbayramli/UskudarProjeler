using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Flower
    {
        public string cicekAdi;
        public string renk;
        public string kokuDurumu;
        public int fiyat;
        public int adet;
        public int FiyatHesapla(int adet,int fiyat)
        {
            int fatura = adet * fiyat;
            return fatura;
        }
        public void Ozellik(string cad,string renk)
        {
            if(cad=="gül" || cad == "kaktüs")
            {
                Console.WriteLine("Kırmızı ve sarı renklerimiz mevcuttur. Bir demet alana bir demet bedava.");
            }
            else
            {
                Console.WriteLine("Diğer çiçeklerde %2 indirim var.");
            }
        }
    }
}
