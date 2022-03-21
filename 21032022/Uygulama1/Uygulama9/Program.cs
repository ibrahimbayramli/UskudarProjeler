using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayac = 0;
            
            Random rnd = new Random();
            while (true)
            {
                int sayi = rnd.Next(0, 100);
                if (sayi % 5 == 0)
                {
                    toplam += sayi;
                }
                if (toplam > 1000)
                {
                    break;
                }
                sayac++;
            }
            Console.WriteLine($"Sayıların toplamı: {toplam}");
            Console.WriteLine($"Toplam adım sayısı: {sayac}");
            Console.ReadKey();

        }
    }
}
