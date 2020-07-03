using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testList = new List<int> { 2, 8, 0, -2, 9, 12, 5, 1 };
            Console.WriteLine("Linq:");
            Console.WriteLine(string.Join(", ", testList.OrderBy(x => x)));

            Console.WriteLine("Selection Sort:");
            Console.WriteLine(string.Join(", ", SelectionSort.Sort(testList)));

            Console.WriteLine("Bubble Sort:");
            Console.WriteLine(string.Join(", ", BubbleSort.Sort(testList)));

            Console.WriteLine("Insertion Sort:");
            Console.WriteLine(string.Join(", ", InsertionSort.Sort(testList)));

            Console.WriteLine("Merge Sort:");
            Console.WriteLine(string.Join(", ", MergeSort.Sort(testList)));



            List<string> testList2 = new List<string>() {"test", "alakazam", "B", "pudding" };
            Console.WriteLine("Bubble Sort (GENERIC):");
            Console.WriteLine(string.Join(", ", BubbleSort.GenericSort(testList2)));

            Console.ReadLine();
        }
    }
}
