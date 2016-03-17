using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnimalWorld
{
    public class NorthAmerica : Continent
    {
        public NorthAmerica(RichTextBox displayBox, Random randomGen, int nAnimalTypes, Graphics canvas)
            :base(displayBox, randomGen, nAnimalTypes, canvas)
        {
            animalFactory = new NorthAmericanAnimalFactory();
        }
    }

    public class Australia : Continent
    {
        public Australia(RichTextBox displayBox, Random randomGen, int nAnimalTypes, Graphics canvas)
            :base(displayBox, randomGen, nAnimalTypes, canvas)
        {
            animalFactory = new  AustralianAnimalFactory();
        }
    }
}
