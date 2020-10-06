using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using travelTrip.Models;

namespace travelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var aboutContent = travelContext.AboutPages.ToList();

            
            return View(aboutContent);
        }
    }
}