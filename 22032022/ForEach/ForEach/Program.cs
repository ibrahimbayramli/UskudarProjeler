using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string harf = "aftrytr";
            string rakam = "0123";
            foreach (char karakter in harf)
            {
                Console.WriteLine(karakter);
                Console.ReadKey();
            }
            
            foreach(char rakamlar in rakam)
            {
                Console.WriteLine(rakamlar);
                Console.ReadKey();

            }
        }
    }
}
