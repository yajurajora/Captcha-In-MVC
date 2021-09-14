using CaptchaMvc.HtmlHelpers;
using CapthaInMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapthaInMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegistrationModel registrationModel)
        {
            if(!this.IsCaptchaValid(""))
            {
                ViewBag.ErrorMessage = "Captcha is not valid";
                return View("Index", registrationModel);
            }
            return Content("Captcha is valid!!");
        }
    }
}