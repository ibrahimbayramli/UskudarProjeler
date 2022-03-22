using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            float[] urunler = new float[10];
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Bir fiyat giriniz: ");
                urunler[i] = Convert.ToSingle(Console.ReadLine());
                if (urunler[i] < 1000 && urunler[i] > 99) urunler[i] *= 1.5f;
                else if (urunler[i] < 100 && urunler[i] > 0) urunler[i] *= 1.2f;
            }
            foreach (float item in urunler)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
