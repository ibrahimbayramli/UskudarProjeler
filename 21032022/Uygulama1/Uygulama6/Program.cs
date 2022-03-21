using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Örn: kira hesabını yapınız.
            //    başlangıç yılı: 2006
            //    bitiş yılı: 2022
            //    kirası: 1000
            //    artış miktarı: %15
            int baslangic = 2006;
            float kira = 1000;
            while (baslangic <= 2022)
            {
                baslangic++;
                kira *= 1.15f;
            }
            Console.WriteLine(kira);
            Console.ReadKey();
        }
    }
}
