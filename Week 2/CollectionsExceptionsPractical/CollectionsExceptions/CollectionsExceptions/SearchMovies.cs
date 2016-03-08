using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsExceptions
{
    class SearchMovies
    {
        public static Movie searchedMovie;
        TextBox tbSearchYear;
        Dictionary<int, Movie> movieTable;

        public SearchMovies(TextBox tbSearchYear, Dictionary<int, Movie> movieTable)
        {
            this.tbSearchYear = tbSearchYear;
            this.movieTable = movieTable;
        }

        public void SearchByYear()
        {
            DisplayMovies.ClearLbDisplay();             
            try
            {                  
                int searchedYear = Convert.ToInt16(tbSearchYear.Text);
                if (movieTable.TryGetValue(searchedYear, out searchedMovie))                    
                        DisplayMovies.DisplaySearch(searchedMovie);
                    else
                        MessageBox.Show("The movie searched couldn't be found. \nMake sure it's entered correctly.");                                     
            }
            catch (FormatException)
            {
                MessageBox.Show("The movie searched couldn't be found. \nMake sure it's entered correctly.");
            }             
        } //End of Search by year
    }
}
