﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspExample1.Controllers
{
    public class BlankController : Controller
    {
        // GET: Blank
        public ActionResult Index()
        {
            return View();
        }
    }
}