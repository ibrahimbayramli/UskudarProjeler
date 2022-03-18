using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBuyukSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int enBuyuk = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            Console.WriteLine($"Girilen sayılar içerisinde en büyük sayı: {enBuyuk}");
            Console.ReadKey();
        }
    }
}
