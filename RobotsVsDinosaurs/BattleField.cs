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
        List<Robot> robotList;
        List<Dinosaur> dinoList;
        //public Robot newRobot;
        public BattleField()
        {
            robotFleet = new Fleet();
            dinosaurHerd = new Herd();
            robotList = new List<Robot> { robotFleet.c3P0, robotFleet.r2, robotFleet.droideka };
            dinoList = new List<Dinosaur> { dinosaurHerd.tRex, dinosaurHerd.pterodactyl, dinosaurHerd.stegosaurus };
        }
        public void Battle()
        {
            int round = 0;
            do
            {
                round++;
                Console.WriteLine($"Round {round} Begin!! Battle !! ");
                DisplayBattlefield();
                Attack();
                
            }while (dinoList.Count > 0 && robotList.Count > 0);
            DisplayBattlefield();
            Console.ReadKey();
        }
        public void DisplayBattlefield()
        {
            DisplayRobots();
            DisplayDinos();
        }

        public void BattleRound()
        {

        }
        public void Attack()
        {
            //dinos attack each robot
            for (int i = 0; i < dinoList.Count; i++)
            {
                if(i < robotList.Count)
                {
                    robotList[i].health -= dinoList[i].attackPower;
                }
            }
            //update robot list
            for (int i = 0; i < robotList.Count; i++)
            {
                if (robotList[i].health <= 0)
                {
                    robotList.Remove(robotList[i]);
                    i--;
                }
                    
            }
            //robots attack each dino
            for (int i = 0; i < robotList.Count; i++)
            {
                if(i < dinoList.Count)
                {
                    dinoList[i].health -= robotList[i].attackPower;
                }
            }
            // update dino
            for (int i = 0; i < dinoList.Count; i++)
            {
                if (dinoList[i].health <= 0)
                {
                    dinoList.Remove(dinoList[i]);
                    i--;
                }
                
            }

        }
        public void DisplayRobots()
        {

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
