using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Daire");
            Console.WriteLine("2- Villa");
            Console.WriteLine("3- Müstakil");

            Console.Write("Bir seçim yapınız: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            switch (sec)
            {
                case 1:
                    Daire d1 = new Daire();
                    d1.EvVerileri();
                    break;
                case 2:
                    Villa v1 = new Villa();
                    v1.VillaVerileri();
                    break;
                case 3:
                    Mustakil m1 = new Mustakil();
                    m1.MustakilVerileri();
                    break;

            }

            Console.ReadKey();
        }
    }
}
