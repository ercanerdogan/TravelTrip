using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace travelTrip.Models
{
    public class AboutPage:BaseClass
    {
        public string ImgUrl { get; set; }
        public string Description { get; set; }
    }
}