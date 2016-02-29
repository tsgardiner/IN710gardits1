using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsExceptions
{
    class DeleteMovie
    {
        Dictionary<int, Movie> movieTable;
        public DeleteMovie(TextBox tbToDelete, Dictionary<int, Movie> movieTable)
        {
            this.movieTable = movieTable;
        }

        public void DeleteSearchedMovie()
        {
            
        }
    }
}
