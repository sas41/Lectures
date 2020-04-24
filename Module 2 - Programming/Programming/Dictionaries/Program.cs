using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                people.Add(name, age);
            }

            foreach (var kvp in people)
            {
                Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }


            Console.WriteLine("Search For Name: ");
            string search = Console.ReadLine();
            if (people.ContainsKey(search))
            {
                Console.WriteLine($"Found: {search} - {people[search]}");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }

            Console.ReadLine();
        }
    }
}
