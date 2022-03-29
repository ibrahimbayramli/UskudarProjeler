using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class MutfakGerecleri : Gereçler
    {
        public int watt;
        public string wattDurum;
        public void Enerji(int watt,string wattDurum)
        {
            if (watt > 4000)
            {
                Console.WriteLine("Yandın fatura öldürdü.");
            }else if (watt < 4000 && wattDurum=="şarjlı")
            {
                Console.WriteLine("A++ tasaruflu kazandın...");
            }
        }
        public override int Fatura(int fiyat, int adet)
        {
            if(adet>10 && adet < 20)
            {
                fiyat -= fiyat * 10 / 100;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }

        public override void Kategori(string gerecKategori)
        {
            if (gerecKategori == "Porselen")
            {
                Console.WriteLine("güral porselen tercihimizdir.");
            }
            else
            {

            }
        }
    }
}
