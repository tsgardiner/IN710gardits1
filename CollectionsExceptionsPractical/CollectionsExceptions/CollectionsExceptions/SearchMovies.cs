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
        TextBox tbSearchYear;
        Dictionary<int, Movie> movieTable;

        public SearchMovies(TextBox tbSearchYear, Dictionary<int, Movie> movieTable)
        {
            this.tbSearchYear = tbSearchYear;
            this.movieTable = movieTable;
        }

        public void SearchByYear()
        {

        }
    }
}
