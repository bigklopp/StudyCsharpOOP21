using System;

namespace DelegateTestApp
{
  
    class Program
    {
        public int Plusone(int a, int b) { return a + b; }
        public delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            int Plustwo(int a, int b) { return a + b; }
            //public delegate int MyDelegate(int a, int b);


            Calculator calc = new Calculator();
            Console.WriteLine(Plustwo(3, 6));

            CalcDelegate callback;
            callback = new CalcDelegate(calc.Plus);
            Console.WriteLine(callback(3, 44));
            MyDelegate colback = new MyDelegate(Plustwo);
            Console.WriteLine(colback(3, 55));

        }
    }
}
