using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Taban sayısını giriniz: ");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kuvvet sayısını giriniz: ");
            int kuvvet = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for(int i = 1; i <= kuvvet; i++)
            {
                result *= taban;
            }
            Console.WriteLine($"İşlem sonucu: {result}");
            Console.ReadKey();
        }
    }
}
