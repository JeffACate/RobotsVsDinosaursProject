using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robot> robots = new List<Robot>();
        public WeaponsList fleetWeapons = new WeaponsList();
        public Fleet()
        {
            Robot c3P0= new Robot("C3PO", fleetWeapons.weaponsList[0]);
            Robot r2 = new Robot("R2D2", fleetWeapons.weaponsList[1]);
            Robot droideka = new Robot("Droideka", fleetWeapons.weaponsList[2]);
            //The fleet has a list of weapons
            robots.Add(c3P0);
            robots.Add(r2);
            robots.Add(droideka);

        }
        public void DisplayRobots()
        {
            foreach (Robot robot in robots)
            {
                robot.DisplayRobot();
            }
        }


    }
}
