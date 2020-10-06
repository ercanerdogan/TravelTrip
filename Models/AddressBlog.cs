using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace travelTrip.Models
{
    public class AddressBlog:BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string FullAddress { get; set; }
        public string email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
    }
}