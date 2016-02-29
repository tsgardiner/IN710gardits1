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
        static TextBox addYear, addTitle, addDirector;
        String title, director;
        Dictionary<int, Movie> movieTable;
        int year;

        public AddMovie(TextBox AddYear, TextBox AddTitle, TextBox AddDirector, Dictionary<int, Movie> movieTable)
        {
            addYear = AddYear;
            addTitle = AddTitle;
            addDirector = AddDirector;
            this.movieTable = movieTable;
        }

        public void AddMoiveToTable()
        {
            try
            {
                year = int.Parse(addYear.Text);
                title = addTitle.Text;
                director = addDirector.Text; 
                if ((year.ToString() != "") && (title != "") && (director != ""))
                    if (!movieTable.ContainsKey(year))
                    {
                        Movie addMovieEntry = new Movie(year, title, director);
                        movieTable.Add(addMovieEntry.Year, addMovieEntry);
                        MessageBox.Show("Movie entry successfully added.");
                        DisplayMovies.DisplayAddedMovie();
                        ClearAddFields();
                    }
                    else
                    {
                        MessageBox.Show("A movie from this year already exists.");
                        ClearAddFields();
                    }
                else
                    MessageBox.Show("All fields are required.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Failed to add Movie. \nPlease make sure all fields are filled correctly.");                
            }   
        } //End of Add


        public static void ClearAddFields()
        {
            addYear.Clear();
            addTitle.Clear();
            addDirector.Clear();
        }

        
    }
}
