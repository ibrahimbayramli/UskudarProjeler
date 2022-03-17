using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Maaşınızı giriniz: ");
            int maas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürettiğiniz parça sayısını giriniz: ");
            int parca = Convert.ToInt32(Console.ReadLine());
            int prim ;
            if(parca>=10 && parca <= 25)
            {
                prim = rnd.Next(10, 21) * parca;
                Console.WriteLine($"Maaşınız: {maas}");
                Console.WriteLine($"Priminiz: {prim}");
            }else if(parca >= 26 && parca <= 40)
            {
                prim = rnd.Next(20, 26) * parca;
                Console.WriteLine($"Maaşınız: {maas}");
                Console.WriteLine($"Priminiz: {prim}");
            }
            else if (parca >= 26 && parca <= 40)
            {
                prim = rnd.Next(20, 26)*parca;
                Console.WriteLine($"Maaşınız: {maas}");
                Console.WriteLine($"Priminiz: {prim}");
            }
            else if (parca >40)
            {
                prim = rnd.Next(50, 101) * parca;
                Console.WriteLine($"Maaşınız: {maas}");
                Console.WriteLine($"Priminiz: {prim}");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız");
            }
            Console.ReadKey();
        }
    }
}
