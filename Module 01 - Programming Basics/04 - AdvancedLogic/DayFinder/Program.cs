using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday": Console.WriteLine(1); Console.WriteLine(1); break;
                case "Tuesday": Console.WriteLine(2); break;
                case "Wednesday": Console.WriteLine(3); break;
                case "Thursday": Console.WriteLine(4); break;
                case "Friday": Console.WriteLine(5); break;
                case "Saturday": Console.WriteLine(6); break;
                case "Sunday": Console.WriteLine(7); break;
                default: Console.WriteLine("?"); break;
            }
        }
    }
}
