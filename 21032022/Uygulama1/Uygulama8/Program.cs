using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8
{
    class Program
    {
        static void Main(string[] args)
        {
            //random olarak atılan 10 değerden tek olanların ve 3'e bölünenlerin adedi, diğerlerinin ise toplamını veren kod

            int sayac = 0;
            float carpim = 1;
            int dongu = 1;
            Random rnd = new Random();
            while (dongu <= 10)
            {
                int sayi = rnd.Next(1, 100);
                if (sayi % 2 ==1 && sayi % 3 == 0)
                {
                    sayac++;
                    dongu++;
                    Console.WriteLine($"Sayı(if): {sayi}");
                }
                else
                {
                    carpim =carpim*sayi;
                    
                    dongu++;
                    Console.WriteLine($"Sayı(else): {sayi}");
                }
                
            }
            Console.WriteLine($"Tek ve 3'e bölünen sayıların adedi: {sayac}");
            Console.WriteLine($"Diğer sayıların çarpımı: {carpim}");
            Console.ReadKey();

        }
    }
}
