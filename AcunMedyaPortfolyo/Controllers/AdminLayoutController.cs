﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class AdminLayoutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialHead()
        {
            return PartialView("PartialHead");
        }
        public ActionResult PartialMenu()
        {
            return PartialView("PartialMenu");
        }
        public ActionResult PartialScript()
        {
            return PartialView("PartialScript");
        }
    }
}