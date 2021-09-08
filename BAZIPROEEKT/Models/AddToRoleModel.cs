using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BAZIPROEEKT.Models
{
    public class AddToRoleModel
    {
        public String Email { get; set; }
        public String selectedRole { get; set; }
        public List<String> roles { get; set; }
        public AddToRoleModel()
        {
            roles = new List<string>();
        }
    }
}