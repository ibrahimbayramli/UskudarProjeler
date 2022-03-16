using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            git:
            Console.Write("Yapılacak işlemi seçiniz.\nToplama için +\nÇıkarma için -\nÇarpma için *\nBölme için /\nMod alma için %\n");
            char islem = Convert.ToChar(Console.ReadLine());
            Console.Write("İlk sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            double sonuc;

            if (islem == '+')
            {
                sonuc = (double)sayi1 + (double)sayi2;
                Console.WriteLine(sonuc);
                Console.Write("Yeni bir işlem yapmak ister misiniz? <E/H>");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'e' || cevap == 'E')
                {
                    goto git;
                    Console.Clear();
                }
            }
            else if (islem == '-')
            {
                sonuc = (double)sayi1 - (double)sayi2;
                Console.WriteLine(sonuc);
                Console.Write("Yeni bir işlem yapmak ister misiniz? <E/H>");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'e' || cevap == 'E')
                {
                    goto git;
                    Console.Clear();
                }
            }
            else if (islem == '*')
            {
                sonuc = (double)sayi1 * (double)sayi2;
                Console.WriteLine(sonuc);
                Console.Write("Yeni bir işlem yapmak ister misiniz? <E/H>");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'e' || cevap == 'E')
                {
                    goto git;
                    Console.Clear();
                }
            }
            else if (islem == '/') {
                sonuc = (double)sayi1 / (double)sayi2;
                Console.WriteLine(sonuc);
                Console.Write("Yeni bir işlem yapmak ister misiniz? <E/H>");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'e' || cevap == 'E')
                {
                    goto git;
                    Console.Clear();
                }
            }
            else if (islem == '%')
            {
                sonuc = (double)sayi1 % (double)sayi2;
                Console.WriteLine(sonuc);
                Console.Write("Yeni bir işlem yapmak ister misiniz? <E/H>");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'e' || cevap == 'E')
                {
                    goto git;
                    Console.Clear();
                }
            }
            
            Console.ReadKey();

        }
    }
}
