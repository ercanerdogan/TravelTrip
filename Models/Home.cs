using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace travelTrip.Models
{
    public class Home : BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}