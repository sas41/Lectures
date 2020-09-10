using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RNGList myList = new RNGList() { "One", "Two", "Three", "Four", "Five" };
            Console.WriteLine(myList.RandomString());
            Console.WriteLine(string.Join(" ~ ", myList.ToArray()));
            Console.WriteLine("=====================");
            Console.WriteLine(myList.RandomString());
            Console.WriteLine(string.Join(" ~ ", myList.ToArray()));
            Console.WriteLine("=====================");
            Console.WriteLine(myList.RandomString());
            Console.WriteLine(string.Join(" ~ ", myList.ToArray()));
            Console.WriteLine("=====================");
            Console.WriteLine(myList.RandomString());
            Console.WriteLine(string.Join(" ~ ", myList.ToArray()));
            Console.WriteLine("=====================");
            Console.WriteLine(myList.RandomString());
            Console.WriteLine(string.Join(" ~ ", myList.ToArray()));
            Console.WriteLine("=====================");

            Console.ReadLine();
        }
    }
}
