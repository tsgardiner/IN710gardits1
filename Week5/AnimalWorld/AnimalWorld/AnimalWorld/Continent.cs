using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public abstract class Continent
    {
        public const int ANIMAL_SIM_COUNT = 3;

        protected RichTextBox displayBox;
        protected Random randomGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        public Continent(RichTextBox displayBox, Random randomGen, int nAnimalTypes, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.canvas = canvas;
            this.randomGen = randomGen;
            this.nAnimalTypes = nAnimalTypes;
        }

        public void RunSimulation()
        {
            Animal currentAnimal;

            for (int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                int animalChoice = randomGen.Next(nAnimalTypes);
                currentAnimal = animalFactory.createAnimal(animalChoice);

                displayBox.AppendText(currentAnimal.ToString());
                canvas.DrawImage(currentAnimal.Image, 20, 20 + (i * 120));
            }

        }
    }
}
