using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort2DArrayByColumn
{
    class Program
    {
        static void WithArrays()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int[,] data = new int[rows, columns];

            // Read row-by-row in to a list, copy list elements to the array.
            for (int i = 0; i < rows; i++)
            {
                List<int> row = Console.ReadLine().Split().Select(int.Parse).ToList();
                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = row[j];
                }
            }

            // Array to copy the ordered version to.
            int[,] ordered = new int[rows, columns];

            // Column by which to order.
            int orderColumn = int.Parse(Console.ReadLine());
            // Current column to write to in the new array.
            int progress = 0;

            // Which row has the highest value in it's selected column.
            int maxIndex = 0;

            // List of rows to ignore, because they have been copied already.
            List<int> ignored = new List<int>();


            while (progress != rows)
            {
                // Check each row...
                for (int i = 0; i < rows; i++)
                {
                    // If the row is not ignored...
                    if (!ignored.Contains(i))
                    {
                        // Check if it's larger than the current largest number.
                        if (data[i, orderColumn] > data[maxIndex, orderColumn])
                        {
                            // If it is, update the current highest row to it.
                            maxIndex = i;
                        }
                    }
                }

                // Add the current highest row to the ignored list.
                ignored.Add(maxIndex);

                // Coppy the row with the current highest number to ordered.
                for (int i = 0; i < columns; i++)
                {
                    ordered[progress, i] = data[maxIndex, i];
                }
                progress++;

                // Find the first index that is not ignored.
                maxIndex = 0;
                while (ignored.Contains(maxIndex))
                {
                    maxIndex++;

                    // If all rows are ignored, break.
                    if (maxIndex == rows)
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(ordered[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void WithLists()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            List<List<int>> data = new List<List<int>>();

            for (int i = 0; i < rows; i++)
            {
                data.Add(new List<int>());
                data[i] = Console.ReadLine().Split().Select(int.Parse).ToList();
            }

            int orderRow = int.Parse(Console.ReadLine());

            List<List<int>> ordered = data.OrderByDescending(row => row[orderRow]).ToList();

            foreach (var sublist in ordered)
            {
                Console.WriteLine(string.Join(" ", sublist));
            }

        }

        static void Main(string[] args)
        {
            //WithLists();
            WithArrays();
        }
    }
}
