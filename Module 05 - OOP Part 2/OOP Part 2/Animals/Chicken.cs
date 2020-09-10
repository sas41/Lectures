using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Chicken : Animal
    {
        public Chicken(string species, float initialEnergy, float costToMove, float energyGain) : base(species, initialEnergy, costToMove, energyGain)
        {
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
            return "Bwak-Bwaaak";
        }
    }
}
