using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace blazorweb.Data;
    public class Registering
    {

        [Required]
        public String First_Name { get; set; }
        [Required]
        public String Last_Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public String Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public String ConfirmPassword { get; set; }


    }

