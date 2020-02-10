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
        public Weapon weapon;       // To make class of weapons.
        public double attackPower;
        public double attackModifier;

        // calculated by weapon,health, weapon type
        public bool canAttack;

        public Robot(string name, Weapon weapon)
        {
            this.name = name;
            this.weapon = weapon;
            powerLevel = 100;
            health = 1000;
            attackModifier = 10;
            attackPower = attackModifier + powerLevel + weapon.damage;
            canAttack = true;
        }
        public void DisplayRobot()
        {
            string space = "";
            if (name != "Droideka")
            {
                space = "   ";
            }
            Console.WriteLine($"|{space}{name}  |  {health}   |  {powerLevel}    |   {canAttack}      |");
        }


    }
}
