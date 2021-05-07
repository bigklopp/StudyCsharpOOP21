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
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(calc(3, 4));

        }
    }
}
