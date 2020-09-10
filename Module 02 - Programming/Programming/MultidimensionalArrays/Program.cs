using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D
            int[,] matrixExample2D = new int[4, 3];
            Console.WriteLine($"matrixExample2D is {matrixExample2D.GetLength(0)}x{matrixExample2D.GetLength(1)}");
            // 3D
            int[,,] matrixExample3D = new int[4, 3, 5];
            Console.WriteLine($"matrixExample3D is {matrixExample3D.GetLength(0)}x{matrixExample3D.GetLength(1)}x{matrixExample3D.GetLength(2)}");

            // Jagged
            int[][] jaggedMatrix = new int[3][];
            jaggedMatrix[0] = new int[5];
            jaggedMatrix[1] = new int[3];
            jaggedMatrix[2] = new int[4];
            Console.WriteLine($"jaggedMatrix[0] is {jaggedMatrix.Length}x{jaggedMatrix[0].Length}");
            Console.WriteLine($"jaggedMatrix[1] is {jaggedMatrix.Length}x{jaggedMatrix[1].Length}");
            Console.WriteLine($"jaggedMatrix[2] is {jaggedMatrix.Length}x{jaggedMatrix[2].Length}");

            // With Lists
            List<List<int>> listMatrix = new List<List<int>>();
            listMatrix.Add(new List<int>()); // First Row
            listMatrix.Add(new List<int>()); // Second Row
            listMatrix.Add(new List<int>()); // Third Row
            listMatrix[0].Add(999);
            listMatrix[0].Add(888);
            listMatrix[1].Add(77);
            listMatrix[2].Add(6);
            listMatrix[2].Add(9);
            listMatrix[2].Add(3);
            Console.WriteLine($"listMatrix[0] is {listMatrix.Count}x{listMatrix[0].Count}");
            Console.WriteLine($"listMatrix[1] is {listMatrix.Count}x{listMatrix[1].Count}");
            Console.WriteLine($"listMatrix[2] is {listMatrix.Count}x{listMatrix[2].Count}");


            // Dynmaic
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            matrixExample2D = new int[height, width];
            Console.WriteLine($"matrixExample2D is {matrixExample2D.GetLength(0)}x{matrixExample2D.GetLength(1)}");

            height = matrixExample2D.GetLength(0);
            width = matrixExample2D.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write($"matrixExample2D[{y},{x}] = ");
                    int input = int.Parse(Console.ReadLine());
                    matrixExample2D[y, x] = input;
                }
            }

            Console.ReadLine();
        }
    }
}
