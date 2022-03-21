using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama12
{
    class Program
    {
        static void Main(string[] args)
        {
            int dongu = 0;
            int sayac = 0;

            Random rnd = new Random();

            Console.Write("0-100 arasında bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                dongu++;

                int rastgele = rnd.Next(0,101);

                Console.Write(rastgele+" ");
                if (sayi == rastgele)
                {
                    sayac++;
                    
                }
                if (sayac == 2)
                {
                    Console.WriteLine();
                    break;
                }
            }
            Console.WriteLine($"Toplam döngü sayısı: {dongu}");
            Console.ReadKey();
        }
    }
}
