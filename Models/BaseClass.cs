using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace travelTrip.Models
{
    public class BaseClass
    {
        [Key]
        public int ID { get; set; }
    }
}