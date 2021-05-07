using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("예외 발생");

            int[] array = new int[5];
            try
            {
                for (int i = 0; i < array.Length + 1; i++)
            {
                    array[i] = i + 1;
                    Console.WriteLine("무야호~");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                
                Console.WriteLine($"문제발생 {ex.Message}, 관리자에게 문의하세요 : Main(16~)");
                    Console.WriteLine("저희가 많이들 보죠.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"문제발생 {ex.Message}, 관리자에게 문의하세요 : Main(16~)");
                Console.WriteLine("그만큼 신나시는 거지.");
            }
            
            
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
