using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    class EvSandalyeleri : Sandalyeler
    {
        public override void KdvHesapla(int fiyat)
        {
            if (fiyat > 1000)
            {
                fiyat = fiyat + fiyat * 8 / 100;

            }

        }

        public override int ZamYap(string model, int fiyat)
        {
            if (model == "alaturka")
            {
                fiyat = fiyat + fiyat*25 / 100;
            }
            return fiyat;
        }
    }
}
