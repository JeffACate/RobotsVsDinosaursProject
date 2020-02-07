using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    
    class Robot
    {
        public string name;
        public double health;           // affects power level
        public double powerLevel;       //affects if "speed" 
        public Weapon weaponType;       // To make class of weapons.
        public double attackPower;      // calculated by weapon,health, weapon type

        public Robot(string name, Weapon weaponType)
        {
            this.name = name;
            this.weaponType = weaponType;
            powerLevel = 100;
            health = 100;
            attackPower = 100;
        }
        public void DisplayRobot()
        {
            Console.WriteLine($"{name}\n" +
                              $"{health}\n" +
                              $"{powerLevel}\n" +
                              $"{weaponType.type}\n" +
                              $"{attackPower}\n");
        }


    }
}
