using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama15
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random rnd = new Random();
            int[] sayilar = new int[10];
            int sayi ;
            
            for (int i = 0; i < 10; i++)
            {
                git:
                sayi = rnd.Next(0, 250);
                for (int j=0;j<10;j++)
                {
                    if (sayilar[j] == sayi)
                    {
                        goto git;
                    }
                    else
                    {
                        sayilar[i] = sayi;
                    }
                }
            }
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
