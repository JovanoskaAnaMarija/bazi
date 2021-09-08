using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BAZIPROEEKT.Models
{
    public class Klient
    {
        [Key]
        [Display(Name = "KlientID")]
        public int id_klient { get; set; }
        [Display(Name = "Име")]
        public String ime { get; set; }
        [Display(Name = "UserName")]
        public String username { get; set; }
        [Display(Name = "Password")]
        public String password { get; set; }
        [Display(Name = "E-mail")]
        public String email { get; set; }
    }
}