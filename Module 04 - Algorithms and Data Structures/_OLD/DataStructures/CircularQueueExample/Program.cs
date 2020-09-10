using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> myQueue = new CircularQueue<int>();

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            myQueue.Enqueue(50);
            myQueue.Enqueue(60);
            myQueue.Enqueue(70);
            myQueue.Enqueue(80);

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());


            myQueue.Enqueue(90);
            myQueue.Enqueue(100);

            myQueue.Enqueue(110);
            
            Console.ReadKey();
        }
    }
}
