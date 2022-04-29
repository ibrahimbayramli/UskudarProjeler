using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class BLPersonelBilgi
    {
        public static int Ekleme(EPersonelBilgi veri)
        {
            if (veri.PersonelAdi != null && veri.PersonelAdi.Trim().Length > 0) return FPersonelBilgi.Ekleme(veri);
            return -1;
        }

        public static List<EPersonelBilgi> Listele()
        {
            return FPersonelBilgi.Listele();
        }
    }
}
