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
            int[] benimDizim = { -1, 32, -203, 189, -1234 };
            for(int i = 0; i < benimDizim.Length; i++)
            {
                if (benimDizim[i] < 0) benimDizim[i] *= -1;
            }
            foreach (int item in benimDizim)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
