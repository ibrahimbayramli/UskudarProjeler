using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oteller
{
    class Oteller
    {
        private string otelNo, otelAdi;
        private int otelYildiz, otelPuan, kalacagiGun;
        public float fiyat,gunlukFiyat;
        
        public string OtelAdi
        {
            get { return otelAdi; }
            set { otelAdi = value; }
        }
        public int OtelPuan
        {
            get { return otelPuan; }
            set { otelPuan = value; }
        }
        public float GunlukFiyat
        {
            get { return gunlukFiyat; }
            set { gunlukFiyat = value; }
        }
        public int KalacagiGun
        {
            get { return kalacagiGun; }
            set { kalacagiGun = value; }
        }
        public int OtelPuan
        {
            get { return otelPuan; }
            set { otelPuan = value; }
        }
        public string OtelNo
        {
            get { return otelNo; }
            set
            {

                if (value.Length == 4)
                {
                    otelNo = value;
                    Console.WriteLine($"{otelNo} numarası ile otel aranıyor.");
                }
                else
                {
                    otelNo = "0000";
                    Console.WriteLine("Geçerli bir numara giriniz.");
                }
            }
        }
        public int OtelYildiz
        {
            get { return otelYildiz; }
            set
            {
                if(value>3)
                {
                    otelYildiz = value;
                    Console.WriteLine($"{otelYildiz} yıldızlı bir otel.");
                }
                else
                {
                    Console.WriteLine($"{value} yıldızlı otel kapatılabilir.");
                }
            }
        }
        public int KalacagiGun
        {
            get { return otelYildiz; }
            set
            {
                if (value < 2) Console.WriteLine($"{value} gün otelde konaklamak için yetersizdir.");
                else otelYildiz = value;
            }
        }
        public float FaturaOde(float fiyat, int gun)
        {
            if (gun >= 3 && gun < 5)
            {
                fiyat *= (float)gun;
                fiyat *= 1.02f;
                return fiyat;
            }
            else if (gun >= 5 && gun < 8)
            {
                fiyat *= (float)gun;
                fiyat *= 1.08f;
                return fiyat;
            }
            else
            {
                fiyat *= (float)gun;
                fiyat *= 1.18f;
                return fiyat;
            }
        }
        public void EkOzellik(int otelYildizi,int otelPuan,float gunlukFiyat,int kalacagiGun)
        {
            if(otelYildiz>4 && otelPuan > 7)
            {
                Console.WriteLine("1- Sauna");
                Console.WriteLine("2- Jakuzi");
                Console.WriteLine("3- ikiside");
                Console.Write("Bir seçim yapınız: ");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        
                        gunlukFiyat *= 1.2f;
                        fiyat=FaturaOde(gunlukFiyat, kalacagiGun);
                        Console.WriteLine($"Ödeyeceğiniz tutar: {fiyat}");
                        break;
                    case 2:
                        gunlukFiyat *= 1.15f;
                        fiyat = FaturaOde(gunlukFiyat, kalacagiGun);
                        Console.WriteLine($"Ödeyeceğiniz tutar: {fiyat}");
                        break;
                    case 3:
                        gunlukFiyat *= 1.20f;
                        gunlukFiyat *= 1.125f;
                        fiyat = FaturaOde(gunlukFiyat, kalacagiGun);
                        Console.WriteLine($"Ödeyeceğiniz tutar: {fiyat}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Bu otel için ek özellik sunulmamakatadır.");
            }

        }

    }
}
