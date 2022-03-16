using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //karşılaştırma operatörleri
            //== iki değişken arasında karşılaştırma yapar
            //&& ve anlamında
            //|| veya anlamında 
            //>=
            //<= 
            // % mod alma
            //= atama yapmak için kullanılır
            //kontrol mekanizması
            //if(eğer) else(değilse)
            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine("1. sayı daha büyük değerdedir.");

            }
            else
            {
                Console.WriteLine("2. sayı daha büyük değerdedir.");

            }

            Console.ReadKey();
        }
    }
}
