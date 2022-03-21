using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;
            do
            {
                Console.WriteLine(sayi);
                sayi++;
            } while (sayi < 1);
            Console.ReadKey();
        }
    }
}
