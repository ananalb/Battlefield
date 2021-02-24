using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlefield
{
    class Robot
    {
        //member varialbles
        public string name;
        public double health;
        public double powerLevel;
        public Weapon weapon;
        public List<Weapon> weaponList;

        //constructor
        public Robot( string name, double health, double powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            weaponList = new List<Weapon>();
            Weapon weapon4 = new Weapon("rock", 100);
            weaponList.Add(weapon4);



        }
        //methods

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackLevel;
        }
    }
}
