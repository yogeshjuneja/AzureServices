﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            return View();
        }
    }
}