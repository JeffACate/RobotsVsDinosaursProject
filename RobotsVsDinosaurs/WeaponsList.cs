using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class WeaponsList
    {
        public List<Weapon> weaponsList = new List<Weapon>();
        public Weapon hammer = new Weapon("hammer", 100);
        public Weapon tazer = new Weapon("tazer", 150);
        public Weapon lazer = new Weapon("lazer", 150);
        public WeaponsList()
        {
            this.weaponsList.Add(hammer);
            this.weaponsList.Add(tazer);
            this.weaponsList.Add(lazer);
        }
    }
}
