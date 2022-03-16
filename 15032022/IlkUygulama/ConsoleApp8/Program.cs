using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vize notunu giriniz: ");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final notunu giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());
            double ortalama = vize * 0.4 + final * 0.6;

            if (ortalama > 50)
            {
                Console.WriteLine("Tebrikler geçtiniz.");
            }
            else
            {
                Console.Write("Bütünleme notunu giriniz: ");
                int but = Convert.ToInt32(Console.ReadLine());
                ortalama = vize * 0.4 + but * 0.6;
                if (ortalama > 50)
                {
                    Console.WriteLine("Tebrikler geçtiniz.");
                }
                else
                {
                    Console.WriteLine("Kaldınız.");
                }

            }

            Console.ReadKey();
        }
    }
}
