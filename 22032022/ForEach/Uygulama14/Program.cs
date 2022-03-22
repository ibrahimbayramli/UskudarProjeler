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
            string[] isimler = { "ibrahim", "taylan", "cengiz", "nihal", "özgür" };
            Console.Write("Bir isim giriniz: ");
            string isim = Console.ReadLine();
            for(int i = 0; i < isimler.Length; i++)
            {
                if (isim == isimler[i]) Console.WriteLine($"Girdiğiniz isim {i}. sırada.");
                
            }
            Console.ReadKey();
        }
    }
}
