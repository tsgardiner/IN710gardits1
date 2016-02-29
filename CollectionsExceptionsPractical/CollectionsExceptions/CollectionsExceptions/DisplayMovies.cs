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

        public void  DisplayAll()
        {
            foreach (KeyValuePair<int, Movie> currentMovie in moviesTable)
            {
                
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
