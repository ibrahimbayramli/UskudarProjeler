using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deneme = new List<int>(3);
            deneme.Add(1);
            deneme.Add(1);
            deneme.Add(1);

            Console.WriteLine(deneme.Contains(1));
            Console.ReadKey();
        }
    }
}
