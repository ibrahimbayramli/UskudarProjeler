using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayac = 0;
            while (sayac < 10)
            {
                int sayi = rnd.Next(10, 251);
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                    sayac++;
                }
                
            }
            Console.ReadKey();
        }
    }
}
