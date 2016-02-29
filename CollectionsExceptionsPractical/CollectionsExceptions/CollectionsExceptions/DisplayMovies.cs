using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsExceptions
{
    class DisplayMovies
    {
        static ListBox lbDisplay;
        Dictionary<int, Movie> moviesTable;
        

        public DisplayMovies(ListBox LBDisplay, Dictionary<int, Movie> moviesTable)
        {
            lbDisplay = LBDisplay;
            this.moviesTable = moviesTable;
        }

        //Display doesn't look quite right as toString method isn't responding to formatting.
        public void  DisplayAll()
        {
            lbDisplay.Items.Clear();
            foreach (KeyValuePair<int, Movie> currentMovie in moviesTable)
            {
                lbDisplay.Items.Add("Key: " + currentMovie.Key.ToString());
                lbDisplay.Items.Add(currentMovie.Value.ToString());
                lbDisplay.Items.Add("-------------------------------");
            }
        }

        public static void DisplaySearch(Movie searchedMovie)
        {
            lbDisplay.Items.Add(searchedMovie.ToString());
        }

        public static void DisplayAddedMovie()
        {

        }  
        public static void ClearLbDisplay()
        {
            lbDisplay.Items.Clear();
        }

    }
}
