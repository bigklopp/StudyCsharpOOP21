using System;

namespace GenericTestApp
{
    class Program
    {
        /*static void Main(string[] args)
        {
            float[] sourceInt = { 1.5f, 2.5f, 3.5f, 4.5f, 5.5f, 6.5f };
            float[] targetInt = new float[sourceInt.Length];
            Console.Write("복사전 targetInt값 =====> ");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}, ");

            }
            Console.WriteLine();

            CopyArray(sourceInt, targetInt) ;
            Console.Write("복사후 targetInt값 =====> ");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        private static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length;i++)
            {
                target[i] = source[i];
            }
        }

        }*/
        static void Main(string[] args)
        {
            Array_Generic<int> TestInt = new Array_Generic<int>();
            Array_Generic<double> TestDouble = new Array_Generic<double>();
            Array_Generic<string> TestString = new Array_Generic<string>();

            TestInt.array_drive=new int[5] { 1, 2, 3, 4, 5 };
            TestDouble.array_drive = new double[6] { 1.5, 2.5, 3.5, 4.5, 5.5, 6.5 };
            TestString.array_drive = new string[3] { "시발", "이소룡", "기뉴다" };
            for (int i = 0; i < TestInt.array_drive.Length;i++)
            {
                
                Console.WriteLine(TestInt.Array_index(i));
            }
            for (int i = 0; i < TestDouble.array_drive.Length; i++)
            {
                Console.WriteLine(TestDouble.Array_index(i));
            }
            for (int i = 0; i < TestString.array_drive.Length; i++)
            {
                Console.WriteLine(TestString.Array_index(i));
            }


        }
    }

}

