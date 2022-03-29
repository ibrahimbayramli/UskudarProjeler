using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class Kolonyalar
    {
        private string markaAdi;
        private int fiyat;
        private int uretimYili;
        private string mensei;
        // encalpsılation kapsülleme, sarmalama
        // private field propertyleri kullanıcıya açıyoruz.
        // 2 anahtar kelime var 1. get, 2. set kelimeleri
        // 1. get veriyi okur kullanıcıya döndürür.
        // 2. set ile veri atar.

        public string MarkaAdi
        {
            get { return markaAdi; }
            set { markaAdi = value; }
        }
        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value > 20 && value < 50)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Pahalı ama sen bilirsin.");
                    fiyat = value;
                }
            }
            
        }
        public int Uretim
        {
            get { return uretimYili; }
            set
            {
                if(value>2019 && value < 2022)
                {
                    uretimYili = value;
                }
                else
                {
                    Console.WriteLine("Bu yıllar olmaz...");
                }
            }
        }
    }
}
