using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace travelTrip.Models
{
    public class Contact : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}