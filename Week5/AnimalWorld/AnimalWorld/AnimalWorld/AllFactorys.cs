﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    //-----------------------------------------------------------
    // American animal factory
    // Creates new animals for this Continent 
    //-----------------------------------------------------------
    public class NorthAmericanAnimalFactory : IAnimalFactory
    {  
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Bison();
                    break;
                case 1:
                    newAnimal = new Wolf();
                    break;
                case 2:
                    newAnimal = new Eagle();
                    break;                   
            }
            return newAnimal;
        }
    }// End of American Factory


    //-----------------------------------------------------------
    // Australian animal factory
    // Creates new animals for this Continent 
    //-----------------------------------------------------------
    public class AustralianAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Crocodile();
                    break;
                case 1:
                    newAnimal = new Kangaroo();
                    break;
                case 2:
                    newAnimal = new Koala();
                    break;
            }
            return newAnimal;
        }
    } // End of Australia Factory
}
