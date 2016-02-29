using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExceptions
{
    public class Movie
    {
        public int Year { get; set; }
        public String Title { get; set; }
        public String Director { get; set; }




        public Movie (int year, String title, String director)
        {
            Year = year;
            Title = title;
            Director = director;
        }

        public override string ToString()
        {
            //Can't have new lines in toString methods
            //Tried multiple fixes with no results.
            return String.Format("Year: " + Year.ToString() + "{0}" + " Title: " + Title + "\r\n" + " Director: " + Director, Environment.NewLine);
        }


    }
}
