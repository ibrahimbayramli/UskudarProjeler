using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        public static void Mesaj()//geriye değer döndürmeyen parametresiz metot
        {
            Console.WriteLine("Hoşgeldiniz canlar.. İyi yaşayın inşşş");
        }
        public static void GelenBilgi(int yas,string adSoyad)//geriye değer döndürmeyen 2 parametreli metot
        {
            if (yas > 18) Console.WriteLine($"{adSoyad} sistemimize katılım kazandınız ver paraları..");
            else Console.WriteLine($"{adSoyad} Büyüyünce gel.....");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("İŞKUR oyun grubu game developerlar.");
            Mesaj();
            Console.WriteLine("Yallah işe :)");
            Console.Write("Ad soyad giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Yaş giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            GelenBilgi(yas, isim);
            Console.ReadKey();
        }
    }
}
