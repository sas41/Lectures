using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> test = new ArrayList<int>();


            //int t = test[0];
            //test[0] = 5;

            test.Add(10);
            test.Add(11);
            test.Add(12);
            test.Add(13);
            test.Add(14);

            test.RemoveAt(1);
            test.RemoveAt(1);
            test.RemoveAt(1);
            test.RemoveAt(1);

            Console.WriteLine();
        }
    }
}
