﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHoildays.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            return View();
        }
    }
}