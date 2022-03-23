using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5
{
    class Program
    {
        public static void TekSayiAdeti(int sayi)
        {
            int sayac = 0;
            for(int i = 0; i < sayi; i++)
            {
                if (i % 2 == 1) sayac++;
            }

            Console.WriteLine($"0-{sayi} arasında {sayac} tane tek sayı vardır.");
        }
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int deger = Convert.ToInt32(Console.ReadLine());
            TekSayiAdeti(deger);
            Console.ReadKey();
        }
    }
}
