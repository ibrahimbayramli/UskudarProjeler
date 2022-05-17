using System.ComponentModel.DataAnnotations;

namespace MVCcrud.Models
{
    public class MVCcalisanModel
    {
        public int CalisanID { get; set; }

        [Required(ErrorMessage = "AdSoyad girilmesi zorunludur!!!")]

        public string AdSoyad { get; set; }

        public string Pozisyonu { get; set; }

        public int Yasi { get; set; }

        public int? Maas { get; set; }
    }
}