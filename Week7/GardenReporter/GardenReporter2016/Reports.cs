using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public static class Reports
    { 
        public static String GardenArea(Garden garden)
        {
            return String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetArea().ToString());
        }

        public static String GardenBalanceOwing(Garden garden)
        {
            return String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetAccountBalance().ToString());
        }

    }
}
