using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Boat : Vehicle
    {
        public string Nationality { get; set; }
        public Boat(float f, int cap, string nat) : base(f, cap)
        {
            Nationality = nat;
        }
    }
}
