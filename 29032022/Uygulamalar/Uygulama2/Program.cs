using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Kalemler");
            Console.WriteLine("2- Kitaplar");
            Console.Write("Bir seçim yapın: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            float kdv;
            switch (secim)
            {
                case 1:
                    int adet;
                    string urunKodu;
                    Kalemler ka1 = new Kalemler();
                    Console.Write("Kırtasiye Nosunu giriniz: ");
                    ka1.kirtasiyeNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kırtasiye adını giriniz: ");
                    ka1.kirtasiyeAdi = Console.ReadLine();
                    Console.Write("Stok giriniz giriniz: ");
                    ka1.stok = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Malzeme adeti giriniz: ");
                    ka1.malzemeAdeti = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Fiyat giriniz: ");
                    ka1.fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Malzeme adını giriniz: ");
                    ka1.malzemeAdi = Console.ReadLine();
                    Console.WriteLine();
                    kdv=ka1.Kdv(ka1.fiyat,ka1.malzemeAdi);
                    Console.WriteLine(kdv);
                    Console.WriteLine();
                    ka1.StokTakip(ka1.malzemeAdi, ka1.stok);                    
                    Console.WriteLine();
                    Console.Write("Adet bilgisini giriniz giriniz: ");
                    ka1.adet = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ürün kodunu giriniz: ");
                    ka1.urunKodu = Console.ReadLine();
                    ka1.Siparis(ka1.malzemeAdi, ka1.adet);

                    break;
                case 2:
                    

                    Kitaplar ki1 = new Kitaplar();
                    Console.Write("Kırtasiye Nosunu giriniz: ");
                    ki1.kirtasiyeNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kırtasiye adını giriniz: ");
                    ki1.kirtasiyeAdi = Console.ReadLine();
                    Console.Write("Stok giriniz giriniz: ");
                    ki1.stok = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Malzeme adeti giriniz: ");
                    ki1.malzemeAdeti = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Fiyat giriniz: ");
                    ki1.fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Malzeme adını giriniz: ");
                    ki1.malzemeAdi = Console.ReadLine();
                    Console.WriteLine();                    
                    kdv = ki1.Kdv(ki1.fiyat, ki1.malzemeAdi);
                    Console.WriteLine(kdv);
                    Console.WriteLine();
                    ki1.StokTakip(ki1.malzemeAdi, ki1.stok);
                    Console.WriteLine();
                    Console.Write("Kitap adını giriniz: ");
                    ki1.kitapAdi = Console.ReadLine();
                    Console.Write("Yazar giriniz: ");
                    ki1.yazar = Console.ReadLine();
                    Console.Write("Satış adetini giriniz: ");
                    ki1.satisAdedi = Convert.ToInt32(Console.ReadLine());
                    ki1.CokSatanlar(ki1.satisAdedi, ki1.yazar, ki1.yazar);
                    break;
            }
            Console.ReadKey();
        }
    }
}
