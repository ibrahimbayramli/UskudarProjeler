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
            int[] sayilar = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = rnd.Next(5, 51)*2;
            }
            foreach (int item in sayilar)
            {
                if (item < 50) Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
