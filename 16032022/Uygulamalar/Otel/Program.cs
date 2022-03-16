using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otel seçiniz.");
            Console.WriteLine("1- Kral odas");
            Console.WriteLine("2- Standart ekonomik oda");
            Console.WriteLine("3- VIP oda");
            char oda = Convert.ToChar(Console.ReadLine());
            Console.Write("Kalacak kişi sayısını giriniz: ");
            int kisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kalacak gün sayısını giriniz: ");
            int gun = Convert.ToInt32(Console.ReadLine());
            float fiyat;
            int secim;
            switch (oda)
            {
                case '1':
                    Console.WriteLine("Özellik seçiniz.");
                    Console.WriteLine("s- Sauna");
                    Console.WriteLine("h- Özel havuz");
                    char kral = Convert.ToChar(Console.ReadLine());
                    if (kral == 's' || kral == 'S')
                    {
                        if(kisi>2 && kisi < 8){
                            fiyat = gun * kisi;
                            fiyat -= (float)(fiyat * 7.5 / 100);
                            fiyat += fiyat * 2 / 100;
                            
                            Console.WriteLine($"Ödenecek tutar: {fiyat}");
                            
                        }
                        else
                        {
                            fiyat = gun * kisi;
                            fiyat -= fiyat * 5 / 100;
                            fiyat += fiyat / 100;
                            
                            Console.WriteLine($"Ödenecek tutar: {fiyat}");
                        }
                    }else if (kral == 'h' || kral == 'H')
                    {
                        Console.Write("Termal kaynaklardan yararlanmak istiyormusunuz? <true/false>");
                        bool termal = Convert.ToBoolean(Console.ReadLine());
                        if (termal)
                        {
                            fiyat = kisi * gun;
                            fiyat +=(float)( fiyat * 2.5 / 100);
                            fiyat += fiyat * 8 / 100;
                            Console.WriteLine($"Ödenecek tutar: {fiyat}");
                        }
                        else
                        {
                            fiyat = kisi * gun;
                            
                            fiyat += (float)(fiyat * 7.5 / 100);
                            Console.WriteLine($"Ödenecek tutar: {fiyat}");

                        }
                        
                    }
                    break;
                case '2':
                    Console.WriteLine("Konaklamak istediğiniz ayı seçiniz.");
                    Console.WriteLine("h- Haziran");
                    Console.WriteLine("t- Temmuz");
                    Console.WriteLine("a- Ağustos");
                    char ay = Convert.ToChar(Console.ReadLine());
                    if (ay == 'h' || ay == 'H')
                    {
                        fiyat = kisi * gun;
                        fiyat -= fiyat * 4 / 100;
                        fiyat += fiyat * 8 / 100;
                        Console.WriteLine($"Ödenecek tutar: {fiyat}");
                    }else if (ay == 't' || ay == 'T')
                    {
                        fiyat = kisi * gun;
                        fiyat += fiyat * 18 / 100;
                        fiyat += (float)(fiyat * 2.5 / 100);
                        Console.WriteLine($"Ödenecek tutar: {fiyat}");

                    }
                    else if (ay == 'a' || ay == 'A')
                    {
                        fiyat = kisi * gun;
                        fiyat += fiyat * 18 / 100;
                        fiyat += (float)(fiyat * 2.5 / 100);
                        fiyat += fiyat * 10 / 100;
                        Console.WriteLine($"Ödenecek tutar: {fiyat}");

                    }


                    break;
                case '3':
                    List<int> opsiyon = new List<int>(3);
                    git:
                    Console.WriteLine("Oda opsiyonunu seçiniz:");
                    Console.WriteLine("1- Açık büfe kahvaltı");
                    Console.WriteLine("2- Öğlen yemeği");
                    Console.WriteLine("3- Akşam yemeği");
                    secim = Convert.ToInt32(Console.ReadLine());
                    
                    
                    bool ekle = Convert.ToBoolean(Console.ReadLine());
                    if (opsiyon.Contains(secim))
                    {
                        Console.WriteLine("Bu opsiyonu zaten eklediniz.");
                    }
                    else
                    {
                        opsiyon.Add(secim);
                    }
                    Console.WriteLine("Opsiyon Eklemek istermisiniz? <true/false>");
                    if (ekle)
                    {
                        goto git;
                    }
                    if(opsiyon.Contains(1)&& opsiyon.Contains(2))
                    {

                    }


                    break;
                default:
                    Console.WriteLine("Geçerli bir seçim yapmadınız.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
