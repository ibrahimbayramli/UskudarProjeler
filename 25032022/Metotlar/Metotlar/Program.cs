using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        //metot overloading uygulaması
        //ilkokul ortaokul lise için ortalama hesaplayan ve metodlarda overloading uygulaması.
        public static void NotHesapla(int sinav1,int sinav2)
        {
            //ilkokul 

            Console.WriteLine($"Ortalamanız: {(sinav1+sinav2)/2}");

        }
        public static void NotHesapla(int sinav1, int sinav2,int sozluSinav)
        {
            //ortaokul
            Console.WriteLine($"Ortalamanız: {(sinav1 + sinav2+sozluSinav) / 3}");
        }
        public static void NotHesapla(int sinav1, int sinav2, int sozluSinav,int kanaat)
        {
            //lise
            Console.WriteLine($"Ortalamanız: {(sinav1 + sinav2 + sozluSinav+kanaat) / 4}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1- İlkokul");
            Console.WriteLine("2- Ortaokul");
            Console.WriteLine("3- Lise");
            Console.Write("Bir seçim yapınız: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            int sinav1, sinav2, sozluSinav, kanaat;
            switch (secim)
            {
                case 1:
                    Console.Write("1. sınav notunu giriniz: ");
                    sinav1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sınav notunu giriniz: ");
                    sinav2 = Convert.ToInt32(Console.ReadLine());
                    NotHesapla(sinav1, sinav2);
                    break;
                case 2:
                    Console.Write("1. sınav notunu giriniz: ");
                    sinav1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sınav notunu giriniz: ");
                    sinav2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sözlü sınav notunu giriniz: ");
                    sozluSinav = Convert.ToInt32(Console.ReadLine());
                    NotHesapla(sinav1, sinav2,sozluSinav);
                    break;
                case 3:
                    Console.Write("1. sınav notunu giriniz: ");
                    sinav1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sınav notunu giriniz: ");
                    sinav2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sözlü sınav notunu giriniz: ");
                    sozluSinav = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kanaat notunu giriniz: ");
                    kanaat = Convert.ToInt32(Console.ReadLine());
                    NotHesapla(sinav1, sinav2, sozluSinav,kanaat);
                    break;
            }

            Console.ReadKey();
        }
    }
}
