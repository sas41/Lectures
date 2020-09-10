using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal, IPet
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public float Joy { get; set; }

        public Dog(string species, float initialEnergy, float costToMove, float energyGain, string name, string owner, float initialJoy) : base(species, initialEnergy, costToMove, energyGain)
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
            return "Woof";
        }

        public void Play()
        {
            Joy += 2.5f;
            Console.WriteLine("You pet the dog, it's happy!");
        }
    }
}
