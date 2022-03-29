using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Kitaplar : Kirtasiye
    {
        public string kitapAdi;
        public string yazar;
        public int satisAdedi;
        public override float Kdv(int fiyat, string malzemeAdi)
        {

            if (malzemeAdi == "roman")
            {
                return Convert.ToSingle(fiyat * 18 / 100);
            }else if (malzemeAdi == "ders")
            {
                return Convert.ToSingle(fiyat * 8 / 100);
            }
            else
            {
                return Convert.ToSingle(fiyat * 1 / 100);
            }
        }

        public override void StokTakip(string malzemeAdi, int stok)
        {
            if (stok < 3)
            {
                Console.WriteLine($"{malzemeAdi} ürününden kısıtlı stoğunuz kalmıştır.");
            }
            else
            {
                Console.WriteLine($"{malzemeAdi} ürününden {stok} adet stoğunuz bulunmaktadır.");
                Console.WriteLine("Stok sıkıntınız yoktur.");
            }
        }
        public void CokSatanlar(int satisAdeti,string yazar, string kitapAdi)
        {
            if (satisAdedi > 1000)
            {
                Console.WriteLine($"{yazar} yazarının {kitapAdi} kitabı {satisAdedi} tane satarak çok satanlar listesine girmiştir.");
            }
            else
            {
                Console.WriteLine($"{yazar} yazarının {kitapAdi} kitabı {1000-satisAdedi} tane daha kitap satarak çok satanlar listesine girebilir.");
            }

        }
    }
}
