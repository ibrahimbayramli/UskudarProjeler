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
            /*
             * Nesnenin örneklenip Ram'e çıkabilmesi için Constructır metot çağırısı yapılması gerekir.
             * Yapılandırıcıların (Constructor) görevi oluşturulan nesneyi ilk kullanıma hazırlanmasıdır. C#'ta tüm sınıfların(Class) tanımlansın ya da 
             * tanımlanmasın değer tiplerine sıfır, referans tiplerine "null" değerini atayan varsayılan bir
             * yapılandırıcı vardır. Yapılandırıcı tanımlandıktan sonra varsayılan yapılandırıcı bir daha kullanılamaz. 
             * Yapılandırıcıların 
             * 
             */
            Ogrenciler ogr1 = new Ogrenciler();

            Console.WriteLine($"Öğrenci No: {ogr1.ogrNo}");
            Console.WriteLine($"Öğrenci Ad-Soyad: {ogr1.ogAdSoyad}");
            Console.ReadKey();
        }
    }
}
