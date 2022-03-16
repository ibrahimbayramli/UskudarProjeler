using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, 11);
            int sayac = 1;
        git:
            Console.Write("Bir değer giriniz: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (sayi == tahmin)
            {
                Console.WriteLine("Tebrikler.");
                Console.WriteLine($"Tahmin sayınız: {sayac}");
                Console.ReadKey();
            }else if (sayi > tahmin)
            {
                Console.WriteLine("Küçük bir sayı girdiniz.");
                Console.WriteLine($"Tahmin sayınız: {sayac}");
                sayac=sayac+1;
                
                goto git;
            }
            else
            {
                Console.WriteLine("Büyük bir sayı girdiniz.");
                Console.WriteLine($"Tahmin sayınız: {sayac}");
                sayac++;
                
                goto git;

            }
        }
    }
}
