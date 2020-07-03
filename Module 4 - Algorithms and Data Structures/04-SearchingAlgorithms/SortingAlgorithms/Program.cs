using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testList = new List<string>() { "hello", "world", "test", "123", " " };
            Console.WriteLine(LinearSearch.Search(testList, "bla"));

            List<int> testList2 = new List<int>() { 0, 2, 3, 5, 6, 8, 9, 15, 20, 21 };
            Console.WriteLine(BinarySearch.Search(testList2, 20));
            Console.WriteLine(BinarySearch.Search(testList2, 22));
            Console.WriteLine(BinarySearch.Search(testList2, 4));

            Console.ReadLine();
        }
    }
}
