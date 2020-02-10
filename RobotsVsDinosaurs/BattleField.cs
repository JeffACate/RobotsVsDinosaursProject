using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class BattleField
    {
        public Fleet robotFleet;
        public Herd dinosaurHerd;
        //public Robot newRobot;
        public BattleField()
        {
            robotFleet = new Fleet();
            dinosaurHerd = new Herd();
        }
        public void Battle()
        {

            Console.WriteLine("Battle !! ");
            DisplayBattlefield();
            Console.ReadKey();
        }
        public void DisplayBattlefield()
        {
            DisplayRobots();
            DisplayDinos();
            Attack();
        }

        public void BattleRound()
        {

        }
        public void Attack()
        {
        }
        public void DisplayRobots()
        {

            List<Robot> robotList = new List<Robot> { robotFleet.c3P0, robotFleet.r2, robotFleet.droideka };
            int i = 0;
            Console.WriteLine("+--------------------------------------------+");
            Console.WriteLine("|   Robot  |  Health | Energy  |  Can Attack |");
            Console.WriteLine("|--------------------------------------------|");
            foreach (Robot bot in robotList)
            {
                bot.DisplayRobot();
                if (i == 2)
                {
                    Console.WriteLine("+--------------------------------------------+");
                }
                else
                {

                    Console.WriteLine("|--------------------------------------------|");
                    i++;
                }
            }

            Console.WriteLine();
        }
        public void DisplayDinos()
        {

            List<Dinosaur> dinoList = new List<Dinosaur> { dinosaurHerd.tRex, dinosaurHerd.pterodactyl, dinosaurHerd.stegosaurus };
            int i = 0;
            Console.WriteLine("+-----------------------------------------------+");
            Console.WriteLine("|   Dinosaur  |  Health | Energy  |  Can Attack |");
            Console.WriteLine("|-----------------------------------------------|");
            foreach (Dinosaur dino in dinoList)
            {
                dino.DisplayDinosaur();
                if (i == 2)
                {
                    Console.WriteLine("+-----------------------------------------------+");
                }
                else
                {

                    Console.WriteLine("|-----------------------------------------------|");
                    i++;
                }
            }

            Console.WriteLine();
        }
    }
}
