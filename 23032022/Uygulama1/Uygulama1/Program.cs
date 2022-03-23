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
            //Girilen dizi elemanlarının içinde en uzun kelimenin uzunluğu indisi ve kelimeyi veren kod.
            int indis=0;
            int len=0;
            string[] benimDizim = new string[10];
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}. elemanı giriniz: ");
                string metin = Console.ReadLine();

                benimDizim[i] = metin;
                if (metin.Length > len)
                {
                    len = metin.Length;
                    indis = i;
                }
            }
            Console.WriteLine($"En uzun metin: {benimDizim[indis]}");
            Console.WriteLine($"En uzun metinin uzunluğu: {len}");
            Console.WriteLine($"En uzun metinin indisi: {indis}");
            Console.ReadKey();

        }
    }
}
