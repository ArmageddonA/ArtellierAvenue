﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtelierAvenue.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult UserOrders()
        {
            return View();
        }
    }
}