using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolonyalar k1 = new Kolonyalar();
            k1.MarkaAdi = "eyüp sabri tuncer";

            Console.WriteLine($"Marka adı: {k1.MarkaAdi}");
            k1.Fiyat = 100;
            Console.WriteLine("Fiyat: "+k1.Fiyat);

            k1.Uretim = 2021;
            Console.WriteLine("Üretim yılı: "+k1.Uretim);

            Console.ReadKey();
        }
    }
}
