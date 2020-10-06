using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace travelTrip.Models
{
    public class BlogPost : BaseClass
    {
        public string Title { get; set; }
        public DateTime BlogDate { get; set; }
        public string Description { get; set; }
        public string BlogImageUrl { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}