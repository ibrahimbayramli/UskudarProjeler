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
            string[] isimler = { "nihoş", "pek", "hoş" };
            foreach (string item in isimler)
            {
                Console.WriteLine($"İsimler: {item}");
            }
            Console.Write("Diziniz kaç elemanlı olsun: ");
            int dizi = Convert.ToInt32(Console.ReadLine());

            int[] sayi = new int[dizi];
            int toplam = 0;
            for (int i = 0; i < dizi; i++)
            {
                Console.Write($"Dizinin {i+1}. elemanını giriniz: ");
                int eleman = Convert.ToInt32(Console.ReadLine());
                toplam += sayi[i];
            }
            Console.WriteLine($"Toplam: {toplam}");
            Console.ReadKey();
        }
    }
}
