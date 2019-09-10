using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle
    {
        public string Registration { get; set; }
        public Car(float f, int cap, string reg) : base(f, cap)
        {
            Registration = reg;
        }
        public override string GetInfo()
        {
            return "Beep, beep, I'm a sheep.";
        }
    }
}
