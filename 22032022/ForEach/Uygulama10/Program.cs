using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            Random rnd = new Random();
            int negatifSayac = 0;
            int pozitifSayac = 0;
            int sifir = 0;
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = rnd.Next(-50, 51);
                if (sayilar[i] > 0) pozitifSayac++;
                else if (sayilar[i] < 0) negatifSayac++;
                else sifir++;

            }
            Console.WriteLine($"Pozitif sayı adedi: {pozitifSayac}");
            Console.WriteLine($"Negatif sayı adedi: {negatifSayac}");
            Console.WriteLine($"İşaretsiz sayı adedi: {sifir}");
            Console.ReadKey();

        }
    }
}
