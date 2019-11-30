using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Figure to Draw:");
                Console.WriteLine("    1: Rectangle");
                Console.WriteLine("    2: Rectangle (Alternative)");
                Console.WriteLine("    3: Dollar Pyramid");
                Console.WriteLine("    4: Dollar Pyramid (Alternative)");
                Console.WriteLine("    5: Frame");
                Console.WriteLine("    6: Frame (Alternative)");
                Console.WriteLine("    7: Christmas Tree");
                Console.WriteLine("    8: Christmas Tree (Alternative)");
                Console.WriteLine("    9: Rhombus");
                Console.WriteLine("    0: Sunglasses");
                Console.WriteLine("Any other number to Quit.");
                Console.WriteLine("Any letter to crash.");

                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Rectangle(); break;
                    case 2: AlternativeRectangle(); break;
                    case 3: DollarPyramid(); break;
                    case 4: AlternativeDollarPyramid(); break;
                    case 5: Frame(); break;
                    case 6: AlternativeFrame(); break;
                    case 7: ChristmasTree(); break;
                    case 8: AlternativeChristmasTree(); break;
                    case 9: Rhombus(); break;
                    case 0: Sunglasses(); break;
                    default: return;
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        // Правоъгълник, N по N размер.
        static void Rectangle()
        {
            Console.WriteLine("~====:Rectangle:====~");
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            width *= 2;

            for (int current_height = 0; current_height < height; current_height++)
            {

                for (int current_width = 0; current_width < width; current_width++)
                {
                    Console.Write("█");
                }

                Console.WriteLine();
            }
        }

        // Алтернативен правоъгълник, N по N размер.
        static void AlternativeRectangle()
        {
            Console.WriteLine("~====:Alternative Rectangle:====~");
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            width *= 2;

            for (int current_height = 0; current_height < height; current_height++)
            {
                string line = new string('█', width);
                Console.WriteLine(line);
            }
        }

        // Пирамида от доларчита.
        static void DollarPyramid()
        {
            Console.WriteLine("~====:Dollar Pyramid:====~");
            Console.Write("Ammount: ");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }

        // Алтернативна пирамида от доларчита.
        static void AlternativeDollarPyramid()
        {
            Console.WriteLine("~====:Alternative Dollar Pyramid:====~");
            Console.Write("Ammount: ");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= amount; i++)
            {
                Console.WriteLine(new string('$', i));
            }
        }

        // Рамка.
        static void Frame()
        {
            Console.WriteLine("~====:Frame:====~");
            Console.Write("Size: ");
            int size = int.Parse(Console.ReadLine());
            int inside_size = size - 2;

            Console.Write("+");

            for (int i = 0; i < inside_size; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.WriteLine();

            for (int i = 0; i < inside_size; i++)
            {
                Console.Write("|");

                for (int j = 0; j < inside_size; j++)
                {
                    Console.Write("-");
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("+");

            for (int i = 0; i < inside_size; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.WriteLine();
        }

        // По-добра рамка.
        static void AlternativeFrame()
        {
            Console.WriteLine("~====:Alternative Frame:====~");
            Console.Write("Size: ");
            int size = int.Parse(Console.ReadLine());

            string inside = new string('-', size - 2);
            string topBottom = "+" + inside + "+";
            string middle = "|" + inside + "|";

            Console.WriteLine(topBottom);

            for (int i = 0; i < (size - 2); i++)
            {
                Console.WriteLine(middle);
            }

            Console.WriteLine(topBottom);
        }

        static void ChristmasTree()
        {
            Console.WriteLine("~====:Christmas Tree:====~");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {

                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }

                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");
                
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }

                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        static void AlternativeChristmasTree()
        {
            Console.WriteLine("~====:Alternative Christmas Tree:====~");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                string spaces = new string(' ', n - row);
                string stars = new string('*', row);

                Console.Write(spaces);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.Write(spaces);

                Console.WriteLine();
            }
        }

        static void Sunglasses()
        {
            Console.WriteLine("~====:Sunglasses:====~");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            string horizontal_border = new string('*', 2 * n);
            string spacing = new string(' ', n);
            string middle_bit = new string('|', n);
            string glass = "*" + new string('/', (2 * n) - 2) + "*";


            Console.WriteLine(horizontal_border + spacing + horizontal_border);

            for (int i = 1; i <= n-2; i++)
            {
                Console.Write(glass);
                
                if (i == (n-2)/2)
                {
                    Console.Write(middle_bit);
                }
                else
                {
                    Console.Write(spacing);
                }

                Console.Write(glass);

                Console.WriteLine();
            }

            Console.WriteLine(horizontal_border + spacing + horizontal_border);
        }

        static void Rhombus()
        {
            Console.WriteLine("~====:Rhombus:====~");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

            for (int row = n - 1; row >= 1; row--)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
