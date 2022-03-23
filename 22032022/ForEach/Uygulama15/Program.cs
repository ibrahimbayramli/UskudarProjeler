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
            int sayi=0 ;
            
            for (int i = 0; i < 10; i++)
            {
                
                sayi = rnd.Next(0, 15);
                //Console.WriteLine(sayi);
                for (int j=0;j<i;j++)
                {
                    if (sayilar[j] == sayilar[i])
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        sayilar[i] = sayi;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadKey();
        }
    }
}
