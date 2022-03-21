using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama17
{
    class Program
    {
        static void Main(string[] args)
        {
            string kadi = "admin";
            string sifre = "123";
            int sayac = 0;
            do
            {
                Console.Write("Kullanıcı adını giriniz: ");
                string name = Console.ReadLine();
                Console.Write("Şifrenizi giriniz: ");
                string password = Console.ReadLine();
                if (name == kadi && password == sifre)
                {
                    Console.WriteLine("Tebrikler giriş başarılı.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız.");
                    sayac++;
                }

                if (sayac == 3)
                {
                    Console.WriteLine("Hatalı giriş hakkınız doldu. Hesabınız bloklandı.");
                }
            } while (sayac <= 3);
            Console.ReadKey();
        }
    }
}
