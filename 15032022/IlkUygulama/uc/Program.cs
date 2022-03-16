using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tür dönüşümü
            //Neden tür dönüşümü yaparız? C# da herşey string değer alır.
            //Bu değerleri istediğimiz tipe dönüştürmek için tür dönüşümü yaparız. Ör.: int to char gibi.

            //Console.Write("İsminizi giriniz: ");
            //string isim = Console.ReadLine();
            //Console.Write("Yaşınızı giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("İsminiz: {0}",isim);
            //Console.WriteLine("Yaşınız: {0}", yas);

            //Console.Write("Doğum yılınızı giriniz: ");
            //int dogum = Convert.ToInt32(Console.ReadLine());
            //int bugun = 2022;
            //int yas1 = bugun - dogum;
            //Console.WriteLine(yas1);
            //Console.ReadKey();

            //Console.Write("Kısa kenarı giriniz: ");
            //int kisakenar = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Uzun kenarı giriniz: ");
            //int uzunkenar = Convert.ToInt32(Console.ReadLine());
            //int alan = kisakenar * uzunkenar;
            //Console.WriteLine(alan);
            //Console.WriteLine("Cinsiyetinizi giriniz <E/K>: ");
            //char cinsiyet = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine($"Cinsiyet {cinsiyet}");
            //Console.Write("Hediye çekiniz var mı? <true/false>:");
            //bool cek = Convert.ToBoolean(Console.ReadLine());
            //Console.Write("Çek tutarını giriniz: ");
            //float cektutar = Convert.ToSingle(Console.ReadLine());

            Console.Write("Dairenin yarıçapını giriniz: ");
            float pi = (float)Math.PI;
            float r = Convert.ToSingle(Console.ReadLine());
            const float alan = pi * r * r;
            float cevre = 2 * pi * r;
            Console.WriteLine($"Dairenin Alanı: {alan}");
            Console.WriteLine($"Dairenin Çevresi: {cevre}");
            Console.WriteLine(pi);
            pi=pi+1;
            float alan1 = pi * r * r;
            float cevre1 = 2 * pi * r;
            Console.WriteLine(pi);
            Console.WriteLine($"Dairenin Alanı1: {alan1}");
            Console.WriteLine($"Dairenin Çevresi1: {cevre1}");

            Console.ReadKey();

        }
    }
}
