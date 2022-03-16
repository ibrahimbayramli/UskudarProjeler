using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
        yeniIslem:
            Console.WriteLine("****************Öz waikiki****************");
            Console.WriteLine("1-Bayan");
            Console.WriteLine("2-Erkek");
            Console.WriteLine("3-Çocuk");
            Console.WriteLine("Seçim yapınız");
            int secim = Convert.ToInt32(Console.ReadLine());
            char islem;
            string secenek;
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Bayan giyim ürünlerini seçiniz.");
                    Console.WriteLine("İç giyim");
                    Console.WriteLine("Dış giyim");
                    secenek = Console.ReadLine();

                    if (secenek == "İç giyim")
                    {
                        Console.WriteLine("Fiyat giriniz");
                        float fiyat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("İndirim fiyatı giriniz");
                        float indirim = Convert.ToSingle(Console.ReadLine());
                        fiyat -= indirim;
                        Console.WriteLine($"Ödemeniz gereken tutar: {indirim}");
                    }
                    else
                    {


                        Console.WriteLine("a-Ayakkabı");
                        Console.WriteLine("b-Çanta");
                        char sec = Convert.ToChar(Console.ReadLine());
                        switch (sec)
                        {
                            case 'a':
                                Console.WriteLine("marka seçiniz");
                                string marka = Console.ReadLine();
                                if (marka == "inci" || marka == "kemal tanca")
                                {
                                    Console.WriteLine("Tebrikler %25 indirim kazandınız. HEMEN ALLL");
                                    Console.WriteLine("Ayakkabı Fiyatı giriniz: ");
                                    float fiyat = Convert.ToSingle(Console.ReadLine());
                                    fiyat -= fiyat * 25 / 100;
                                }
                                break;
                        }

                    }
                    break;


                case 2:
                    Console.WriteLine("Erkek giyim ürünlerini seçiniz.");
                    Console.WriteLine("q-Spor giyim");
                    Console.WriteLine("b-Dış Giyim");
                    char es = Convert.ToChar(Console.ReadLine());
                    switch (es)
                    {
                        
                    }
            break;
                case 3:
                    Console.WriteLine("Çocuk giyim ürünlerini seçiniz.");

            break;
            default:
                    Console.WriteLine("Böyle bir seçim yok");
            Console.WriteLine("İşleme devam etmek istermisinzi? <E/H>");
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == 'e' || islem == 'E')
            {
                goto yeniIslem;
            }
            else
            {
                Console.WriteLine("Yine bekleriz...");
                Environment.Exit(0);

                break;
            }

            break; }

                    Console.WriteLine("Alışverişe devam etmek istermisinzi? <E/H>");
                    islem = Convert.ToChar(Console.ReadLine());
                    if (islem == 'e' || islem == 'E')
                    {
                        goto yeniIslem;
                    }
                    else
                    {
                        Console.WriteLine("Yine bekleriz...");
                        Environment.Exit(0);
                    }
                    Console.ReadLine();
           
        }
    }
}
