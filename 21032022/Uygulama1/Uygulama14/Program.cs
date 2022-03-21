using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayac = 0;
            do
            {
                int sayi = rnd.Next(1, 100);
                Console.Write(sayi+" ");
                sayac++;
                if (sayi == 50)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
            } while (true);
            Console.WriteLine($"Toplam döngü sayısı: {sayac}");
            Console.ReadKey();
                
        }
    }
}
