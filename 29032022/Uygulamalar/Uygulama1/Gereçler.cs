using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
   abstract class Gereçler
    {
        public int gerecNo;
        public string gerecKategori;
        public int fiyat;
        public int adet;

        public abstract int Fatura(int fiyat,int adet);
        public abstract void Kategori(string gerecKategori);


    }
}
