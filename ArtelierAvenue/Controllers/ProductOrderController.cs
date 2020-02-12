using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ArtelierAvenue.Models;

namespace ArtelierAvenue.Controllers
{
    public class ProductOrderController : Controller
    {
        private ArtelierAvenueEntities db = new ArtelierAvenueEntities();
        // GET: ProductOrder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddorEdit(int id = 0)
        {
            db.Configuration.ProxyCreationEnabled = false;
            if (id == 0)
                return View(new ProductOrder());
            else
            {
                ProductOrder foundOrder = db.ProductOrders.Find(id);
                return View(foundOrder);
            }
        }


        [HttpPost]

        public ActionResult AddorEdit(ProductOrder item)
        {
            db.Configuration.ProxyCreationEnabled = false;
            if (item.ProductOrderID == 0)
            {
                db.ProductOrders.Add(item);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Saved Successfully";


            }
            else
            {
                ProductOrder newPO = db.ProductOrders.Find(item.ProductOrderID);
                newPO = item;
                db.SaveChanges();
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }

        public ActionResult ViewProductOrders()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return View(db.ProductOrders.ToList());
        }
    }
}