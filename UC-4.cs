using System;

namespace QueueProblem2

{
    public class Program
    {

        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
        }
    }
}