using DogSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelector
{
    public static class DogMatcher
    {   

        public static Dog CompareDogs(Dog desiredDog, List<Dog> allDogs)
        {
            Dog closestMatch = new Dog();
            List<int> scores = new List<int>();

            foreach (Dog dog in allDogs)
            {
                
            }

           
            
            return closestMatch;
        }

    }
}