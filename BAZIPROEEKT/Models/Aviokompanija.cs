using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BAZIPROEEKT.Models
{
    public class Aviokompanija
    {
        [Key]
        [Display(Name = "AviokompanijaID")]
        public int id_avio { get; set; }
        [Display(Name = "Име")]
        public String ime { get; set; }
        [Display(Name = "Држава")]
        public String drzava { get; set; }
       
    
        
    
    }
}