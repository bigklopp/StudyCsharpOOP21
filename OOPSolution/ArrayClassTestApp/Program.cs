using System;

namespace ArrayClassTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = new int[] { 5, 7, 3, 1, 9, 10, 4, 8, 2, 6 };

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Array.Sort(array);
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write($"{item}\t");

            }

            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { Console.Write($"[{i}, {j}] ; {matrix[i, j]} \t"); }
            }
            Console.WriteLine();




        }
    }
}
