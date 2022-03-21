using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            float ortalama = 0;
            float toplam = 0;
            do
            {
                Console.Write("Öğrencinin notunu giriniz: ");
                float not = Convert.ToSingle(Console.ReadLine());
                toplam += not;
                ortalama = toplam / 10;
                sayac++;
            } while(sayac<=10);

            Console.WriteLine($"Ortalama: {ortalama}");
            Console.ReadKey();
        }
    }
}
