using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9
{
    class Program
    {
        public static float TlUsd(float tutar)
        {
            return tutar / 15;
        }
        public static float UsdTl(float tutar)
        {
            return tutar * 15;
        }
        public static float TlEur(float tutar)
        {
            return tutar / 19;
        }
        public static float EurTl(float tutar)
        {
            return tutar *19;
        }
        public static float TlAlt(float tutar)
        {
            return tutar / 1000;
        }
        public static float AltTl(float tutar)
        {
            return tutar *1000;
        }
        static void Main(string[] args)
        {
            float tutar;
            git:
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1- TL-USD");
            Console.WriteLine("2- USD-TL");
            Console.WriteLine("3- TL-Euro");
            Console.WriteLine("4- Euro-TL");
            Console.WriteLine("5- TL-Altın");
            Console.WriteLine("6- Altın-TL");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Write("Tutar giriniz: ");
                    tutar = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(TlUsd(tutar));
                    break;
                case 2:
                    Console.Write("Tutar giriniz: ");
                    tutar = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(UsdTl(tutar));
                    break;
                case 3:
                    Console.Write("Tutar giriniz: ");
                    tutar = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(TlEur(tutar));
                    break;
                case 4:
                    Console.Write("Tutar giriniz: ");
                    tutar = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(EurTl(tutar));
                    break;
                case 5:
                    Console.Write("Tutar giriniz: ");
                    tutar = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(TlAlt(tutar));
                    break;
                case 6:
                    Console.Write("Tutar giriniz: ");
                    tutar = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(AltTl(tutar));
                    break;
            }
            Console.Write("Yeni bir işlem yapmak istermisiniz? <true/false>");
            bool yeniIslem = Convert.ToBoolean(Console.ReadLine());
            if (yeniIslem) goto git;
            Console.ReadKey();
        }
    }
}
