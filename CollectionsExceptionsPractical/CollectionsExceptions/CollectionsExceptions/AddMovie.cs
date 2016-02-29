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
        String title, director;
        Dictionary<int, Movie> movieTable;
        int year;

        public AddMovie(TextBox addYear, TextBox addTitle, TextBox addDirector, Dictionary<int, Movie> movieTable)
        {
            this.addYear = addYear;
            this.addTitle = addTitle;
            this.addDirector = addDirector;
            this.movieTable = movieTable;
        }

        public void AddMoiveToTable()
        {
            try
            {
                year = int.Parse(addYear.Text);
                title = addTitle.Text;
                director = addDirector.Text; 

                if (!movieTable.ContainsKey(year))
                {
                    Movie addMovieEntry = new Movie(year, title, director);
                    movieTable.Add(addMovieEntry.Year, addMovieEntry);
                    MessageBox.Show("Movie entry successfully added.");
                    clearAddFields();
                }
                else
                    MessageBox.Show("A movie from this year already exists.");
                    clearAddFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Failed to add Movie. \n Please make sure all fields are filled correctly.");                
            }   
        } //End of Add


        private void clearAddFields()
        {
            addYear.Clear();
            addTitle.Clear();
            addDirector.Clear();
        }

        
    }
}
