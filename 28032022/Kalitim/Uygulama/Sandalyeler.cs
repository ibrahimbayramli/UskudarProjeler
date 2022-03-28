using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
   abstract class Sandalyeler
    {
        public int urunNo;
        public string marka;
        public string model;
        public int kdv;
        public int fiyat;

        public abstract int ZamYap(string model, int fiyat);
        public abstract void KdvHesapla(int fiyat);

        public void HediyeKampanya(string marka,string model)
        {
            if (marka == "bellona" && model == "klasik")
            {
                Console.WriteLine("Ütü kazandınız.");
            }
            else
            {
                Console.WriteLine("paspas kazandınız");
            }
        }
        public void Verial()
        {
            Console.WriteLine("Sandalye No giriniz: ");
            urunNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marka giriniz: ");
            marka = Console.ReadLine();
            Console.WriteLine("Model giriniz: ");
            model = Console.ReadLine();
            Console.WriteLine("Kdv giriniz: ");
            kdv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiyat giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());


        }
        public void Bas()
        {
            Console.WriteLine("Sandalye No: "+urunNo);
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("KDV: " + kdv);
            Console.WriteLine("Fiyat: " + fiyat);
        }
    }

}
