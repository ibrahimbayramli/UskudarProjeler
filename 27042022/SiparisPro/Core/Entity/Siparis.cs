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
    class Siparis
    {
        public int SiparisNo { get; set; }
        public string SiparisAdi { get; set; }
        public int MusteriNo { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }

    }
}
