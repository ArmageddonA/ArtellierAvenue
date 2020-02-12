using ArtelierAvenue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtelierAvenue.Controllers
{
    public class ProductTypeController : Controller
    {

        private ArtelierAvenueEntities db = new ArtelierAvenueEntities();

        // GET: ProductType
        public ActionResult Index()
        {
            db.Configuration.ProxyCreationEnabled = false;

            return View(db.ProductTypes.ToList());
        }

        public ActionResult AddOrEdit()
        {
            return View();
        }

    }
}