using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.youtube.com/watch?v=8LusJS5-AGo

            int maxWeight = 7;
            
            int[] weights = new int[] { 1, 3, 4, 5 };
            int[] values = new int[]  { 1, 4, 5, 7 };

            if (weights.Length != values.Length)
            {
                Console.WriteLine("Amount of items mismatch between weights array and values array.");
                return;
            }

            int itemCount = weights.Length;

            int[,] knapsack = new int[maxWeight + 1, itemCount];


            for (int item = 0; item < itemCount; item++)
            {
                for (int capacity = 1; capacity <= maxWeight; capacity++)
                {
                    if (weights[item] <= capacity)
                    {
                        int currentMax = values[item];

                        int remainder = capacity - weights[item];
                        if (item != 0)
                        {
                            currentMax += knapsack[remainder, item - 1];
                        }

                        if (item != 0 && currentMax < knapsack[capacity, item - 1])
                        {
                            knapsack[capacity, item] = knapsack[capacity, item - 1];
                        }
                        else
                        {
                            knapsack[capacity, item] = currentMax;
                        }
                    }
                    else
                    {
                        knapsack[capacity, item] = knapsack[capacity, item - 1];
                    }
                }
            }

            // Print the table (works for single digit tables)

            Console.Write("______|_");
            for (int i = 0; i <= maxWeight; i++)
            {
                Console.Write($"_{i}_|_");
            }
            Console.WriteLine();
            for (int j = 0; j < itemCount; j++)
            {
                Console.Write($"({values[j]}) {weights[j]} | ");
                for (int i = 0; i <= maxWeight; i++)
                {
                    Console.Write($" {knapsack[i, j]} | ");
                }
                Console.WriteLine();
            }
        }
    }
}
