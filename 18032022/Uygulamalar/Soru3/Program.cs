using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            int orta=0 ;
            float result = 0;
            int toplam = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("{0}. sayiyi giriniz: ",i);
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                if (i == 5)
                {
                    orta = sayi;
                }
            }
            result = (float)(toplam / orta);
            Console.WriteLine($"5. sayı: {orta}");
            Console.WriteLine($"Bölüm sonucu: {result}");
            Console.ReadKey();

        }
    }
}
