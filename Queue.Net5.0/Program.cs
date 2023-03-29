using System;
using System.Collections.Generic;

namespace Queue.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a queue of integers
            Queue<int> queue = new Queue<int> ();
            queue.Enqueue (1);

            //printing the element at the front of the queue
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
        }
    }
}
