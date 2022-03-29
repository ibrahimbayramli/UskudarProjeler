using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Dahiliye : Hastahane

    {
        public override int Fark(string sgk, int tahlil)
        {
            if (sgk == "var")
            {
                tahlil += tahlil * 5 / 100;
                return tahlil;
            }
            else
            {
                tahlil += tahlil * 25 / 100;
                return tahlil;
            }
        }
        public override void Hemsire()
        {
            Console.WriteLine("Dahiliye bölümümüzün hemşiri Özgür hemşirdir.");
        }
        public override int Odeme(int katkiPayi, int ucret)
        {
            return base.Odeme(katkiPayi, ucret);
        }
        public void Yazdir()
        {
            VeriAl();
            Bas();
            Hemsire();
            Console.WriteLine($"Ödeme tutarı: {Odeme(katkiPayi, muayeneUcreti)}");
            Console.WriteLine($"Ödenecek olan fark: {Fark(sgk, tahlil)}");
        }
    }
}
