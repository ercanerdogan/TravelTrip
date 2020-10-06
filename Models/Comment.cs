using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace travelTrip.Models
{
    public class Comment :BaseClass
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string message { get; set; }
        public BlogPost BlogPost { get; set; }

    }
}