using System;
using System.Collections.Generic;

namespace StackAndQueueAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //URLLog();
            ArithmeticExpressions();

            Console.ReadLine();
        }

        static void URLLog()
        {
            string input = Console.ReadLine();
            Stack<string> URLs = new Stack<string>();

            while (input.ToLower() != "exit")
            {
                if (input.ToLower() == "back" && URLs.Count > 0)
                {
                    URLs.Pop();
                    Console.WriteLine(URLs.Peek());
                }
                else
                {
                    URLs.Push(input);
                }

                input = Console.ReadLine();
            }
        }

        static void ArithmeticExpressions()
        {
            string input = Console.ReadLine();
            Stack<int> openBrackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(')
                {
                    openBrackets.Push(i);
                }
                else if (ch == ')')
                {
                    int beginning = openBrackets.Pop();
                    int end = i;
                    string expression = input.Substring(beginning, end - beginning + 1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
