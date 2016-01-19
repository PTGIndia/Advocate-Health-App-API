using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEbAPI.Models;

namespace WEbAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        Home[] Homes = new Home[] 
        { 
            new Home { DocName = "Humera", DocDescription = "Learn about how Dr. Humera Asem", DocDesignation = "MD", DocSpecialization = "GYN" }, 
            new Home { DocName = "Asem",   DocDescription = "obstetrician and gynecologist", DocDesignation = "HR", DocSpecialization ="PHN"  }, 
            new Home { DocName = "HumeraAsem", DocDescription = "Advocate Health Care,", DocDesignation = "MD", DocSpecialization = "DYN" } 
        };
        public IEnumerable<Home> GetAllHomes()
        {
            return Homes;
        }
      
    }
}
