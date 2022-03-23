using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8
{
    class Program
    {
        public static float ZamYap(float fiyat)
        {
            if (fiyat >= 500 && fiyat < 750) return fiyat *= 1.05f;
            else return fiyat *= 1.1f;
        }
        public static float KucukEvAletleri(float fiyat)
        {
            return fiyat * 1.05f + 250;
        }
        public static bool IslemeDevamEtsinMi()
        {
            Console.Write("Devam etmek istermisiniz? ");
            string cevap = Console.ReadLine();
            if (cevap == "evet" || cevap == "EVET" || cevap == "Evet") return true;
            else return false;
        }
        public static int Fatura(int fiyat,int kdv)
        {
            fiyat += fiyat * kdv / 100;
            fiyat=Indirim(fiyat);
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
        public static int Indirim(int fatura)
        {
            Console.Write("İndirim tutarını giriniz: ");
            int indirim = Convert.ToInt32(Console.ReadLine());
            int fiyat = 0;
                fiyat-=indirim;
            return fiyat;
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
                    Console.WriteLine(Fatura(fiyat, kdv));
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
                        Console.WriteLine(Fatura(fiyat1, kdv1)); 
                    }
                    break;

                case '3':
                    Console.WriteLine("1- Mutfak aletleri");
                    Console.WriteLine("2- Küçük ev aletleri");
                    Console.Write("Bir seçim yapınız: ");
                    char secenek = Convert.ToChar(Console.ReadLine());
                    switch (secenek)
                    {
                        case '1':
                            Console.Write("Fiyatı giriniz: ");
                            float ucret = Convert.ToSingle(Console.ReadLine());
                            float tutar = ZamYap(ucret);
                            Console.WriteLine(tutar);
                            break;
                        case '2':
                            Console.Write("Fiyatı giriniz: ");
                            float a = Convert.ToSingle(Console.ReadLine());
                            float b = KucukEvAletleri(a);
                            Console.WriteLine(b);
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
