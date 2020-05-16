using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingCargo
{
    class Freight
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (value != "" && value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty!");
                }
            }
        }

        private int weight;

        public int Weight
        {
            get { return weight; }
            private set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Weight cannot be negative!");
                }
            }
        }

        public Freight(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
