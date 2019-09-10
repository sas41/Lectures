using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
        private float fuel;
        private int capacity;
        public float Fuel
        {
            get
            {
                return fuel;
            }
            set
            {
                if (value >= 0)
                {
                    fuel = value;
                }
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value > 0)
                {
                    capacity = value;
                }
            }
        }

        public Vehicle(float f, int cap)
        {
            Fuel = f;
            Capacity = cap;
        }

        virtual public string GetInfo()
        {
            return "Generic Vehicle";
        }
    }
}
