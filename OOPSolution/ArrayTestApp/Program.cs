using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성마이맥 수학점수");

            int[] SSSScores = new int[10];
            SSSScores[0] = 80;
            SSSScores[1] = 74;
            SSSScores[2] = 81;
            SSSScores[3] = 94;
            SSSScores[4] = 100; 
            SSSScores[5] = 5;
            SSSScores[6] = 744;
            SSSScores[7] = 831;
            SSSScores[8] = 4;
            SSSScores[9] = 150;

            var sum = 0;

            foreach (var item in SSSScores)
            {
                
                sum += item;
            }
            float average = (float) sum / SSSScores.Length;
            Console.WriteLine($"합계 : {sum} 평균 : {average}");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            
        }
    }
}
