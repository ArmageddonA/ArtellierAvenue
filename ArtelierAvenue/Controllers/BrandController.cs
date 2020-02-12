using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtelierAvenue.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterBrand()
        {
            return View();
        }

        public ActionResult AboutTheBrand()
        {
            return View();
        }
    }
}