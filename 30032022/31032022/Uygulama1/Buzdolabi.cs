using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Buzdolabi : Elektronik
    {
        public double kaliteOrani;
        public double kapasite;
        public string sogutmaAyari;
        public override void Hesaplama(double fiyat, double kdv, double otv)
        {
            throw new NotImplementedException();
        }

        public override void Kampanya(int uretimYili, string marka)
        {
            throw new NotImplementedException();
        }

        public double OtvIndirim(double fiyat,double otv,double kaliteOrani, double kapasite)
        {
            return fiyat;
        }
    }
}
