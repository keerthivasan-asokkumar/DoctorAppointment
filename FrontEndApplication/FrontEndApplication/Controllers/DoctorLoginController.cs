using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEndApplication.Controllers
{
    public class DoctorLoginController : Controller
    {
        // GET: DoctorLogin
        public ActionResult Index()
        {
            return View("DoctorView");
        }
    }
}