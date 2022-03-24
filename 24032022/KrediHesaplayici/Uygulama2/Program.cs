using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Program
    {
        static int fatura=0;
        public static void YemekSec(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("Et yemeğiniz hazırlanıyor.");
                Console.WriteLine("Tutar: " + 100);
                fatura += 100;
            }
            else if (secim == 2)
            {
                Console.WriteLine("Mantınız hazırlanıyor.");
                Console.WriteLine("Tutar: " + 80);
                fatura += 80;
            }
            else if (secim == 3)
            {
                Console.WriteLine("Tavuk yemeğiniz hazırlanıyor.");
                Console.WriteLine("Tutar: " + 90);
                fatura += 90;
            }
            else if (secim == 4)
            {
                Console.WriteLine("Salatanız hazırlanıyor.");
                Console.WriteLine("Tutar: " + 50);
                fatura += 50;
            }

        }
        public static void IcecekSec(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("Kolanız hazırlanıyor.");
                Console.WriteLine("Tutar: " + 10);
                fatura += 10;
            }
            else if (secim == 2)
            {
                Console.WriteLine("Fantanız hazırlanıyor.");
                Console.WriteLine("Tutar: " + 10);
                fatura += 10;
            }
            else if (secim == 3)
            {
                Console.WriteLine("Ayranınız hazırlanıyor.");
                Console.WriteLine("Tutar: " + 15);
                fatura += 15;
            }
            else if (secim == 4)
            {
                Console.WriteLine("Suyunuz hazırlanıyor.");
                Console.WriteLine("Tutar: " + 5);
                fatura += 5;
            }
        }
        public static void TatliSec(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("Kazandibiniz hazırlanıyor.");
                Console.WriteLine("Tutar: " + 50);
                fatura += 50;
            }
            else if (secim == 2)
            {
                Console.WriteLine("Sütlaçınız hazırlanıyor.");
                Console.WriteLine("Tutar: " + 50);
                fatura += 50;
            }
            else if (secim == 3)
            {
                Console.WriteLine("Baklavanız hazırlanıyor.");
                Console.WriteLine("Tutar: " + 150);
                fatura += 150;
            }
            else if (secim == 4)
            {
                Console.WriteLine("Şekerpareniz hazırlanıyor.");
                Console.WriteLine("Tutar: " + 30);
                fatura += 30;
            }
        }
        public static void FaturaOde()
        {
            Console.WriteLine($"Ödemeniz gereken fatura: {fatura}");
        }
        static void Main(string[] args)
        {
            int secim;
            
            
            
            do{
                Console.WriteLine("1- Yemek");
                Console.WriteLine("2- İçecek");
                Console.WriteLine("3- Tatlı");
                Console.WriteLine("4- hesap öde");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim) { 
                case 1:
                    Console.WriteLine("1- Et yemeği");
                    Console.WriteLine("2- Manı");
                    Console.WriteLine("3- Tavuk yemeği");
                    Console.WriteLine("4- Salata");
                    int secim1 = Convert.ToInt32(Console.ReadLine());
                    YemekSec(secim1);
                    break;
                case 2:
                    Console.WriteLine("1- Kola");
                    Console.WriteLine("2- Fanta");
                    Console.WriteLine("3- ayran");
                    Console.WriteLine("4- su");
                    secim1 = Convert.ToInt32(Console.ReadLine());
                    IcecekSec(secim);
                    break;
                case 3:
                    Console.WriteLine("1- Kazandibi");
                    Console.WriteLine("2- Sütlaç");
                    Console.WriteLine("3- Baklava");
                    Console.WriteLine("4- Şekerpare");
                    secim1 = Convert.ToInt32(Console.ReadLine());
                    TatliSec(secim);
                    break;
                case 4:
                    FaturaOde();
                    break;

            }
        }while (secim != 4) ;
                Console.ReadKey();
        }
    }
}
