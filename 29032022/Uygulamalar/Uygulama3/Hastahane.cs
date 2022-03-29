using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    abstract class Hastahane
    {
        public int hastaNo;
        public string hastaAdSoyad;
        public string sgk;
        public int katkiPayi;
        public int muayeneUcreti;
        public int tahlil;
        public int receteUcreti;

        public abstract int Fark(string sgk, int tahlil);
        public virtual void Hemsire()
        {
            Console.WriteLine("Baş hemşirimiz Ahmet Bey Kayserili lendisi.");
        }
        public virtual int Odeme(int katkiPayi,int ucret)
        {
            return katkiPayi + ucret;
        }
        public void VeriAl()
        {
            Console.Write("Hasta no giriniz: ");
            hastaNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ad soyad giriniz: ");
            hastaAdSoyad = Console.ReadLine();
            Console.Write("SGK var mı: ");
            sgk = Console.ReadLine();
            Console.Write("Katkıpayı giriniz: ");
            katkiPayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Muayene ücreti giriniz: ");
            muayeneUcreti = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tahlil no giriniz: ");
            tahlil = Convert.ToInt32(Console.ReadLine());
            Console.Write("Reçete ücreti giriniz: ");
            receteUcreti = Convert.ToInt32(Console.ReadLine());
        }
        public void Bas()
        {
            Console.WriteLine($"Hasta no: {hastaNo}");
            Console.WriteLine($"Hasta ad soyad: {hastaAdSoyad}");
            Console.WriteLine($"SGK durumu: {sgk}");
            Console.WriteLine($"Katkı payı: {katkiPayi}");
            Console.WriteLine($"Muayene ücreti: {muayeneUcreti}");
            Console.WriteLine($"Tahlil: {tahlil}");
            Console.WriteLine($"Reçete ücreti: {receteUcreti}");
        }
    }
}
