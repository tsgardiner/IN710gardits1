using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    //Character types that can exist

    public class King : Character
    {
        public King(string name) : base(name)
        {
            weapon = new Sword();
            declaim = "I am the most mighty of Kings!";
        }
    }

    public class Knight : Character
    {
        public Knight(string name) : base(name)
        {
            weapon = new Knife();
            declaim = "I am a chivalrous Knight!";
        }
    }

    public class Troll : Character
    {
        public Troll(string name) : base(name)
        {
            weapon = new Club();
            declaim = "Trolls don't have time to talk.";
        }
    }

    public class Queen : Character
    {
        public Queen(string name) : base(name)
        {
            weapon = new Bow();
            declaim = "I am the powerful Queen!";
        }
    }


}
