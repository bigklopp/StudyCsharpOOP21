using System;

namespace DelegateChainApp
{
    class Program
    {
        static void Main(string[] args)
        {/*
            FireStation heyhey = new FireStation();

            ThereIsAFire Fire = new ThereIsAFire(heyhey.Call119);
            Fire += new ThereIsAFire(heyhey.ShotOut);
            Fire += new ThereIsAFire(heyhey.Escape);

            Fire("  ");

            */
            Calculate calc;
            // 무명함수 표현 1
            /*calc = delegate (int a, int b)
            {
                return a + b;
            };*/

            calc = (a, b) => a + b;

            Console.WriteLine(calc(3, 4));
            Console.WriteLine(calc(2, 3));
            Console.WriteLine(calc(2, 3));
            Console.WriteLine(calc(2, 3));
            Console.WriteLine(calc(2, 3));
            Console.WriteLine(calc(2, 3));
            Console.WriteLine(calc(2, 3));

        }
    }
}
