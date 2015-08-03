using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlavorPing.Models
{
    public class User
    {

        //Before Scaffolding notes:
        //Once this page is scaffolded there will be no list of who they follow, initially.  So a search box must show up on
        //intial submit of registration (or click a merchant tab on top).  So after saffolding that has to be set up on the UserView page.
        //Need to set it up so the Merchants followed are a link that the user can click on where it shows the menuItems
        //of thar merchant.  The menuItems will have check boxes to select.  Once selections are submitted (through submit button)
        //the merchant and the menu items ought to show up on the Userview.

        //Need to add a menu at top where it lists merchants to search.  Once clicked it will list merchants by distance
        //from users zip code or per Jason's search request.  So under the Merchant controller, when a User is logged in 
        //we need to show a different view that shows the menu items with checkboxes next to them.  Working on this....

        //Are we ready to scaffold this?
        
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