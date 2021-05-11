using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 일반적 방식
            DateTime startTime = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
            }
            TimeSpan timespan = DateTime.Now - startTime;
            Console.WriteLine($"for문 10000번 출력 처리시간 : {timespan.TotalMilliseconds} ms");
            

            //2. Parallel (병렬처리)방식
            DateTime pStartTime = DateTime.Now;
            Parallel.For(0, 10000, (i) =>
             {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
                 
             });
            TimeSpan timespan1 = DateTime.Now - pStartTime;
            Console.WriteLine($"Parallel for문 10000번 출력 처리시간 : {timespan1.TotalMilliseconds} ms");

        }
    }
}
