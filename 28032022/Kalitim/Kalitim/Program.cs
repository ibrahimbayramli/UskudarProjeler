using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Kapsülleme
            // 2) Kalıtım
            //      a) Single - level kalıtım
            //      b) Multi - level kalıtım
            //      c) Hiyerarşik kalıtım
            // 3) Abstract
            // 4) Poliformizim
            // Construtor, sealed

            Kedigiller kedi1 = new Kedigiller();

            kedi1.nefesDurumu = "Akciğer solunumu";
            kedi1.renk = "Beyaz";
            kedi1.tip = "Süs kedisi";
            kedi1.kilo = 20;
            kedi1.cins = "Kaplan";
            kedi1.uremeZamani = "Mart";

            kedi1.Petshop();
            kedi1.Yonlendir(kedi1.kilo, kedi1.cins);

            kedi1.kmSaat = 2;
            kedi1.kosmaHizi = 100;

            Console.ReadKey();
        }
    }
}
