using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        public static void TekCift(int sayi)
        {
            if (sayi % 2 == 0) Console.WriteLine($"{sayi} sayısı çift bir sayıdır.");
            else Console.WriteLine($"{sayi} sayısı tek bir sayıdır.");
        }
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            TekCift(sayi);
            Console.ReadKey();
        }
    }
}
