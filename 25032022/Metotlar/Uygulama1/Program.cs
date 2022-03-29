using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            Asker a1 = new Asker();
            Console.Write("Askerin adsoyad bilgilerini giriniz: ");
            a1.adSoyad = Console.ReadLine();
            Console.Write("Askerin mesleğini giriniz: ");
            a1.meslek = Console.ReadLine();
            Console.Write("Askerin mezuniyet durumunu giriniz: ");
            a1.mezuniyet = Console.ReadLine();
            Console.Write("Askerin yaşını giriniz: ");
            a1.yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Askerin günlük maaşını giriniz: ");
            a1.gunluk = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"{a1.adSoyad} isimli askerin aylık maaşı: {a1.MaasHesapla(a1.gunluk)}");
            a1.CarsiIzni(a1.meslek);

            Console.ReadKey(); 


        }
    }
}
