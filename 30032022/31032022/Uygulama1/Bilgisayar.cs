using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Bilgisayar : Elektronik
    {
        private string ekranKartiMarkasi;
        private string isletimSistemi;
        private double ssdDurumu;

        public string EkranKartiMarkasi
        {
            get { return ekranKartiMarkasi; }
            set { if (value == "samsung")
                {
                    ekranKartiMarkasi = value;
                }
                else
                {
                    Console.WriteLine("En iyi ekran kartlarını Samsung üretmekte.");
                    ekranKartiMarkasi = "Nvdia";

                }
            }
        }
        public string IsletimSistemi
        {
            get { return isletimSistemi; }
            set
            {
                if (value== "linux") isletimSistemi = value;
                else
                {
                    Console.WriteLine("Özgür sistemden ayrılmayın.");
                    isletimSistemi = "macOS";
                }
            }
        }
        public double SsdDurumu
        {
            get { return ssdDurumu; }
            set
            {
                if (value == 2048) ssdDurumu = value;
                else
                {
                    Console.WriteLine("2048 gb ssd idealdir.");
                    ssdDurumu = 2048;
                }
            }
        }

        public override void Hesaplama(double fiyat, double kdv, double otv)
        {
            throw new NotImplementedException();
        }

        public override void Kampanya(int uretimYili, string marka)
        {
            throw new NotImplementedException();
        }

    }
}
