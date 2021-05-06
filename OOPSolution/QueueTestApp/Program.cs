using System;
using System.Collections;

namespace QueueTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue que = new Queue();
            que.Enqueue(2);
            que.Enqueue(4);
            que.Enqueue(6);
            que.Enqueue(8);
            que.Enqueue(10);
            Console.WriteLine(que.Count);
            que.Enqueue(1);

            Console.WriteLine(que.Count);

            /*
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());
            */
            while (que.Count > 0)
            {
                Console.WriteLine(que.Count);
            Console.WriteLine(que.Dequeue());
                
            }
        }
    }
}
