using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasim
{
    class HavaYolu:Ulasim
    {
        private string firmaAdi;
        private string seferYeri;
        private string seferGunu;
        private int motorSayisi;
        private float bagajFiyati;
        private float bagajKg;

        public string FirmaAdi
        {
            get { return firmaAdi; }
            set { firmaAdi = value; }
        }
        public string SeferYeri
        {
            get { return seferYeri; }
            set { seferYeri = value; }
        }
        public string SeferGunu
        {
            get { return seferGunu; }
            set { seferGunu = value; }
        }
        public int MotorSayisi
        {
            get { return motorSayisi; }
            set { motorSayisi = value; }
        }
        public float BagajFiyati
        {
            get { return bagajFiyati; }
            set { bagajFiyati = value; }
        }
        public float BagajKg
        {
            get { return bagajKg; }
            set { bagajKg = value; }
        }

        public float Hv (string sirketAdi, int motorAdedi,float tutar)
        {
           
            if(sirketAdi=="pegasus" && motorAdedi > 3)
            {
                tutar *= 1.4f;
                tutar *= 1.08f;
                tutar *= 1.02f;
                return tutar;
            }else if(sirketAdi=="onurair" && motorAdedi < 3)
            {
                tutar *= 1.3f;
                tutar *= 1.08f;
                tutar *= 1.04f;
                return tutar;
            }
            else
            {
                tutar *= 1.5f;
                tutar *= 1.18f;
                tutar *= 1.01f;
                return tutar;
            }
        }
        public float BagajFiyat(float bagajTutar,float bagajYuk)
        {
            return bagajTutar * bagajYuk;
        }
        public void SeferBilgisi(string seferKonum,string gun) { 
            if(seferKonum=="Antalya" && (gun=="çarşamba" || gun == "cuma"))
            {
                Console.WriteLine("Böyle bir uçuş bulunmamaktadır.");
            }else if (seferKonum == "Ağrı" && (gun == "cumartesi" || gun == "pazar"))
            {
                Console.WriteLine($"{gun} günü Ağrıya uçuş bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Uçuşlar listeleniyor...");
            }
        }

    }
}
