using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiGirme
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen 10 sayıdan 3 basamaklıları ayrı bir sayaçta tutan adedini tutan ve geri kalanlarını toplayan kodu yazın.
            int sayac = 0;
            int toplam = 0;
            for (int i=1;i<=3;i++)
            {
                Console.Write("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                
                if (sayi>99 && sayi<1000)
                {
                    sayac++;
                }
                else
                {
                    toplam += sayi;
                }

            }
            Console.WriteLine($"Üç basamaklı sayı adedi: {sayac}");
            Console.WriteLine($"Diğer sayıların toplamı: {toplam}");
            Console.ReadLine();
        }
    }
}
