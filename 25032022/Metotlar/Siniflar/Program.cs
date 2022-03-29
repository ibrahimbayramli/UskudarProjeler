using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            //nesne üretme bellekte heap bölgesinde bulunur. 
            //MotorluTasitlar mt = new MotorluTasitlar();
            //mt.aracAdi = "Volvo";
            //mt.yakitFiyat = 22;
            //Console.WriteLine("Araç adı: "+mt.aracAdi);
            //Console.WriteLine("Yaıt fiyatı: "+mt.yakitFiyat);
            git:
            Console.WriteLine("1- Düğün çiçeği");
            Console.WriteLine("2- Cenaze çiçeği");
            int secenek = Convert.ToInt32(Console.ReadLine());

            if (secenek == 1)
            {
                // hata yakalama
                // try ---> kodu yaz hata var mı yok mu durumu kontrol et.
                // catch ---> yakala, eğer hata oluştu ise catch otomatik hatayı bulur yakalar.
                // finaly ---> her iki durumda da en son girmesini istediğimiz bloktur.

                try
                {
                    Flower cicek1 = new Flower();
                    Console.Write("Çiçek adını giriniz: ");
                    cicek1.cicekAdi = Console.ReadLine();
                    Console.Write("Renk giriniz: ");
                    cicek1.renk = Console.ReadLine();
                    Console.Write("Koku durumu giriniz: ");
                    cicek1.kokuDurumu = Console.ReadLine();
                    Console.Write("Fiyat giriniz: ");
                    cicek1.fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Adet giriniz: ");
                    cicek1.adet = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ödemeniz gereken fiyat: "+cicek1.FiyatHesapla(cicek1.adet,cicek1.fiyat));
                }
                catch
                {
                    Console.WriteLine("Bir hata meydana geldi.");
                    goto git;
                }


            }
            else if (secenek==2)
            {
                try
                {
                    Flower cicek2 = new Flower();
                    Console.Write("Çiçek adını giriniz: ");
                    cicek2.cicekAdi = Console.ReadLine();
                    Console.Write("Renk giriniz: ");
                    cicek2.renk = Console.ReadLine();
                    Console.Write("Koku durumu giriniz: ");
                    cicek2.kokuDurumu = Console.ReadLine();
                    Console.Write("Fiyat giriniz: ");
                    cicek2.fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Adet giriniz: ");
                    cicek2.adet = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ödemeniz gereken fiyat: " + cicek2.FiyatHesapla(cicek2.adet, cicek2.fiyat));
                }
                catch
                {
                    Console.WriteLine("Bir hata meydana geldi.");
                    goto git;
                }
            }
            

            Console.ReadKey();
        }
    }
}
