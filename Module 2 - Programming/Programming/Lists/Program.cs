using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of integers:
            List<int> myNumbers = new List<int>();

            // Initial Count is 0.
            Console.WriteLine("Count: " +  myNumbers.Count);
            // Initial Capacity is 0.
            Console.WriteLine("Capacity: " + myNumbers.Capacity);

            // Add a number to the list:
            myNumbers.Add(5);

            // Randomly generate 17 integers between 1 and 100.
            int numCount = 17;
            Random random = new Random();
            for (int i = 0; i < numCount; i++)
            {
                // Adding an element to a List:
                myNumbers.Add(random.Next(1,100));
            }


            // Count is 18, as expected.
            Console.WriteLine("Count: " + myNumbers.Count);

            // Capacity is 32, because the capacity of a List
            // doubles whenever it runs out of capacity, so
            // it starts with, say 4 capacity, when a 5th
            // item is about to be added, the capacity is
            // doubled to 8, same with the 9th, 17th and 33rd
            // elements and so on.
            Console.WriteLine("Capacity: " + myNumbers.Capacity);


            // How to read elements of a List using a for loop:
            for (int i = 0; i < myNumbers.Count; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            // How to read elements of a List using a foreach loop:
            foreach (int number in myNumbers)
            {
                Console.WriteLine(number);
            }


            // Removing the 3rd element of a List:
            myNumbers.RemoveAt(2);

            // Removing the first occurrence of the number 5:
            myNumbers.Remove(5);

            // Inserting an element at the 4th position:
            myNumbers.Insert(3, 5);

            // Sorting a List:
            myNumbers.Sort();

            // Reversing the order of the elements:
            myNumbers.Reverse();

            Console.ReadLine();

        }
    }
}
