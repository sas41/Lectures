using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"E:\Projects\C#\Lectures\Module 5 - OOP Part 2\OOP Part 2\Streams\test.txt";
            StringBuilder fileLines = new StringBuilder();

            using (StreamReader reader = new StreamReader(filepath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    fileLines.Append(line);
                    fileLines.Append(Environment.NewLine);
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }

            string input = Console.ReadLine();
            while (input != "")
            {
                fileLines.Append(input);
                fileLines.Append(Environment.NewLine);
                input = Console.ReadLine();
            }

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.Write(fileLines);

                // Alternative
                //List<string> lines = fileLines.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

                //foreach (var line in lines)
                //{
                //    writer.WriteLine(line);
                //}
            }


            Console.ReadLine();
        }
    }
}
