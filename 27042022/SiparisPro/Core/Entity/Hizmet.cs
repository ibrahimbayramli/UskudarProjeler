using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Core.Entity
{
    class Hizmet
    {
        public int HizmetNo { get; set; }
        public string HizmetAdi { get; set; }
        public string HizmetTanimi { get; set; }
        public double HizmetFiyat { get; set; }
        public int OzellikNo { get; set; }
    }
}
