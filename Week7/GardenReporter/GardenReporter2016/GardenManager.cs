using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {   
        public delegate String DGarden(Garden garden);

        private List<Garden> gardensList;
        private ListBox displayBox;

        public GardenManager(ListBox displayBox)
        {
            this.displayBox = displayBox;
            gardensList = new List<Garden>();            
        }

        public void AddGarden(Garden garden)
        {
            gardensList.Add(garden);
        }

        public void ProcessGardens(DGarden dgarden)
        {
            displayBox.Items.Clear();
            foreach (Garden garden in gardensList)
            {
                displayBox.Items.Add(dgarden(garden));
            }
        }

    }
}
