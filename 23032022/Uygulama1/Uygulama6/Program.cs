using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6
{
    class Program
    {
        public static int KareAl(int sayi)
        {
            return sayi * sayi;
        }
        static void Main(string[] args)
        {
            int sonuc = KareAl(10);
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
