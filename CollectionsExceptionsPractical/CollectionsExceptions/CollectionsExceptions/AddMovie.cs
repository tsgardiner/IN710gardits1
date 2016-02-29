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

        public void AddMoive(TextBox addYear, TextBox addTitle, TextBox addDirector)
        {
            this.addYear = addYear;
            this.addTitle = addTitle;
            this.addDirector = addDirector;
        }

        public void AddMoiveToTable()
        {
            year = addYear.Text;
            title = addTitle.Text;
            director = addDirector.Text;
        }


    }
}
