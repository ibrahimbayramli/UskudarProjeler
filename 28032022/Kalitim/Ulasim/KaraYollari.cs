using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasim
{
    class KaraYollari:Ulasim
    {
        private string plakaNo;
        private int turSayisi;
        private string seferAdi;
        private int seferAraligi;
        


        public string PlakaNo
        {
            get { return plakaNo;}
            set
            {
                if (value.Length != 6)
                {
                    plakaNo = "111111";
                }
                else
                {
                    plakaNo = value;
                }
            }
        }
        public int TurSayisi
        {
            get { return turSayisi; }
            set { turSayisi = value; }
        }
        public string SeferAdi
        {
            get { return seferAdi; }
            set { seferAdi = value; }
        }
        public int SeferAraligi
        {
            get { return seferAraligi; }
            set { seferAraligi = value; }
        }

        public void Ky ( bool rezervasyon, string seferAdi,float biletTutar)
        {
            if(rezervasyon && seferAdi == "şehirdışı")
            {
                biletTutar *= 1.08f;
            }else if(rezervasyon && seferAdi == "şehirdışı")
            {
                biletTutar *= 1.03f;
            }
            else
            {
                biletTutar *= 1.1f;
            }

            Console.WriteLine($"Bilet fiyatınız: {biletTutar}");
        }
    }
}
