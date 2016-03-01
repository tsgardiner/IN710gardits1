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
        static RichTextBox lbDisplay;
        Dictionary<int, Movie> moviesTable;
        

        public DisplayMovies(RichTextBox LBDisplay, Dictionary<int, Movie> moviesTable)
        {
            lbDisplay = LBDisplay;
            this.moviesTable = moviesTable;
        }

        //Display doesn't look quite right as toString method isn't responding to formatting.
        public void  DisplayAll()
        {
            lbDisplay.Clear();
            foreach (KeyValuePair<int, Movie> currentMovie in moviesTable)
            {
                lbDisplay.AppendText("Key: " + currentMovie.Key.ToString() + "\n");
                lbDisplay.AppendText(currentMovie.Value.ToString() + "\n");
                lbDisplay.AppendText("-------------------------------" +"\n");
            }
        }

        public static void DisplaySearch(Movie searchedMovie)
        {
            lbDisplay.AppendText(searchedMovie.ToString());
        }

        public static void DisplayAddedMovie()
        {

        }  
        public static void ClearLbDisplay()
        {
            lbDisplay.Clear();
        }

    }
}
