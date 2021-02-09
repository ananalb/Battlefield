using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlefield
{
    class Herd
    {
        public List<Dinosaur> dinosaurs;
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur dinosaur1 = new Dinosaur("Theropod", 100, 100, 1000);
            Dinosaur dinosaur2 = new Dinosaur("Allosaurus", 100, 100, 1000);
            Dinosaur dinosaur3 = new Dinosaur("Diplodocus", 100, 100, 1000);
            Console.WriteLine(dinosaur1.energy);

            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
            Console.WriteLine(dinosaur1.health);
            Console.WriteLine(dinosaur2.health);
            Console.WriteLine(dinosaur3.health);
        }
    }
}
