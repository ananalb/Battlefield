using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlefield
{
    class Program
    {
        static void Main(string[] args)
        {   
            Weapon weapon = new Weapon("sword", 100); 
            
            Robot robot1 = new Robot("Bob", 100, 10, weapon );
            Robot robot2 = new Robot("Cody", 100, 10, weapon);
            Dinosaur dinosaur1 = new Dinosaur("Theropod", 100, 100, 1000);

            Console.WriteLine(robot1.weapon.name);
            Console.WriteLine(robot2.health);
            Console.WriteLine(robot1.weapon.name);

            Console.WriteLine(dinosaur1.attackPower);
            Battlefield battlefield = new Battlefield();

            
          

        }
    }
}
