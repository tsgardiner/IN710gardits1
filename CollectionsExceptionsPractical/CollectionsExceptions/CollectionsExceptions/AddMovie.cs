using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsExceptions
{
    class AddMovie
    {
        TextBox addYear, addTitle, addDirector;
        String year, title, director;
        Dictionary<int, Movie> movieTable;

        public AddMovie(TextBox addYear, TextBox addTitle, TextBox addDirector, Dictionary<int, Movie> movieTable)
        {
            this.addYear = addYear;
            this.addTitle = addTitle;
            this.addDirector = addDirector;
            this.movieTable = movieTable;
        }

        public void AddMoiveToTable()
        {
            year = addYear.Text;
            title = addTitle.Text;
            director = addDirector.Text;
        }


    }
}
