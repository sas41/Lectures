using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> testSet = new List<float>() {1,2,3,4,5,6,7,8,9,10,12,13,14};

            //int result = Searching.LinearSearch(testSet, 8f);
            int result = Searching.BinarySearch(testSet, 8f);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
