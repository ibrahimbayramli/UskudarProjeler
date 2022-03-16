using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random skor = new Random();
            int fb = skor.Next(0, 3);
            int gs = skor.Next(0, 3);
            if (fb == gs)
            {
                Console.WriteLine("Berabere kaldılar...");
                Console.WriteLine($"Fenerbahçe Skor: {fb}");
                Console.WriteLine($"Galatasary Skor: {gs}");
            }
            else if (fb > gs)
            {
                Console.WriteLine("Fenerbahçe kazandı.");
                Console.WriteLine($"Fenerbahçe Skor: {fb}");
                Console.WriteLine($"Galatasary Skor: {gs}");
            }
            else
            {
                Console.WriteLine("Galatasaray kazandı.");
                Console.WriteLine($"Fenerbahçe Skor: {fb}");
                Console.WriteLine($"Galatasary Skor: {gs}");
            }
            Console.ReadKey();
        }
    }
}
