using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{

    //Parent class for all characters
    public class Character
    {
        public static List<Character> characterList = new List<Character>();
        public string Name {get; set;}
        protected string declaim;
        public IWeaponBehaviour weapon { get; set; }


        public Character(string name)
        {
            Name = name;
        }

        public static void CreateStartingCharaters()
        {
            characterList.Add(new King("LeBron"));
            characterList.Add(new Queen("Atziri"));
            characterList.Add(new Troll("Trollolol"));
            characterList.Add(new Knight("Geralt"));
        }

    }
}
