using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BAZIPROEEKT.Models
{
    public class Let
    {
        [Key]
        [Display(Name = "LetID")]

        public int id_let { get; set; }
        [Display(Name = "Дестинација Од")]
        public String destinacija_od { get; set; }
        [Display(Name = "Дестинација До")]
        public String destinacija_do { get; set; }
        [Display(Name = "Датум")]
        public DateTime datum { get; set; }
        [Display(Name = "Цена")]
        public int cena { get; set; }
        [Display(Name = "AviokompanijaID")]
        public int id_avio { get; set; }
       
    }
}