using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEndApplication.Controllers
{
    public class PatientLoginController : Controller
    {
        // GET: PatientLogin
        public ActionResult Index()
        {
            return View("Booking");
        }
    }
}