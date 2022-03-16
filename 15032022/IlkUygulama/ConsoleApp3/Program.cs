using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            git:
            Console.Write("Kullanıcı adını giriniz: ");
            string kadi = Console.ReadLine();
            Console.Write("Kullanıcı şifresini giriniz: ");
            int sifre = Convert.ToInt32(Console.ReadLine());
            if(kadi=="admin" && sifre == 1234)
            {
                Console.WriteLine($"{kadi} Hoşgeldiniz.");
                
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
                Console.WriteLine("Tekrar denemek istermisiniz? <e/h>");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'e'||cevap=='E')
                {
                    Console.Clear();
                    goto git;
                }
                else
                {
                    Console.WriteLine("Hoşçakalın.");
                    Environment.Exit(0);
                }
            }

            Console.ReadKey();
        }
    }
}
