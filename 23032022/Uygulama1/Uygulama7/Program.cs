using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama7
{
    class Program
    {
        public static string Buyuk (int a,int b)
        {
            if (a > b) return $"{a} sayısı en büyük";
            else return $"{b} sayısı en büyük";
        }
        static void Main(string[] args)
        {
            string sonuc = Buyuk(10, 20);
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
