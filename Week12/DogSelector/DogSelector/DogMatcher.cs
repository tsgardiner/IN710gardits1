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
                int score = 0;
                if (desiredDog.ActivityLevel == dog.ActivityLevel)
                {
                    scores.Insert(i, score++);
                }
                if (desiredDog.CoatLength == dog.CoatLength)
                {
                    scores.Insert(i, score++);
                }
                if (desiredDog.Drools == dog.Drools)
                {
                    scores.Insert(i, score++);
                }
                if (desiredDog.GoodWithChildren == dog.GoodWithChildren)
                {
                    scores.Insert(i, score++);
                }
                if (desiredDog.IntelligenceLevel == dog.IntelligenceLevel)
                {
                    scores.Insert(i, score++);
                }
                if (desiredDog.SheddingLevel == dog.SheddingLevel)
                {
                    scores.Insert(i, score++);
                }
                if (desiredDog.Size == dog.Size)
                {
                    scores.Insert(i, score++);
                }
                if (desiredDog.GroomingLevel == dog.GroomingLevel)
                {
                    scores.Insert(i, score++);
                }

                i++;  
               
            }

            int maxIndex = scores.IndexOf(scores.Max());
            closestMatch = allDogs[maxIndex];
            
            return closestMatch;
        }

    }
}