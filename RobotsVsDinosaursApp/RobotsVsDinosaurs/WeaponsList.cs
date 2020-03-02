using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class WeaponsList
    {
        public Weapon hammer;
        public Weapon tazer;
        public Weapon lazer;
        public WeaponsList()
        {
            hammer = new Weapon("hammer", 10);
            tazer = new Weapon("tazer", 15);
            lazer = new Weapon("lazer", 15);

        }
    }
}
