using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingCargo
{
    class Program
    {
        static void Main(string[] args)
        {
            string trucksText = Console.ReadLine();
            string freightsText = Console.ReadLine();

            Dictionary<string, Truck> trucks = new Dictionary<string,Truck>();
            Dictionary<string, Freight> templates = new Dictionary<string, Freight>();

            char[] seperator = new char[] { ';' };

            foreach (var entry in trucksText.Split(seperator, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] split = entry.Split('=');
                string name = split[0];
                int capacity = int.Parse(split[1]);
                Truck current = new Truck(name, capacity);
                trucks.Add(name, current);
            }

            foreach (var entry in freightsText.Split(seperator, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] split = entry.Split('=');
                string name = split[0];
                int weight = int.Parse(split[1]);
                Freight current = new Freight(name, weight);
                templates.Add(name, current);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else
                {
                    string[] command = input.Split();
                    string truckName = command[0];
                    string freightName = command[1];

                    if (trucks.ContainsKey(truckName) && templates.ContainsKey(freightName))
                    {
                        Freight copy = new Freight(freightName, templates[freightName].Weight);
                        bool success = trucks[truckName].TryAddFreigh(copy);

                        if (success)
                        {
                            Console.WriteLine($"{truckName} loaded {freightName}.");
                        }
                        else
                        {
                            Console.WriteLine($"{truckName} cannot load {freightName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No such Truck or Freight!");
                    }
                }
            }

            Console.WriteLine();
            foreach (var truck in trucks)
            {
                if (truck.Value.Load.Count == 0)
                {
                    Console.WriteLine($"{truck.Key} - Nothing Loaded.");
                }
                else
                {
                    Console.WriteLine($"{truck.Key} - {string.Join(", ", truck.Value.Load.Select(x => x.Name))}.");
                }
            }

            Console.ReadLine();
        }
    }
}
