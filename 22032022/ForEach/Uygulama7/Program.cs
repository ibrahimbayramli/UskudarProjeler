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
            int[] benimDizim = new int[10];
            int sayac = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Dizinizin {i+1}. elemanını giriniz: ");
                benimDizim[i] = Convert.ToInt32(Console.ReadLine());
                if (benimDizim[i] % 10 == 0) sayac++;
            }
            Console.WriteLine($"Dizinizde {sayac} tane sonunda 0 olan eleman vardır.");
            Console.ReadKey();
        }
    }
}
