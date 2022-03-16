using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //tc kimlik nosunu al
            //eğer doğru ise emeklilik yaşu ve mezuniyet tarihini iste
            //yaş 65 den büyük ve mezuniyet lisans ise 
            Console.Write("T.C. kimlik numaranızı giriniz: ");
            string tc = Console.ReadLine();
            Console.Write("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üniversite eğitimini seçiniz <L/Ö>: ");
            char mezuniyet = Convert.ToChar(Console.ReadLine());
            if ((mezuniyet == 'L' || mezuniyet == 'l') && yas > 65 && tc == "12345678910")
            {
                Console.WriteLine("Emekli olabilirsiniz.");

            }
            else
            {
                Console.WriteLine("Çalışmaya devam.");
            }

            Console.ReadKey();

        }
    }
}
