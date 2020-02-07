using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class BattleField
    {
        public Fleet robotFleet = new Fleet();
        public Herd dinosaurHerd = new Herd();
        //public Robot newRobot;
        public BattleField()
        {

        }
        public void Battle()
        {
            Console.WriteLine("Battle !! ");
            BattleRound();
            Console.ReadKey(); 
        }
        public void DisplayBattlefield()
        {
            robotFleet.DisplayRobots();
            dinosaurHerd.DisplayDinosaurs();
        }

        public void BattleRound()
        {
            for (int i = 0; i <= 2; i++)
            {
                robotFleet.robots[i].DisplayRobot();
                dinosaurHerd.herdDinosaurs[i].DisplayDinosour();
            }
        }

    }
}
