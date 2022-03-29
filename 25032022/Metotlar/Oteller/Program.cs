using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oteller
{
    class Program
    {
        static void Main(string[] args)
        {
            Oteller o1 = new Oteller();
            Console.Write("Otel adı giriniz: ");
            o1.OtelAdi = Console.ReadLine();
            Console.Write("Otel no giriniz: ");
            o1.OtelNo = Console.ReadLine();
            Console.Write("Otel yıldızını giriniz: ");
            o1.OtelYildiz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Otel puanını giriniz: ");
            o1.OtelPuan = Convert.ToInt32(Console.ReadLine());



        }
    }
}
