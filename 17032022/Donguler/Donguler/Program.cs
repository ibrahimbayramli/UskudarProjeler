using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Faktöriyelini almak istediğiniz sayıyı giriniz: ");
            int faktoriyel = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for(int i = 1; i <= faktoriyel; i++)
            {
                result = result * i;

            }
            Console.WriteLine($"Faktoriyel değeri: {result}");
            Console.ReadKey();
        }
    }
}
