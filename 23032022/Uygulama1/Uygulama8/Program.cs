using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8
{
    class Program
    {
        public static int Fatura(int fiyat,int kdv)
        {
            fiyat += fiyat * kdv / 100;
            return fiyat;
        }
        public static void HediyeCeki()
        {
            Console.Write("Hediye çekiniz var mı? ");
            string cevap = Console.ReadLine();
            if (cevap == "evet")
            {
                Console.WriteLine("Karaca nevresim takımında 100TL indirim kazanabilirsiniz. Kaçırmayın.");
            }
            else
            {
                Console.WriteLine("2500TL üzerinde alışveriş yapanları");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("********** ÖZ Züccaciye **********");
            Console.WriteLine("1- Nevresim Takımı");
            Console.WriteLine("2- Bardak-Çanak");
            Console.WriteLine("3- Ev aletleri");
            Console.Write("Ürün seçiniz: ");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    Console.Write("Fiyat giriniz: ");
                    int fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("KDV tutarını hesaplat.");
                    int kdv = Convert.ToInt32(Console.ReadLine());
                    HediyeCeki();
                    Fatura(fiyat, kdv);
                    break;

                case '2':
                    Console.Write("İndirimden faydalanmak istersen devam yaz. ");
                    string a = Console.ReadLine();
                    if(a=="devam" || a=="DEVAM" || a == "Devam")
                    {
                        Console.Write("Fiyat giriniz: ");
                        int fiyat1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("KDV tutarını hesaplat.");
                        int kdv1 = Convert.ToInt32(Console.ReadLine());
                        HediyeCeki();
                        Fatura(fiyat1, kdv1);
                    }
                    break;

                case '3':
                    break;
            }
        }
    }
}
