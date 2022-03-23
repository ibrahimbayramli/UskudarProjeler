using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
    class Program
    {
        public static void Kullanici(string isimSoyisim, string kullaniciAdi,string parola)
        {
            if (kullaniciAdi == "admin" && parola == "12345") Console.WriteLine($"{isimSoyisim} başarılı bir şekilde giriş yaptınız.");
            else Console.WriteLine($"{isimSoyisim} şifre veya kullanıcı adınız hatalıdır.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("İsim soyisim bilgilerinizi giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Kullanıcı adınızı girinizi:");
            string kullanici = Console.ReadLine();
            Console.WriteLine("Parolanızı giriniz:");
            string password = Console.ReadLine();
            Kullanici(isim, kullanici, password);
            Console.ReadKey();
        }
    }
}
