using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        public static void Muhasebe()
        {
            Console.WriteLine("*********** Muhasebe ***********");
            Console.Write("Aylık geliriniz: ");
            float gelir = Convert.ToSingle(Console.ReadLine());
            Console.Write("Aylık giderinizi: ");
            float gider = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Çalışan sayınız: ");
            int calisan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aylık çalışan gider fiyatı: ");
            float cgider = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Yıllık çalışan gider fiyatı: {cgider*calisan*12}");

            Console.WriteLine($"Yıllık geliriniz: {(gelir-gider)*12- cgider * calisan * 12}");

        }
        static void Main(string[] args)
        { 
            int secim;
            
            do
            {
                Console.WriteLine("1- Muhasebe");
                Console.WriteLine("2- Teknik servis");
                Console.WriteLine("3- İnsan kaynakları");
                Console.WriteLine("4- Çıkış");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Muhasebe();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }

            } while (secim != 4);
            Console.ReadKey();
        }
    }
}
