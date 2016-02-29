using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExceptions
{
    class MovieDictionaryInit
    {
        Dictionary<int, Movie> movieTable = new Dictionary<int, Movie>();
        public Dictionary<int, Movie> MovieTable { get; set; }

        public MovieDictionaryInit()
        {
            createMovieTable();
        }

        public void createMovieTable()
        {                                                                      

        Movie movie1 = new Movie(1961, "West SideStory", "Jerome Robbins");
        Movie movie2 = new Movie(1972, "The Godfather", "Francis Ford Coppola");
        Movie movie3 = new Movie(1984, "Amadeus", "Milos Forman");
        Movie movie4 = new Movie(2007, "No Country for Old Men", "Ethan & Joel Coen");

        movieTable.Add(movie1.Year, movie1);
        movieTable.Add(movie2.Year, movie2);
        movieTable.Add(movie3.Year, movie3);
        movieTable.Add(movie4.Year, movie4);     

        }

    }
}
