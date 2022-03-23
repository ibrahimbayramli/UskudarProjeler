using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            string[] benimDizim = new string[metin.Length+1];
            string karakter;
            for (int i = 0; i < metin.Length+1; i++)
            {
                karakter = "";
                for (int j = 0; j <i; j++)
                {
                    karakter = karakter + Convert.ToString(metin[j]);
                }
                benimDizim[i] = karakter;
                
            }
            benimDizim[metin.Length - 1] = metin;
            for(int k = 0; k < metin.Length; k++)
            {
                Console.WriteLine(benimDizim[k]);
            }



            Console.ReadKey();
        }
    }
}
