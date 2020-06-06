using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2019
{
    class Car
    {
        public string CarNumber { get; private set; }
        public Car Next { get; set; }

        public Car(string cn)
        {
            CarNumber = cn;
        }

        public override string ToString()
        {
            return $"Car: {CarNumber}";
        }
    }
}
