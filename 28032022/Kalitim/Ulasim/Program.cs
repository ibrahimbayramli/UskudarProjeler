﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasim
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulasim u1 = new Ulasim();
            u1.KoltukNumarasi = 9;
            Console.WriteLine(u1.KoltukNumarasi);
            
            Console.ReadKey();
        }
    }
}
