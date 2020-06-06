using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> mylist = new List<int>();
            //mylist[5];


            ArrayList<int> alist = new ArrayList<int>();

            alist.Add(5);
            alist.Add(6);
            alist.Add(12);
            alist.Add(99);
            alist.Add(77);
            alist.Add(88);

            var test = alist[99];

            alist.RemoveAt(1);

            Console.ReadLine();
        }
    }
}
