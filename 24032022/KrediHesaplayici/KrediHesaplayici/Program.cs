using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediHesaplayici
{
    class Program
    {
        public static void IhtiyacKredisi(float anapara,float vade)
        {
            
            float tutar = 0;
            for(int i = 1; i <= vade; i++)
            {
                tutar = anapara;
                tutar += anapara * 0.02f;
            }
            Console.WriteLine($"Kredilerinizin toplamı {tutar}TL. Taksit tutarınız {tutar / vade}TL");
        }
        public static string ZiraatBankasi()
        {
            Console.WriteLine("1) İhtiyaç kredisi");
            Console.WriteLine("2) Konut kredisi");
            Console.Write("Bir seçim yapın: ");
            int zsecim = Convert.ToInt32(Console.ReadLine());
            float tutar = 0;
            if (zsecim == 1)
            {
                Console.Write("Anaparanızı giriniz: ");
                float anapara = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ödeme vadesini giriniz: ");
                float vade = Convert.ToSingle(Console.ReadLine());
                IhtiyacKredisi(anapara,vade);
                return "";
            }
            else
            {
                Console.WriteLine("1) 0 daire");
                Console.WriteLine("2) 2. el daire");
                Console.Write("Bir seçim yapınız: ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Lokasyon seçiniz: ");
                    Console.WriteLine(" 1) Kadıköy");
                    Console.WriteLine(" 2) Üsküdar");
                    Console.WriteLine(" 3) Şişli");
                    Console.WriteLine(" 4) Etiler");
                    Console.WriteLine(" 5) Diğer");
                    Console.Write("Bir seçim yapınız: ");
                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    if(secim2==1 || secim2 == 4)
                    {
                        Console.Write("Konutun tutarını giriniz: ");
                        tutar = Convert.ToSingle(Console.ReadLine());
                        tutar *= 1.18f;
                        tutar *= 1.045f;

                        return $"Kredilerinizin toplamı {tutar}TL. Taksit tutarınız {tutar / 120}TL";


                    }else if(secim2 == 2 || secim2 == 3)
                    {
                        Console.Write("Konutun tutarını giriniz: ");
                        tutar = Convert.ToSingle(Console.ReadLine());
                        tutar *= 1.2f;
                        tutar *= 1.035f;

                        return $"Kredilerinizin toplamı {tutar}TL. Taksit tutarınız {tutar / 120}TL";
                    }
                    else
                    {
                        Console.Write("Konutun tutarını giriniz: ");
                        tutar = Convert.ToSingle(Console.ReadLine());
                        tutar *= 1.2f;
                        

                        return $"Kredilerinizin toplamı {tutar}TL. Taksit tutarınız {tutar / 120}TL";
                    }

                }
                else
                {
                    Console.Write("Konutun tutarını giriniz: ");
                    tutar = Convert.ToSingle(Console.ReadLine());
                    tutar *= 1.0125f;


                    return $"Kredilerinizin toplamı {tutar}TL. Taksit tutarınız {tutar / 120}TL";
                }
                
            }
        }
        public static string GarantiBankasi()
        {
            Console.WriteLine("1) Bireysel müşteriler");
            Console.WriteLine("2) Kurumsal müşteriler");
            Console.Write("Bir seçim yapınız: ");
            int gsecim = Convert.ToInt32(Console.ReadLine());
            float toplam = 0;


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
                    return $"Kredilerinizin toplamı {toplam}TL. Taksit tutarınız {toplam / 20}TL";
                }

            }
            else
            {
                do
                {
                    Console.Write("Kullanıcı adınızı giriniz: ");
                    string kullanici = Console.ReadLine();
                    Console.Write("Parolanızı adınızı giriniz: ");
                    string parola = Console.ReadLine();
                    if (kullanici == "admin" && parola == "admin")
                    {
                        Console.WriteLine("Giriş başarılı.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız.");
                    }
                } while (true);
                Console.WriteLine("1) Limitet şirket");
                Console.WriteLine("2) Anonim şirket");
                int gsecim2 = Convert.ToInt32(Console.ReadLine());
                if (gsecim2 == 1)
                {
                    Console.Write("Kredi tutarını giriniz: ");
                    float tutar = Convert.ToSingle(Console.ReadLine());
                    if (tutar < 50000)
                    {
                        toplam = tutar * 1.1f;
                        toplam *= 1.03f;
                        return $"Kredilerinizin toplamı {toplam}TL. Taksit tutarınız {toplam / 68}TL";
                    }
                    else if (tutar >= 50000 && tutar < 100000)
                    {
                        toplam = tutar * 1.15f;
                        toplam *= 1.075f;
                        return $"Kredilerinizin toplamı {toplam}TL. Taksit tutarınız {toplam / 72}TL";
                    }
                    else
                    {
                        toplam = tutar * 1.2f;
                        toplam *= 1.15f;
                        return $"Kredilerinizin toplamı {toplam}TL. Taksit tutarınız {toplam / 108}TL";
                    }
                }
                else
                {
                    return "Henüz tamamlanmadı devam ediyor.";
                }
            }
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
                    string donus = GarantiBankasi();
                    Console.WriteLine(donus);
                    break;
                case 2:
                    Console.WriteLine(ZiraatBankasi());                    
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