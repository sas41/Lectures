using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SortingAlgorithms
{
    class Visualisations
    {
        static int VisualisationSpeed = 1200;

        
        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        private static void Swap<T>(List<T> list, int from, int to)
        {
            T container = list[to];
            list[to] = list[from];
            list[from] = container;
        }

        static void DrawList(List<int> list, int m1, int m2, int m3)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < list.Count; i++)
            {
                if (i == m1)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (i == m2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (i == m3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                Console.Write(list[i]);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|");

            }
        }

        public static void SelectionSortVisualisation()
        {
            Console.Clear();
            Console.CursorVisible = false;
            List<int> collection = new List<int> { 3, 2, 1, 5, 6, 7, 9, 8, 4, 5, 2, 8, 1, 3, 0, 9, 2, 5, 6 };
            for (int i = 0; i < collection.Count; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[minIndex]) < 0)
                    {
                        Console.Beep();
                        minIndex = j;
                    }
                    DrawList(collection, i, minIndex, j);
                    Thread.Sleep(VisualisationSpeed);
                }
                int temp = collection[i];
                collection[i] = collection[minIndex];
                collection[minIndex] = temp;
            }
        }

        public static void BubbleSortVisualisation()
        {
            Console.Clear();
            Console.CursorVisible = false;
            List<int> collection = new List<int> { 3, 2, 1, 5, 6, 7, 9, 8, 4, 5, 2, 8, 1, 3, 0, 9, 2, 5, 6 };
            for (int i = 1; i < collection.Count - 1; i++)
            {
                for (int j = 0; j < collection.Count - i; j++)
                {
                    if (collection[j].CompareTo(collection[j + 1]) > 0)
                    {
                        Console.Beep();
                        Thread.Sleep(VisualisationSpeed / 2);
                        //Swap
                        int temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                    }
                    DrawList(collection, j, j + 1, collection.Count - i);
                    Thread.Sleep(VisualisationSpeed / 2);
                }
            }
        }

        public static void InsertionSortVisualisation()
        {
            Console.Clear();
            Console.CursorVisible = false;
            List<int> collection = new List<int> { 3, 2, 1, 5, 6, 7, 9, 8, 4, 5, 2, 8, 1, 3, 0, 9, 2, 5, 6 };

            for (int i = 0; i < collection.Count - 1; i++)
            {
                if (collection[i].CompareTo(collection[i + 1]) > 0)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (collection[j].CompareTo(collection[j - 1]) < 0)
                        {
                            //Swap
                            Swap(collection, j, j - 1);
                        }
                        else
                        {
                            break;
                        }
                        Thread.Sleep(VisualisationSpeed);
                        DrawList(collection, j, j - 1, i);
                    }

                    Thread.Sleep(VisualisationSpeed);
                    DrawList(collection, i, i, i + 1);
                }
            }
        }

    }
}
