﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigHub3.Controllers
{
    public class GigsController : Controller
    {
        // GET: Gigs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
           return View();
        }
    }
}