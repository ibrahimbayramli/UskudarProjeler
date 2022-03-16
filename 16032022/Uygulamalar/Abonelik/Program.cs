using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonelik
{
    class Program
    {
        static void Main(string[] args)
        {
            yeniIslem:
            Console.Write("Abonelik var mı? <true/false> ");
            bool aboneMi = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Kaç saat kaldı? ");
            int saat = Convert.ToInt32(Console.ReadLine());
            int ucret;
            if (aboneMi)
            {
                if(saat>=0 && saat < 2)
                {
                    ucret = 10;
                    Console.WriteLine($"Ödenmesi gereken ücret: {ucret}");
                    Console.ReadKey();
                    Console.WriteLine("Yeni işlem yapmak için bir tuşa basın.");
                    
                    

                }else if(saat>=2 && saat < 8)
                {
                    ucret = 20;
                    Console.WriteLine($"Ödenmesi gereken ücret: {ucret}");
                    Console.ReadKey();
                    Console.WriteLine("Yeni işlem yapmak için bir tuşa basın.");
                    Console.Clear();
                    Console.ReadKey();
                    goto yeniIslem;
                }
                else if (saat >= 8 )
                {
                    ucret = 40;
                    Console.WriteLine($"Ödenmesi gereken ücret: {ucret}");
                    Console.ReadKey();
                    Console.WriteLine("Yeni işlem yapmak için bir tuşa basın.");
                    
                }
            }
            else
            {
                if (saat >= 0 && saat < 2)
                {
                    ucret = 20;
                    Console.WriteLine($"Ödenmesi gereken ücret: {ucret}");
                    Console.ReadKey();
                    Console.WriteLine("Yeni işlem yapmak için bir tuşa basın.");
                    

                }
                else if (saat >= 2 && saat < 8)
                {
                    ucret = 40;
                    Console.WriteLine($"Ödenmesi gereken ücret: {ucret}");
                    Console.ReadKey();
                    Console.WriteLine("Yeni işlem yapmak için bir tuşa basın.");
                   
                }
                else if (saat >= 8)
                {
                    ucret = 80;
                    Console.WriteLine($"Ödenmesi gereken ücret: {ucret}");
                    Console.ReadKey();
                    Console.WriteLine("Yeni işlem yapmak için bir tuşa basın.");
                    
                }
            }
            Console.Clear();
            Console.ReadKey();
            goto yeniIslem;

        }
    }
}
