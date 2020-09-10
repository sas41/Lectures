using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal, IPet, IYeetable
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public float Joy { get; set; }

        public Cat(string species, float initialEnergy, float costToMove, float energyGain, string name, string owner, float initialJoy) : base(species, initialEnergy, costToMove, energyGain)
        {
            Name = name;
            Owner = owner;
            Joy = initialJoy;
        }

        public override void Feed(float ammountOfFood)
        {
            Energy += ammountOfFood * EnergyGain;
        }

        public override void Move(float distanceInMeters)
        {
            Energy -= distanceInMeters * CostToMove;
        }
        public override string GetSound()
        {
            return "Meow";
        }

        public void Play()
        {
            Joy += 1f;
            Console.WriteLine("You pet the cat, it scratches you!");
        }
        public void Yeet()
        {
            Console.WriteLine("You throw the cat, it lands on it's feet.");
        }
    }
}
