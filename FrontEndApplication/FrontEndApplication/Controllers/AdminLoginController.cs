using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEndApplication.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminView
        public ActionResult Index()
        {
            return View("AdminView");
        }
    }
}