using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            Random rnd = new Random();
            int[] tekler = new int[10];
            int[] ciftler = new int[10];
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                int sayi = sayilar[i];

                if (sayilar[i] % 2 == 0) tekler.Append(sayi);
                else ciftler.Append(sayi);
            }
            
            
            foreach (int item in ciftler)
            {
                Console.WriteLine(item);

            }
            foreach (int item in tekler)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
