using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir bakteri cinsi her 4 dakikada bir ikiye bölünerek çoğalmaktadır. Başlangıçta 1 bakteri olduğu bilindiğine göre 1 saat sonra
            //oluşacak bakteri sayısını hesaplayınız.

            Console.Write("Kaç saat sonra oluşacak bakteriyi hesaplamak istiyorusunuz? ");
            int sure = Convert.ToInt32(Console.ReadLine());
            sure *= 60;
            
            int bakteri = 1;

            for(int i=0; i < sure; i += 4)
            {
                bakteri *= 2;
            }
            

            Console.WriteLine($"Oluşan bakteri sayısı: {bakteri}");

            Console.ReadKey();

        }
    }
}
