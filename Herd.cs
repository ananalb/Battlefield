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
            Dinosaur dinosaur1 = new Dinosaur("Theropod", 1000, 100, 100);
            Dinosaur dinosaur2 = new Dinosaur("Allosaurus", 1000, 100, 100);
            Dinosaur dinosaur3 = new Dinosaur("Diplodocus", 1000, 100, 100);
            //Console.WriteLine(dinosaur1.energy);

            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
            
        }
    }
}
