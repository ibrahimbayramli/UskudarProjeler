using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas > 20)
            {
                Console.WriteLine("Askere gidebilir.");
            }
            else
            {
                Console.WriteLine("Askere gidemez.");
            }
            Console.ReadKey();
        }
    }
}
