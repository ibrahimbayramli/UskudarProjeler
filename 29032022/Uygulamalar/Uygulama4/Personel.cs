using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
   abstract class Personel
    {
        public int id;
        public string adSoyad;
        public double tcNo;
        public string seans;
        public string mezuniyet;
        public int yas;
        public int ucret;
        public int devamsizlikSayisi;
        public string statu;
        public int prim;

        public abstract int SeansUcretiHepla(int seans, int ucret);
        public abstract void PrimHesapla(string statu, int yas, string seans, int ucret);
        public virtual float ZamYap(string mezuniyet,int ucret)
        {
            if (mezuniyet == "lisans")
            {
                return ucret * 1.15f;
            }else if (mezuniyet == "lise")
            {
                return ucret * 1.1f;
            }else if (mezuniyet == "yüksek")
            {
                return ucret * 1.2f;
            }
            else
            {
                return ucret * 1.f;
            }
        }
    }
}
