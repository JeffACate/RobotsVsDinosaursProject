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
        public double attackPower;
        public double attackModifier;

        // calculated by weapon,health, weapon type
        public bool canAttack;

        public Robot(string name, Weapon weaponType)
        {
            this.name = name;
            this.weaponType = weaponType;
            powerLevel = 100;
            health = 1000;
            attackModifier = 10;
            attackPower = attackModifier + powerLevel;
            canAttack = true;
        }
        public void DisplayRobot()
        {
            Console.WriteLine($"{name}\n" +
                              $"{health}\n" +
                              $"{powerLevel}\n" +
                              $"{weaponType.type}\n" +
                              $"{attackPower}\n" +
                              $"{canAttack.ToString()}");
        }


    }
}
