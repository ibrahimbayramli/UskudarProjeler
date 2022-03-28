using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct
{
    abstract class Hali
    {
        public string marka;
        public string model;
        public int fiyat;

        public abstract void Hesapla(string marka, int fiyat);
        public abstract int Indirim(int fiyat);
        public void Ozellikler()
        {
            Console.WriteLine("Halılarımız Cengizhan usta Gaziantep'den getirmektedir.");
        }
        
    }
}
