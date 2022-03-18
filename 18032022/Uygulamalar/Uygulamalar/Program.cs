using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir komisyoncu sattığı mallardan fiyatı 50 tl ye kadar olanlardan %3 daha fazla olanlardan ise %2 komisyon almaktadır.
            //Klavyeden teker teker girilen 5 malın komisyonlarını bulup ve sonunda toplam komisyonu bulup sonunda toplam komisyonu yazdıran kodu yazın
            float toplamKomisyon = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Malın fiyatını giriniz: ");
                float fiyat = Convert.ToSingle(Console.ReadLine());
                float komisyon;
                if (fiyat <= 50)
                {
                    komisyon = (float)(fiyat * 0.03);
                    Console.WriteLine($"Komisyonunuz: {komisyon}");
                    toplamKomisyon += komisyon;
                }
                else
                {
                    komisyon = (float)(fiyat * 0.02);
                    Console.WriteLine($"Komisyonunuz: {komisyon}");
                    
                    toplamKomisyon += komisyon;
                }
            }
            Console.WriteLine($"Toplam komisyonunuz: {toplamKomisyon}");
            Console.ReadKey();
            
        }
    }
}
