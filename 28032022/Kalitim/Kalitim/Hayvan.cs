using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Hayvan // temel class, ana class, super class
    {
        public string tip;
        public string nefesDurumu;
        public string renk;

        public void Petshop()
        {
            Console.WriteLine("Sadece evcil kediler satılabilir.");
            Console.WriteLine("Yırtıcı kediler için özel izin alınmalıdır.");
        }
    }
}
