using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin eleman sayısını giriniz: ");
            int dizi = Convert.ToInt32(Console.ReadLine());
            string[] benimDizim = new string[dizi];
            for(int i = 0; i < dizi; i++)
            {
                Console.Write($"Dizinizin {i+1}. elemanını giriniz: ");
                benimDizim[i] = Console.ReadLine();
            }
            foreach (string item in benimDizim)
            {
                Console.Write(item+" ");

            }
            Console.ReadKey();
        }
    }
}
