using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
   abstract class Kirtasiye
    {
        public int kirtasiyeNo;
        public string kirtasiyeAdi;
        public int stok;
        public int malzemeAdeti;
        public int fiyat;
        public string malzemeAdi;

        public abstract void StokTakip(string malzemeAdi, int stok);
        public abstract float Kdv(int fiyat, string malzemeAdi);
        public bool KirtasiyeSorgula(string kirtasiyeAdi)
        {
            if (kirtasiyeAdi == "Üsküdar")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
