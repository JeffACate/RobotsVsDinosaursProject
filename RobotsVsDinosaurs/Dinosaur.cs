using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //public string name;
        public string type; 
        public double health;
        public double energyLevel;
        public double attackModifier;
        public bool canAttack;
        public double attackPower;
        public AttacksList attackList;
        public Attack attack;

        public Dinosaur(string type)
        {
            //this.name = name;
            this.type = type;
            attackList = new AttacksList();
            health = 1000;
            energyLevel = 100;
            attackModifier = 10;
            canAttack = true;
            attackPower = this.attackModifier + this.energyLevel;

        }
        public void DisplayDinosaur()
        {
            string space = "      ";
            if (type != "T-rex")
            {
                space = "";
            }
            Console.WriteLine($"|{space}{type}  |  {health}   |  {energyLevel}    |   {canAttack}      |");
            
        }
        public void ChoseAttack()
        {
            Console.Write($"Chose an attack(Bite | Kick | Scratch |) for {type}: ");
            string choice = Console.ReadLine().ToLower();
            while (choice != "bite" && choice != "kick" && choice != "scratch")
            {
                Console.WriteLine("Invaid weapon selection!!");
                choice = Console.ReadLine().ToLower();
            }
            switch (choice)
            {
                case "bite":
                    attack = attackList.kick;
                    break;
                case "kick":
                    attack = attackList.kick;
                    break;
                case "lazer":
                    attack =  attackList.scratch;
                    break;
            }

        }

    }
}
