using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
   abstract class Ev
    {
        public int evNo;
        public string evTipi;
        public int odaSayisi;
        public int m2;
        public int emsalBedel;
        public int arsaPayi;
        public string arsaDurumu;
        public string iskanDurumu;
        public int aidat;
        public int yoneticiUcret;
        public double fiyat;

        public void VeriCek()
        {
            Console.Write("Ev no giriniz: ");
            evNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ev tipini giriniz: ");
            evTipi = Console.ReadLine();
            Console.Write("Oda sayısı giriniz: ");
            odaSayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("m2 giriniz: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Emsal bedel giriniz: ");
            emsalBedel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Arsa payını giriniz: ");
            arsaPayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Arsa durumunu giriniz: ");
            arsaDurumu = Console.ReadLine();
            Console.Write("İskan durumunu giriniz: ");
            iskanDurumu = Console.ReadLine();
            Console.Write("Aidat giriniz: ");
            aidat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yönetici ücretini giriniz: ");
            yoneticiUcret = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fiyat giriniz: ");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Teklifler(fiyat);

            Console.WriteLine($"Ev zamı: {EvZam(odaSayisi, m2, fiyat)}");
            Console.WriteLine($"M2 fiyatı: {M2FiyatBul(arsaDurumu, iskanDurumu, m2, fiyat)}");
            
        }
        public abstract void Teklifler(double fiyat);
        public virtual double EvZam(int odaSayisi, int m2, double fiyat)
        {
            if(odaSayisi>10 && m2 > 250)
            {
                fiyat *= 1.2f;
                return fiyat;
            }
            else
            {
                fiyat *= 1.15f;
                return fiyat;
            }
        }

        public double M2FiyatBul (string arsaDurum,string iskanDurum,double m2,double fiyat)
        {
            if (arsaDurum == "var" && iskanDurum == "iskanlı") return fiyat / m2;
            else
            {
                fiyat = fiyat / m2;
                fiyat *= 0.9f;
                return fiyat;
            }
        }
    }
}
