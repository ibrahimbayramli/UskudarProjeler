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
    class Musteri
    {
        public int MusteriNo { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public string TcNo { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public int HizmetNo { get; set; }
    }
}
