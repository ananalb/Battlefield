using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlefield
{
    class Fleet
    {

        public List<Robot> robots;
        

        public Fleet()
        {
            robots = new List<Robot>();
            Weapon weapon = new Weapon("laser", 100);
            Robot robot1 = new Robot("Bob", 1000, 10, weapon);
            Weapon weapon1 = new Weapon("sword", 100);
            Robot robot2 = new Robot("Rudy", 1000, 10, weapon1);
            Weapon weapon2 = new Weapon("tazer", 100);
            Robot robot3 = new Robot("Mike", 1000, 10, weapon2);
           


            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
           
            
            
        }
    }
}
