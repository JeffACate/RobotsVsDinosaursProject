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
        public bool canAttack;
        public WeaponsList armory;

        public Robot(string name)
        {
            this.name = name;
            powerLevel = 100;
            health = 1000;
            armory = new WeaponsList();
            weapon = ChoseWeapon();
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

        Weapon ChoseWeapon()
        {
            Weapon selectedWeapon = armory.lazer;
            Console.Write($"Chose a weapon(Hammer | Tazer | Lazer |) for {name}: ");
            string choice = Console.ReadLine().ToLower();
            while (choice != "hammer" && choice != "tazer" && choice != "lazer")
            {
                Console.WriteLine("Invaid weapon selection!!");
                choice = Console.ReadLine().ToLower();
            }
            switch (choice)
            {
                case "hammer":
                    selectedWeapon = armory.hammer;
                    break;
                case "tazer":
                    selectedWeapon = armory.tazer;
                    break;
                case "lazer":
                    selectedWeapon = armory.lazer;
                    break;
            }
            return selectedWeapon;
        }


    }
}
