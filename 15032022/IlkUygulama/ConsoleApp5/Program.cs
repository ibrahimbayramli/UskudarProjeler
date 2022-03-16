using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //rastgele değer atama
            Random rastgele = new Random();
            int sayi = rastgele.Next(10, 101);
            int sayi1 = rastgele.Next(100, 201);
            Console.WriteLine($"Rastgele değerimiz: {sayi}");
            Console.WriteLine($"Rastgele değerimiz: {sayi1}");

            Console.ReadKey();
        }
    }
}
