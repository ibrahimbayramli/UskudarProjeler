using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            sayilar[1] = 12;
            sayilar[3] = 4;
            sayilar[4] = 11;
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Dizinin değerleri: {sayilar[i]}");
            //}
            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine($"Dizinin değerleri: {item}");
            //}
            for (int i = 4; i >=0; i--)
            {
                Console.WriteLine($"Dizinin değerleri: {sayilar[i]}");
            }
            Console.ReadKey();

        }
    }
}
