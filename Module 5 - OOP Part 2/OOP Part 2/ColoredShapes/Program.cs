using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                ColoredShape temp;

                if (input[0] == "Triangle")
                {
                    temp = new Triangle(input[1], float.Parse(input[2]));
                }
                else if (input[0] == "Square")
                {
                    temp = new Square(input[1], float.Parse(input[2]));
                }
                else
                {
                    temp = new Circle(input[1], float.Parse(input[2]));
                }

                Console.WriteLine(temp.GetName() + ":");
                Console.WriteLine("Color: " + temp.Color);
                Console.WriteLine("Size: " + temp.Size);
                Console.WriteLine("Area: " + temp.GetArea());
            }

            Console.ReadLine();
        }
    }
}
