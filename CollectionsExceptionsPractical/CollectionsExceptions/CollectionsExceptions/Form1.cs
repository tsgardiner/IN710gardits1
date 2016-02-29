using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsExceptions
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();  
            
            MovieDictionaryInit movieTable = new MovieDictionaryInit();
            AddMovie addMovie = new AddMovie(tbAddYear, tbAddTitle, tbAddDirector, movieTable.MovieTable);
            DisplayMovies displayMovie = new DisplayMovies(lbDisplay, movieTable.MovieTable);
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {

        }
    }
}
