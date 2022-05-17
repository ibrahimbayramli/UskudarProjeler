using System.ComponentModel.DataAnnotations;


namespace mvcCrud.Models

{
    public class mvcCalisanModel
    {

        public int CalisanID { get; set; }

        [Required(ErrorMessage = "ADSOYAD GİRİLMESİ ZORUNLUDUR!!!")]

        public string AdSoyad { get; set; }

        public string Pozisyonu { get; set; }

        public int Yasi { get; set; }

        public int Maas { get; set; }
    }
}