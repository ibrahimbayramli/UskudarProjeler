using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Kedigiller : KosanHayvanlar
    {
        public int kilo;
        public string cins;
        public string uremeZamani;

        public void Yonlendir(int kilo, string cins)
        {
            if(kilo>10 && kilo < 20)
            {
                Console.WriteLine($"{cins} kediler satılabilir.");
            }
            else
            {
                Console.WriteLine($"{cins} kediler devlet korumasında alamazsınız...");
            }
        }
    }
}
