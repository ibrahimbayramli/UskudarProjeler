using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama10
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            while (true)
            {
                Console.Write("Bir harf girin: ");
                char harf = Convert.ToChar(Console.ReadLine());
                if (harf == 'i')
                {
                    result += "i";
                    break;
                }
                result += Convert.ToString(harf);

            }
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
