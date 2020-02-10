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
            c3P0= new Robot("C3-PO");
            Console.WriteLine($"Robot: {c3P0.name} chose a {c3P0.weapon.type} and has attack power of {c3P0.attackPower}");
            r2 = new Robot("R2-D2");
            Console.WriteLine($"Robot: {r2.name} chose a {r2.weapon.type} and has attack power of {r2.attackPower}");
            droideka = new Robot("Droideka");
            Console.WriteLine($"Robot: {droideka.name} chose a {droideka.weapon.type} and has attack power of {droideka.attackPower}");
            Console.ReadLine();

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
