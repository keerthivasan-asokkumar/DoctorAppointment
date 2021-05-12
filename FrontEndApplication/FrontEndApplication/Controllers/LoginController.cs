using FrontEndApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace FrontEndApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Home");
        }

        public ActionResult Register()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Register(UserDetails user)
        {
            user.UserId = GenerateRandomNumber();

            using (var client = new HttpClient())
            {
                string value = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(value, Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("http://localhost:51860/api/userdetails");

                var response = client.PostAsync("userdetails", content);
                response.Wait();

                var result = response.Result;
                if (!result.IsSuccessStatusCode)
                {
                    return View("Success");
                }
                return View("Success");
            }
        }

        public ActionResult Patient()
        {
            return View("PatientLogin");
        }

        public ActionResult Doctor()
        {
            return View("DoctorLogin");
        }

        public ActionResult Admin()
        {
            return View("AdminLogin");
        }

        private int GenerateRandomNumber()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}