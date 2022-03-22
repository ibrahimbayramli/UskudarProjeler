using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
            //dışarıdan girilen 5 elemanlı bir dizide tek sayılarının adedini gösteren program
            int[] benimDizim = new int[5];
            int sayac = 0;


            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Dizinin {i+1}. elemanını giriniz: ");
                int eleman = Convert.ToInt32(Console.ReadLine());
                benimDizim[i] = eleman;
                if (eleman % 2 == 1) sayac++;
            }
            Console.WriteLine($"Dizide {sayac} tane tek eleman vardır.");
            Console.ReadKey();


        }
    }
}
