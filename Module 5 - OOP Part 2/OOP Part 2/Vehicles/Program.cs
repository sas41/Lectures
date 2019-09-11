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
            Console.WriteLine();

            Console.WriteLine("Index to Check:");
            int index = int.Parse(Console.ReadLine());
            Vehicle vehicle = myVehicles[index];
            Console.WriteLine($"Object at Index: {index} is a {vehicle.GetType().Name}.");

            if (vehicle is Car)
            {
                Console.Write("The Car's Registration is: ");
                Console.WriteLine( ((Car)vehicle).Registration);
            }
            else if (vehicle is Boat)
            {
                Console.Write("The Boat's Nationality is: ");
                Console.WriteLine(((Boat)vehicle).Nationality);
            }
            else if (vehicle is Airplane)
            {
                Console.Write("The Plane's Callsign is: ");
                Console.WriteLine(((Airplane)vehicle).Callsign);
            }

            Console.ReadLine();
        }
    }
}
