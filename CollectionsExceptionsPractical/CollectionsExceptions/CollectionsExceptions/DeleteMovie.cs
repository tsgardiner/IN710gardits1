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
            DialogResult deleteConfirm = MessageBox.Show(
                "Are you sure you want to delete this movie?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (deleteConfirm == DialogResult.Yes)
            {
                movieTable.Remove(SearchMovies.searchedMovie.Year);
                MessageBox.Show("Movie deleted successfully.");
                DisplayMovies.ClearLbDisplay();
            }
         } // End of Delete
    }
}
