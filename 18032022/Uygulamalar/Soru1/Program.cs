using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            //75 den 300 e kadar girilen sayıya bölünen sayıyı bulan kodu yazın
            Console.Write("Bölen sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            for (int i = 75; i <= 300; i++)
            {
                if (i % sayi == 0)
                {
                    sayac++;
                }
            }
            Console.WriteLine($"75-300 aralığında {sayi} tam bölünen {sayac} adet sayı vardır.");
            Console.ReadKey();
        }
    }
}
