using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public Robot c3P0;
        public Robot r2;
        public Robot droideka;

        public Fleet()
        {
            c3P0= new Robot("C3-PO", new Weapon("hammer", 10));
            r2 = new Robot("R2-D2", new Weapon("tazer", 15));
            droideka = new Robot("Droideka", new Weapon("lazer", 15));

        }
        public void DisplayRobots(List<Robot> robots)
        {

            foreach (Robot robot in robots)
            {
                robot.DisplayRobot();
            }
        }


    }
}
