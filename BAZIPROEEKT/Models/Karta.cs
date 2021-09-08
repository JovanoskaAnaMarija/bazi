using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BAZIPROEEKT.Models
{
    public class Karta
    {
        [Key]
        [Display(Name = "KartaID")]
        public int id_karta { get; set; }

        [Display(Name = "Датум на издавање")]
        public DateTime datum_na_izdavanje { get; set; }

        [Display(Name = "KlientID")]
        public int id_klient { get; set; }
        [Display(Name = "LetID")]
        public int id_let { get; set; }
        [Display(Name = "Дестинација Од")]
        public String destinacija_od { get; set; }
        [Display(Name = "Дестинација До")]
        public String destinacija_do { get; set; }
        [Display(Name = "Време на поаѓање")]
        public DateTime vreme_na_poaganje { get; set; }
        [Display(Name = "Цена")]
        public int cena { get; set; }
    }
}