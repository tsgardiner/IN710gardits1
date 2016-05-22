using DogSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogSelector.Controllers
{
    public class SelectorController : Controller
    {
        List<Dog> allDogs = MakeDogDatabase.makeDatabase();

        public ActionResult Index()
        {
            return View();
        }      
        
        [HttpGet]
        public ActionResult DogSelector()
        {

            return View();
        }


        [HttpPost]
        public ActionResult RecommendedDog()
        {

            return View();
        }
    }
}