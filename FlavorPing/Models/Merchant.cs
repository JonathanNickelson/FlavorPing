using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavorPing.Models
{
    public class Merchant
    {

        //Are we ready to scaffold this?
        //When registering as a Merchant1 and Merchant2 the same menuItems are being listed.  THis shouldn't happen.
        //Is it because we haven't scaffolded and set up the DB?  Try that first before trouble shooting other ways.


        public int MerchantID { get; set; }

        [Required]
        [Display(Name = "Business Name")]
        public string MerchantName { get; set; }

        //Should we do a state Drop Down?
        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

   

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