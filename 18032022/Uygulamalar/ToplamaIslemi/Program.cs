using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaIslemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Toplama işlemi yapmak istediğiniz adedi giriniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for(int i = 1; i <= adet; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;

            }
            Console.WriteLine($"Toplama işlemi sonuzu: {toplam}");
            Console.ReadKey();
        }
    }
}
