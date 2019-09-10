using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> myVehicles = new List<Vehicle>();

            Car myCar = new Car(100, 5, "P 1234 AG");
            Boat myBoat = new Boat(50, 8, "Bulgaria");
            Airplane myPlane = new Airplane(1000, 64, "BA 195AF");

            myVehicles.Add(myCar);
            myVehicles.Add(myBoat);
            myVehicles.Add(myPlane);

            foreach (var item in myVehicles)
            {
                Console.WriteLine(item.GetInfo());
            }

            Console.ReadLine();
        }
    }
}
