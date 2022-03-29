using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliFormizim
{
    class Program
    {
        static void Main(string[] args)
        {/*
          Poliformizim çok şekillilik çok biçimlilik
            virtual ---> sanal ana class
            override---> yavru classlarda var olan methodu ez 
         */
            Console.WriteLine("1 --------------------\n");
            Fransiz f1 = new Fransiz();            
            f1.SelamVer();
            Console.WriteLine();
            Console.WriteLine("2 --------------------\n");
            Turk t1 = new Turk();            
            t1.SelamVer();
            Console.WriteLine();
            Console.WriteLine("3 --------------------\n");
            Ingiliz i1 = new Ingiliz();
            i1.SelamVer();
            Console.ReadKey();
        }
    }
}
