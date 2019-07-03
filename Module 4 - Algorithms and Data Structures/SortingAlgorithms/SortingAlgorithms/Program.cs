using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class Program
    {

        static void SelectionSortTest(List<int> inputList)
        {
            inputList = Sorting.SelectionSort(inputList);
            Console.WriteLine(string.Join(" | ", inputList));
        }


        static void BubbleSortTest(List<int> inputList)
        {
            inputList = Sorting.BubbleSort(inputList);
            Console.WriteLine(string.Join(" | ", inputList));
        }

   
        static void InsertionSortTest(List<int> inputList)
        {
            inputList = Sorting.InsertionSort(inputList);
            Console.WriteLine(string.Join(" | ", inputList));
        }

        static void MergeSortTest(List<int> inputList)
        {
            inputList = Sorting.MergeSort(inputList).ToList();
            Console.WriteLine(string.Join(" | ", inputList));
        }

        static void QuickSortTest(List<int> inputList)
        {
            inputList = Sorting.QuickSort(inputList).ToList();
            Console.WriteLine(string.Join(" | ", inputList));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers or leave empty for default:");

            string input = Console.ReadLine();
            List<int> inputList;

            if (input == "")
            {
                inputList = new List<int>() { 3, 2, 1, 5, 6, 7, 9, 8, 4, 5, 2, 8, 1, 3, 0, 9, 2, 5, 6 };
            }
            else
            {
                inputList = input.Split().Select(int.Parse).ToList();
            }

            // Toggle to true to just sort using the algorithms
            if (false)
            {
                Console.WriteLine("Selection Sort:");
                SelectionSortTest(inputList);

                Console.WriteLine("Bubble Sort:");
                BubbleSortTest(inputList);

                Console.WriteLine("Insertion Sort:");
                InsertionSortTest(inputList);

                Console.WriteLine("Merge Sort:");
                MergeSortTest(inputList);

                // Quicksort is not working yet, need to work on it.
                //Console.WriteLine("Quick Sort:");
                //QuickSortTest(inputList);
            }

            // Toggle true to visualize the algortihms
            if (false)
            {
                Visualisations.InsertionSortVisualisation();

                Console.ReadLine();

                Visualisations.BubbleSortVisualisation();

                Console.ReadLine();

                Visualisations.SelectionSortVisualisation();

                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
