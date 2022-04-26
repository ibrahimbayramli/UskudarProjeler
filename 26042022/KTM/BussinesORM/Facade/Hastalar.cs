using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BussinesORM.Entity;
namespace BussinesORM.Facade
{
   public static class Hastalar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("HastaListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public static bool Ekle(Hasta hasta1)
        {
            SqlCommand komut = new SqlCommand("HastaEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@AdSoyad", hasta1.AdSoyad);
            komut.Parameters.AddWithValue("@Telefon", hasta1.Telefon);
            komut.Parameters.AddWithValue("@Adres", hasta1.Adres);
            komut.Parameters.AddWithValue("@Guvence", hasta1.Guvence);
            return Tools.ExecuteNonQuery(komut);
        }

        public static bool Sil(Hasta hasta1)
        {
            SqlCommand komut = new SqlCommand("HastaSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@HastaId", hasta1.HasatId);
            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Guncelle(Hasta update)
        {
            SqlCommand komut = new SqlCommand("HastaGuncelle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@HastaId", update.HasatId);
            komut.Parameters.AddWithValue("@AdSoyad", update.AdSoyad);
            komut.Parameters.AddWithValue("@Telefon", update.Telefon);
            komut.Parameters.AddWithValue("@Adres", update.Adres);
            komut.Parameters.AddWithValue("@Guvence", update.Guvence);

            return Tools.ExecuteNonQuery(komut);
        }
    }
}
