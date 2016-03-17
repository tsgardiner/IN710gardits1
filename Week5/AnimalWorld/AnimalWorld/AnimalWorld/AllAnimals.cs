using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Bison : Animal
    {
        public Bison()
        {
            name = "Bison";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("images/bison.jpg");
        }
    }

    public class Wolf : Animal
    {
        public Wolf()
        {
            name = "Wolf";
            family = "Canine";
            food = "Meat";
            image = new Bitmap("images/wolf.jpg");
        }
    }

    public class Eagle : Animal
    {
        public Eagle()
        {
            name = "Eagle";
            family = "Accipitridae";
            food = "Meat";
            image = new Bitmap("images/eagle.jpg");
        }
    }

    public class Koala : Animal
    {
        public Koala()
        {
            name = "Koala";
            family = "Phascolarctidae";
            food = "Eucalyptus";
            image = new Bitmap("images/koala.jpg");
        }
    }

    public class Crocodile : Animal
    {
        public Crocodile()
        {
            name = "Crocodile";
            family = "Reptile";
            food = "Meat";
            image = new Bitmap("images/crocodile.jpg");
        }
    }

    public class Kangaroo : Animal
    {
        public Kangaroo()
        {
            name = "Kangaroo";
            family = "Macropodidae";
            food = "Grass";
            image = new Bitmap("images/kangaroo.jpg");
        }
    }


}
