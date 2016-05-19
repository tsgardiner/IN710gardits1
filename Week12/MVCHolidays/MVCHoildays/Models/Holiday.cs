using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHoildays.Models
{
    public class Holiday
    {
        public String Name { get; set; }
        public String Image { get; set; }
        public DateTime Date { get; set; }
        public int DaysUntil { get; set; }


        public Holiday(String name, String image, DateTime date)
        {
            Name = name;
            Image = image;
            Date = date;
        }   
    }


}