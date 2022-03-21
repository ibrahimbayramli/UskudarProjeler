using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama7
{
    class Program
    {
        static void Main(string[] args)
        {
            //negatif sayı girince sonlanan döngüdeki sayıların toplamını veren kod
            int toplam = 0;
            while (true)
            {
                Console.Write("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    break;
                }
                toplam += sayi;
            }
            Console.WriteLine($"Girdiğiniz sayıların toplamı: {toplam}");
            Console.ReadKey();
        }
    }
}
