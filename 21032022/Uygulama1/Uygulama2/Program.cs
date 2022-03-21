using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            //randomistenilen sayı kadar harf yazan program
            string abc = "abcdefghijklmnoprstuvyz";
            Random rnd = new Random();
            string uret = "";

            Console.Write("Kaç harf üretmek istersiniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < sayi; i++)
            {
                uret += abc[rnd.Next(abc.Length)];
            }

            Console.WriteLine($"Üretilen harfler: '{uret}'");
            Console.ReadLine();
              
        }
    }
}
