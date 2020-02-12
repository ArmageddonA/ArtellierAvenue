using ArtelierAvenue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtelierAvenue.Controllers
{
    public class ListingsController : Controller
    {
        private ArtelierAvenueEntities db = new ArtelierAvenueEntities();

        // GET: Listings
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Models()
        {
            return View();
        }

        public ActionResult Photographers()
        {
            return View();
        }

        public ActionResult Stylist()
        {
            return View();
        }

        public ActionResult MakeUpArtist()
        {
            return View();
        }

        public ActionResult ClothingRecontruction()
        {
            return View();
        }

        public ActionResult NailTechnicians()
        {
            return View();
        }

        public ActionResult HairStylist()
        {
            return View();
        }

        public ActionResult ViewServiceListing()
        {
            return View();
        }

        public ActionResult Resells()
        {
            return View();
        }

        public ActionResult Thrifts()
        {
            return View();
        }

        public ActionResult ViewProductListings()
        {
            db.Configuration.ProxyCreationEnabled = false;

            return View(db.ProductListings.ToList());
        }

        public ActionResult ViewServiceListings()
        {
            db.Configuration.ProxyCreationEnabled = false;

            return View(db.ProductListings.ToList());
        }

    }
}