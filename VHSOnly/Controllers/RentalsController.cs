using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VHSOnly.Controllers
{
    public class RentalsController : Controller
    {
       
        [Route("Rentals/NewRentalForm")]
        public ActionResult New()
        {
            return View("NewRentalForm");
        }
    }
}