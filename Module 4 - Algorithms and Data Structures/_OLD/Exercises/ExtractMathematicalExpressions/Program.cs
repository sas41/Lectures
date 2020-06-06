using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMathematicalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> paranthesisIndexes = new Stack<int>();

            for (int index = 0; index < expression.Length; index++)
            {
                char currentChar = expression[index];
                if (currentChar == '(')
                {
                    paranthesisIndexes.Push(index);
                }
                else if (currentChar == ')')
                {
                    int beginning = paranthesisIndexes.Pop();
                    int end = index;
                    int difference = end - beginning + 1;

                    string subExpression = expression.Substring(beginning, difference);

                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}
