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
        ListBox lbDisplay;
        Dictionary<int, Movie> moviesTable;
        

        public DisplayMovies(ListBox lbDisplay, Dictionary<int, Movie> moviesTable)
        {
            this.lbDisplay = lbDisplay;
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

        public void DisplaySearch()
        {

        }

        public void DisplayAddedMovie()
        {

        }

    }
}
