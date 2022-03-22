using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sesliHarf = "aeıioöuü";
            int sayac = 0;
            Console.Write("Bir metin girin: ");
            string metin = Console.ReadLine();
            foreach (char karakter in metin )
            {
                foreach(char sesli in sesliHarf)
                {
                    if (karakter == sesli)
                    {
                        sayac++;
                    }
                }

            }
            Console.WriteLine("Metin uzunluğu :"+metin.Length);
            Console.WriteLine("Metindeki sesli harf sayısı: "+sayac);
            Console.ReadKey();
        }
    }
}
