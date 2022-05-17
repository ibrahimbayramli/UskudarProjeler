using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    public class MVCCalisanModel
    {
        public int CalisanID { get; set; }

        [Required(ErrorMessage = "ADSOYAD girilmesi zorunludur.")]

        public string AdSoyAd { get; set; }
        public string Pozisyon { get; set; }
        public int Yasi { get; set; }
        public int? Maas { get; set; }
    }
}