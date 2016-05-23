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
            int i = 0;

            foreach (Dog dog in allDogs)
            {
                foreach (var item in dog.GetType().GetProperties())
                {
                    var value = item.GetValue(dog, null);
                    foreach (var wantedItem in desiredDog.GetType().GetProperties())
                    {
                        var wantedValue = wantedItem.GetValue(desiredDog, null);

                        if (value == wantedValue)
                        {
                            scores[i]++;
                        }
                    }
                        
                }

                i++;
            }

            int highest = scores.Max();
            closestMatch = allDogs[highest];
            
            return closestMatch;
        }

    }
}