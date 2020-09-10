using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        public string Species { get; set; }
        protected float Energy { get; set; }
        protected float CostToMove { get; set; }
        protected float EnergyGain { get; set; }
        public Animal(string species, float initialEnergy, float costToMove, float energyGain)
        {
            Species = species;
            Energy = initialEnergy;
            CostToMove = costToMove;
            EnergyGain = energyGain;
        }
        abstract public void Move(float distanceInMeters);
        abstract public void Feed(float ammountOfFood);
        abstract public string GetSound();
    }
}
