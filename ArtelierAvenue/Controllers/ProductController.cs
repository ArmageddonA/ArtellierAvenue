using ArtelierAvenue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtelierAvenue.Controllers
{
    public class ProductController : Controller
    {
        private ArtelierAvenueEntities db = new ArtelierAvenueEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewProduct()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult AddorEdit(int id = 0)
        {
            db.Configuration.ProxyCreationEnabled = false;
            if (id == 0)
            {
                ViewBag.Title = "Add Product";
                return View(new Product());
            }
            else
            {
                Product foundOrder = db.Products.Find(id);
                ViewBag.Title = "Edit Product";
                return View(foundOrder);
            }
        }

        public ActionResult AddorEdit(Product item)
        {
            db.Configuration.ProxyCreationEnabled = false;
            if (item.ProductID == 0)
            {
                db.Products.Add(item);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Saved Successfully";


            }
            else
            {
                Product prod = db.Products.Where(p => p.ProductID == item.ProductID).FirstOrDefault();
                prod = item; 
                db.SaveChanges();
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }

        public ActionResult ViewProducts()
        {
            db.Configuration.ProxyCreationEnabled = false;

            return View(db.Products.ToList()) ;
        }

        public ActionResult ProductsList()
        {
            return View();
        }

    }
}