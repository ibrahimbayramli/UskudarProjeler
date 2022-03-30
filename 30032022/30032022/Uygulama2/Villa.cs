using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Villa : Ev
    {
        private string villaAdi;
        private string villaTipi;
        private string otoparkDurumu;
        private int bahceM2;

        public string VillaAdi
        {
            get { return villaAdi; }
            set { villaAdi = value; }
        }
        public string VillaTipi
        {
            get { return villaTipi; }
            set { villaTipi= value; }
        }
        public string OtoparkDurumu
        {
            get { return otoparkDurumu; }
            set { otoparkDurumu = value; }
        }
        public int BahceM2
        {
            get { return bahceM2; }
            set { 
                if (value >= 100)
                {
                    bahceM2 = value;
                }
                else
                {
                    Console.WriteLine("Bahce m2 ölçüsü minimum 100 m2 olmalıdır.");
                    bahceM2 = 100;
                    
                }
            }
        }

        public void VillaVerileri()
        {
            
            Console.Write("Villa adını giriniz: ");
            VillaAdi = Console.ReadLine();
            Console.Write("Villa tipini giriniz: ");
            VillaTipi = Console.ReadLine();
            Console.Write("Otopark durumunu giriniz: ");
            OtoparkDurumu = Console.ReadLine();
            Console.Write("Bahçe m2 değerini giriniz: ");
            BahceM2 = Convert.ToInt32(Console.ReadLine());
            VeriCek();
            Console.WriteLine($"Villanızın adı: {VillaAdi}");
            Console.WriteLine($"Villanızın tipi: {VillaTipi}");
            Console.WriteLine($"Villanızın otopark durumu: {OtoparkDurumu}");
            Console.WriteLine($"Bahçenizin m2 değeri: {BahceM2}");
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
