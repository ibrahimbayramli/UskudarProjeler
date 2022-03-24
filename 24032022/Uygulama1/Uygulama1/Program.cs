using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediHesaplayici
{
    class Program
    {
        public static string GarantiBankasi()
        {
            Console.WriteLine("1) Bireysel müşteriler");
            Console.WriteLine("2) Kurumsal müşteriler");
            Console.Write("Bir seçim yapınız: ");
            int gsecim = Convert.ToInt32(Console.ReadLine());
            float toplam = 0;
            float taksit = 0;

            if (gsecim == 1)
            {
                Console.WriteLine("1) %10 faizli ve 8 ay vadeli 3 tane kredi");
                Console.WriteLine("2) %20 faizli ve 20 ay vadeli 20 tane kredi");
                Console.Write("Bir seçim yapınız: ");
                int gsecim1 = Convert.ToInt32(Console.ReadLine());

                if (gsecim1 == 1)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.Write($"{i}. kredi tutarını giriniz: ");
                        float tutar = Convert.ToSingle(Console.ReadLine());
                        tutar *= 1.1f;
                        toplam += tutar;

                    }
                    return $"Kredilerinizin toplamı {toplam}TL. Taksit tutarınız {toplam / 8}TL";
                }
                else
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        Console.Write($"{i}. kredi tutarını giriniz: ");
                        float tutar = Convert.ToSingle(Console.ReadLine());
                        tutar *= 1.2f;
                        toplam += tutar;

                    }
                    return $"Kredilerinizin toplamı {toplam}TL. Taksit tutarınız {toplam /20}TL";
                }

            }
            else return "Henüz yapım aşamasında.";
        }
        public static void Anasayfa()
        {
            Console.WriteLine("1) Garanti Bankası");
            Console.WriteLine("2) Ziraat Bankası");
            Console.WriteLine("3) İş Bankası");
            Console.Write("Bir seçim yapınız: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine(GarantiBankasi()); 
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }


        }
        static void Main(string[] args)
        {
            Anasayfa();
            Console.ReadKey();
        }
    }
}
