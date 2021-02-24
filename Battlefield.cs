using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlefield
{
    class Battlefield
    {
        public Fleet fleet;
        public Herd herd;

       

        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();

            
        }

        public void RunBattle()
        {
            
            while (fleet.robots.Count > 0 && herd.dinosaurs.Count > 0)
            {
                herd.dinosaurs[0].Attack(fleet.robots[0]);
                Console.WriteLine($"{herd.dinosaurs[0].type} attacks {fleet.robots[0].name}");
                Console.WriteLine($"Health Now: {fleet.robots[0].health}");
               
                if (fleet.robots[0].health <= 0)
                {
                    fleet.robots.RemoveAt(0);
                    
                    
                }

                if(fleet.robots.Count == 0)
                {
                    break;
                }
                else
                {
                    
                    fleet.robots[0].Attack(herd.dinosaurs[0]);
                    Console.WriteLine($"{fleet.robots[0].name} attacks {herd.dinosaurs[0].type}");
                    Console.WriteLine($"Health Now: {herd.dinosaurs[0].health}");
                }

                if (herd.dinosaurs[0].health < 0)
                {
                    herd.dinosaurs.RemoveAt(0);
                }

            }
            
        }
    }
}
