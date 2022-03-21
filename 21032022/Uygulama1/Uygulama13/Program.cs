using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama13
{
    class Program
    {
        static void Main(string[] args)
        {
            float carpim = 1;
            int dongu = 1;
            do
            {
                if (dongu % 2 == 1)
                {
                    carpim *= dongu;

                }
                dongu++;
            } while (dongu <= 20);
            Console.WriteLine(carpim);
            Console.ReadKey();
        }
    }
}
