using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BAZIPROEEKT.Models
{
    public class Rezervacija
    {
        [Key]
        [Display(Name = "RezervacijaID")]
        public int id_rezervacija { get; set; }
        [Display(Name = "Време на резервација")]
        public String vreme_na_rezervacija { get; set; }
        [Display(Name = "KlientID")]
        public String id_klient { get; set; }
        [Display(Name = "AviokompanijaID")]
        public String id_avio { get; set; }
    }
}