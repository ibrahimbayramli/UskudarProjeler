using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
{
    
}

namespace Core.Entity
{
    class HizmetOzellik
    {
        public int OzellikNo { get; set; }
        public string OzellikAciklama { get; set; }
        public string OzellikEkstra { get; set; }
    }
}
