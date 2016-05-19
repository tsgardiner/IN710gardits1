using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHoildays.Models;

namespace MVCHoildays.Controllers
{
    public class HolidayController : Controller
    {

        private List<Holiday> holidays;
        private Holiday selectedHoliday;
        private Random random;

        // GET: Holiday
        public ActionResult Index()
        {   
            holidays = new List<Holiday>();
            random = new Random();

            InsertHolidays();

            selectedHoliday = holidays[random.Next(holidays.Count)];
            
            CalculateDaysUntil();  

            return View(selectedHoliday);
        }

        private void InsertHolidays()
        {
            CreateHoliday("Queen's Birthday", "queensBirthdayImage.jpg", new DateTime(DateTime.Now.Year, 06, 06));
            CreateHoliday("Boxing Day", "boxingDayImage.jpg", new DateTime(DateTime.Now.Year, 12, 26));
            CreateHoliday("Halloween", "halloweenImage.jpg", new DateTime(DateTime.Now.Year, 10, 31));
        }

        private void CreateHoliday(String name, String image, DateTime date)
        {
            holidays.Add(new Holiday(name, image, date));
        }

        private void CalculateDaysUntil()
        {
            selectedHoliday.DaysUntil = (int)(selectedHoliday.Date - DateTime.Now).TotalDays;
        }
    }
}