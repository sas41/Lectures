using System;
using System.Dynamic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                myStack.Push(i + 1);
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(myStack.Pop());
            //}

            var test = myStack.ToArray();

            Console.ReadLine();
        }
    }
}
