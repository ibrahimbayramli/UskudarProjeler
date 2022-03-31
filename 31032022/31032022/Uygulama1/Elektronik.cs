using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    abstract class Elektronik
    {
        public int urunNo;
        public string urunAdi;
        public string marka;
        public string model;
        public int uretimYili;
        public int fiyat;
        public int otv;
        public int kdv;
        public int indirim;

        public abstract void Kampanya(int uretimYili, string marka);
        public abstract void Hesaplama(double fiyat, double kdv, double otv);
        public virtual double Zam(double fiyat)
        {
            return fiyat;
        }
        public virtual double Indirim(double fiyat)
        {
            return fiyat;
        }
    }
}
