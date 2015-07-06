using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlavorPing.Models
{
    public class MenuItems
    {
        public int ID { get; set; }

        public string ItemName { get; set; }

        public string Description { get; set; }

        public virtual Merchant Merchant { get; set; }


    }
}