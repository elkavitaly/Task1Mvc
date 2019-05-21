using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1Mvc.Models;
using WebGrease.Css.Extensions;

namespace Task1Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Guest()
        {
            return View("Guest");
        }

        [HttpPost]
        public ActionResult Guest(FormCollection form)
        {
            return View("Guest", new Review());
        }

        public ActionResult Form(FormCollection form)
        {
            if (this.HttpContext.Request.RequestType == "POST")
            {
                return View(form);
            }
            else
            {
                ViewData["cars"] = ListItems.LoadCars();
                return View();
            }
        }
    }
}