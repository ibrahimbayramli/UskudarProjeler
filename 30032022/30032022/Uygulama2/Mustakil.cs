using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    sealed class Mustakil : Ev
    {
        public int hissePayi;
        public string parselAdi;
        public int adaNo;
        public void MustakilVerileri()
        {
            
            Console.Write("Hisse payını giriniz: ");
            hissePayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Parsel adını giriniz: ");
            parselAdi = Console.ReadLine();
            Console.Write("Ada no giriniz: ");
            adaNo = Convert.ToInt32(Console.ReadLine());
            VeriCek();
            Console.WriteLine($"Hisse payınız: {hissePayi}");
            Console.WriteLine($"Parsel adınız: {parselAdi}");
            Console.WriteLine($"Ada no: {adaNo}");

        }
        public override void Teklifler(double fiyat)
        {
            Console.WriteLine("0- Boş");
            Console.WriteLine("1- Bahçe");
            Console.WriteLine("2- Ebeveyn Banyosu");
            Console.WriteLine("3- Şömine");
            Console.Write("Seçim yapınız: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 0:
                    Console.WriteLine($"Dairenizin fiyatı: {fiyat}");
                    break;
                case 1:
                    fiyat *= 1.2f;
                    Console.WriteLine($"Dairenizin fiyatı: {fiyat}");
                    break;
                case 2:
                    fiyat *= 1.03f;
                    Console.WriteLine($"Dairenizin fiyatı: {fiyat}");
                    break;
                case 3:
                    fiyat *= 1.08f;
                    Console.WriteLine($"Dairenizin fiyatı: {fiyat}");
                    break;

            }
        }
    }
}
