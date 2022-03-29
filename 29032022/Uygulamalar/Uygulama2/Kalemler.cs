using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Kalemler : Kirtasiye
    {
        public int adet;
        public string urunKodu;
        public override float Kdv(int fiyat, string malzemeAdi)
        {
            if (malzemeAdi == "kurşunkalem")
            {
                return Convert.ToSingle(fiyat * 18 / 100) ;
            }
            else
            {
                return Convert.ToSingle(fiyat * 8 / 100);
            }
        }

        public override void StokTakip(string malzemeAdi, int adet)
        {
            if (stok < 5)
            {
                Console.WriteLine($"{malzemeAdi} ürününden kısıtlı stoğunuz kalmıştır.");
            }
            else
            {
                Console.WriteLine($"{malzemeAdi} ürününden {stok} adet stoğunuz bulunmaktadır.");
                Console.WriteLine("Stok sıkıntınız yoktur.");
            }
        }
        public void Siparis(string urunKodu,int adet)
        {
            Console.WriteLine($"{urunKodu} kodlu ürününüzden {adet} tane sipariş aldınız.");
        }
    }
}
