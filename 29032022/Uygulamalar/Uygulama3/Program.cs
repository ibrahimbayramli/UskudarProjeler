using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Dahiliye");
            Console.WriteLine("2- Kardiyoloji");
            Console.Write("Bölüm seçiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Dahiliye bölümüze hoşgeldiniz...");
                    Dahiliye d1 = new Dahiliye();
                    d1.Yazdir(); 

                    break;
                case 2:
                    break;
                

            }

            Console.ReadKey();
        }
    }
}
