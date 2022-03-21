using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama16
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            do
            {
                Console.Write("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                if (sayi == 0)
                {
                    break;
                }
            } while (true);
            Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
            Console.ReadKey();
        }
    }
}
