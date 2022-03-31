using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Ogrenciler
    {
        
        private int ogrNo;
        private string ogAdSoyad;

        public int OgrNo
        {
            get { return ogrNo; }
            set
            {
                if (value == 5) ogrNo = value;
                else Console.WriteLine("Değer atayamam.");
            }
        }
        public string OgAdSoyad
        {
            get { return ogAdSoyad; }
            set
            {
                if (value == "ali") ogAdSoyad = value;
                else Console.WriteLine("Böyle bir öğrenci yoktur...");
            }
        }

        public Ogrenciler(int no, string adSoyad)
        {
            this.ogrNo = no;
            this.ogAdSoyad = adSoyad;
        }
    }
}
