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
            List<int> mylist = new List<int>();
            var test = mylist[5];
            mylist[5] = test;


            ArrayList<int> alist = new ArrayList<int>();

            alist.Add(5);
            alist.Add(6);
            alist.Add(12);
            alist.Add(99);
            alist.Add(77);
            alist.Add(88);

            alist.RemoveAt(1);
            alist.RemoveAt(1);
            alist.RemoveAt(1);
            alist.RemoveAt(1);

            alist.Add(6);
            alist.Add(12);
            alist.Add(99);
            alist.Add(77);
            Console.ReadLine();
        }
    }
}
