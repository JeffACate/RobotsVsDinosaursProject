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
        public double attackPower;
        public bool canAttack;

        public Dinosaur(string type)
        {
            //this.name = name;
            this.type = type;
            health = 1000;
            energyLevel = 100;
            attackPower = 10;
            canAttack = true;
        }
        public void DisplayDinosour()
        {
            Console.WriteLine(/*$"{name}\n" +*/
                              $"{type}\n" +
                              $"{health}\n" +
                              $"{energyLevel}\n" +
                              $"{attackPower}\n" +
                              $"{canAttack.ToString()}\n");
        }
        

    }
}
