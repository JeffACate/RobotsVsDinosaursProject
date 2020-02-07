using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string name;
        public string type; 
        public double health;
        public double energy;
        public double attackPower;

        public Dinosaur(string name, string type)
        {
            this.name = name;
            this.type = type;
            health = 100;
            energy = 100;
            attackPower = 100;
        }
        public void DisplayDinosour()
        {
            Console.WriteLine($"{name}\n" +
                              $"{type}\n" +
                              $"{health}\n" +
                              $"{energy}\n" +
                              $"{attackPower}\n");
        }
        

    }
}
