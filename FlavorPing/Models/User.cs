using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavorPing.Models
{
    public class User
    {
        
        public int UserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string fName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lName { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int zip { get; set; }

        [Required]
        [Display(Name = "Phone #")]
        public int phoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public virtual List<Merchant> Merchant { get; set; }
    }
}