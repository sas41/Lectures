using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingCargo
{
    class Truck
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

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            private set
            {
                if (value > 0)
                {
                    capacity = value;
                }
                else
                {
                    Console.WriteLine("Capacity cannot be negative!");
                }
            }
        }

        public List<Freight> Load { get; set; }

        public Truck(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Load = new List<Freight>();
        }

        public bool TryAddFreight(Freight cargo)
        {
            if (cargo.Weight + Load.Select(x => x.Weight).Sum() <= Capacity)
            {
                Load.Add(cargo);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
