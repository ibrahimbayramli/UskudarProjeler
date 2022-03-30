using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class MOgrencileri
    {
        private int bolumNo;
        private string bolumAdi;
        private string bolumHocasi;
        private string kampus;

        public MOgrencileri()
        {
            bolumNo = 47;
            bolumHocasi = "ahmetcan";
            bolumAdi = "bilgisayar";
            kampus = "altunizade";
        }
        public int BolumNo
        {
            get { return bolumNo; }
            set
            {
                if (value == 5)
                {
                    bolumNo = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş varsayılan no atanacak.");
                }
            }

        }
        public string BolumAdi
        {
            get { return bolumAdi; }
            set
            {
                if (value == "endüstri") bolumAdi = value;
                else Console.WriteLine("Başka bölüm yook sabit atanan bölüm...");
            }
        }

        public string BolumHoca
        {
            get { return bolumHocasi; }
            set
            {
                if (value == "Nihal" || value == "Abdullah") bolumHocasi = value;
                else Console.WriteLine("Sistem size hoca atayacak.");
            }
        }
        public string BolumKampus
        {
            get { return kampus; }
            set
            {
                if (value == "üsküdar") kampus = value;
                else Console.WriteLine("Kampüse yönlendiriliyorsunuz...");
            }
        }


    }
}
