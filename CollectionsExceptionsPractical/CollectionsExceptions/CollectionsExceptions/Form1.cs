﻿using System;
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
        MovieDictionary movieDictionary;
        AddMovie addMovie;
        DisplayMovies displayMovie;
        DeleteMovie deleteMovie;
        Dictionary<int, Movie> movieTable;             

        public Form1()
        {
            InitializeComponent();

            movieTable = new Dictionary<int, Movie>();
            movieDictionary = new MovieDictionary(movieTable);
            addMovie = new AddMovie(tbAddYear, tbAddTitle, tbAddDirector, movieTable);
            displayMovie = new DisplayMovies(lbDisplay, movieTable);
            deleteMovie = new DeleteMovie(movieTable);
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
            displayMovie.DisplayAll();
        }
    }
}
