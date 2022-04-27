using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Core.Entity;

namespace Core
{
    class Tools
    {
        private static SqlConnection baglanti =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Sipari"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }
        }

        public static bool ExecuteNonQuey(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State != ConnectionState.Open) komut.Connection.Open();
                return komut.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if(komut.Connection.State != ConnectionState.Open) komut.Connection.Close();
            }
        }

    }
}
