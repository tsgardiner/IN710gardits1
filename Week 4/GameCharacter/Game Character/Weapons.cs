using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    //Weapon classes that can be used by each character type

    public class Sword : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "I cleave with my sword!";
        }
    }

    public class Knife : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "I stab with my knife!";
        }
    }

    public class Bow : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "I shoot with my bow!";
        }
    }

    public class Club : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "I wack with my club!";
        }
    }
}
