using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavorPing.Models
{
    public class Merchant
    {
        public int MerchantID { get; set; }

        [Required]
        [Display(Name = "Business Name")]
        public string MerchantName { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

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

        public virtual List<MenuItems> MenuItem { get; set; }
    }
}