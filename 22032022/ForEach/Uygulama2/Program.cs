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
            string rakam = "0123456789";
            string ozelKarakter = "*?!<>-_&%+/";
            string sesliHarf = "aeıioöuü";
            Console.Write("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            int ozelSayac = 0;
            int rakamSayac = 0;
            int sesliSayac = 0;
            
            foreach (char karakter in metin )
            {
                foreach(char numara in rakam)
                {
                    if (karakter == numara) rakamSayac++;

                }
                foreach (char ozel in ozelKarakter)
                {
                    if (karakter == ozel) ozelSayac++;

                }

                foreach (char ses in sesliHarf)
                {
                    if (karakter == ses) sesliSayac++;

                }

            }
            Console.WriteLine($"Metin uzunluğu: {metin.Length}");
            Console.WriteLine($"Özel karakter sayısı: {ozelSayac}");
            Console.WriteLine($"Rakam sayısı: {rakamSayac}");
            Console.WriteLine($"Sesli harf sayısı: {sesliSayac}");
            Console.WriteLine($"Sessiz harf sayısı: {metin.Length-ozelSayac-rakamSayac-sesliSayac}");
            Console.ReadKey();
        }
    }
}
