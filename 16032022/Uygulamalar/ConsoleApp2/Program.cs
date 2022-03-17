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
            List<int> deneme = new List<int>(3);
            deneme.Add(1);
            deneme.Add(2);
            Console.WriteLine(deneme.Count);
            Console.ReadKey();
        }
    }
}
