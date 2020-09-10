using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoURL
{
    class Program
    {
        static void Original()
        {
            Stack<string> URLs = new Stack<string>();
            string lastEntry = null;

            while (true)
            {
                string command = Console.ReadLine();

                if (command.ToLower() == "exit")
                {
                    break;
                }
                else if (command.ToLower() == "back")
                {
                    if (URLs.Count > 0)
                    {
                        Console.WriteLine(URLs.Pop());
                        lastEntry = null;
                    }
                }
                else
                {
                    if (lastEntry != null)
                    {
                        URLs.Push(lastEntry);
                    }
                    lastEntry = command;
                }
            }
        }

        static void Alternative()
        {

            Stack<string> history = new Stack<string>();
            string activeURL = null;

            while (true)
            {
                string command = Console.ReadLine();

                if (command.ToLower() == "exit")
                {
                    break;
                }
                else if (command.ToLower() == "back")
                {
                    if (history.Count > 0)
                    {
                        Console.Write("Current Page: ");
                        Console.WriteLine(history.Peek());
                        activeURL = history.Pop();
                        Console.WriteLine($"Pages in History: {history.Count}");
                    }
                }
                else
                {
                    if (activeURL != null)
                    {
                        history.Push(activeURL);
                    }
                    activeURL = command;
                }
            }
        }

        static void Main(string[] args)
        {
            Alternative();
        }
    }
}
