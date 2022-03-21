using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            string result = "";
            for(int i = 0; i < metin.Length; i++)
            {
                result += metin[i];
                if (i == metin.Length - 1)
                {
                    break;
                }
                else
                {
                    result += "-";
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
