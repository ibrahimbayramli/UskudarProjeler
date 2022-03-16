using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkıncıUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 25;
            int sayi1 = 100;
            int toplam = sayi + sayi;
            Console.WriteLine($"Toplama Sonucu: {toplam}");
            char cinsiyet = 'K';
            float fiyat = 25.5f;
            float indirim = 5.3f;
            float tutar = fiyat - indirim;
            bool secenek = true;
            Console.WriteLine($"Cinsiyet: {cinsiyet}");
            Console.WriteLine($"Tutar: {tutar}");
            Console.WriteLine($"Seçenek değeri: {secenek}");
            Console.ReadKey();
        }
    }
}
