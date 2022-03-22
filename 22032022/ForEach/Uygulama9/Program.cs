using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            int[] kareler = new int[5];
            int toplam = 0;
            int kareToplam = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                kareler[i] = sayilar[i] * sayilar[i];
                toplam += sayilar[i];
                kareToplam += kareler[i];

            }
            Console.WriteLine();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{sayilar[i]} sayısının karesi {kareler[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Sayıların toplamı: {toplam}");
            Console.WriteLine($"Kareler toplamı: {kareToplam}");
            Console.ReadKey();

        }
    }
}
