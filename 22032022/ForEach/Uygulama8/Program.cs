using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç tane fiyat girmek istiyorsunuz? ");
            int indis = Convert.ToInt32(Console.ReadLine());
            int[] fiyat = new int[indis];
            Random rnd = new Random();
            float toplamKomisyon = 0;
            for(int i = 0; i < indis; i++)
            {
                fiyat[i] = rnd.Next(10, 201);
                if (fiyat[i] < 100) toplamKomisyon += fiyat[i] * 0.02f;
                else toplamKomisyon += fiyat[i] * 0.05f;
            }
            foreach (int item in fiyat)
            {
                Console.WriteLine($"Fiyatlar: {item}");

            }
            Console.WriteLine($"Hesaplanan toplam komisyon: {toplamKomisyon}");
            Console.ReadKey();
        }
    }
}
