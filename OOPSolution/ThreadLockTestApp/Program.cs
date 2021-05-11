using System;
using System.Threading;

namespace ThreadLockTestApp
{
    
    public class Counter
    {
        private int counter = 1000;
        private object thislock = new object();

        public void Run()
        {
            for(int i =0; i<10; i++)
            {
                Thread th = new Thread(UnsafeCalc);
                th.Start();
            }
        }
        public void UnsafeCalc()
        {
            lock (thislock)// lock을 통해서 동기화
            {
                counter++;
                for (int i = 0; i < counter; i++)
                    for (int j = 0; j < counter; j++)
                    {

                    }
                Console.WriteLine(counter);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter ct1 = new Counter();
           
            ct1.Run();
           

            ct1.UnsafeCalc();
        }
    }
}
