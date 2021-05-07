using System;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("일반화 컬렉션 테스트 =====");

            List<int> listInt = new List<int>();
            int sum=0;
            int aa= listInt.Count;
            Console.WriteLine($"백두산은 몇 개? : {aa} 개 ");

            for (int i =1; i<=100;i++)
            {
                listInt.Add(i);
                sum += i;
            }

            foreach (var item in listInt)
            {
               // Console.WriteLine($" {item} ");
            }
            aa = listInt.Count;

            Console.WriteLine($"백두산은 몇 개? : {sum} 개 ");
            Console.WriteLine($"백두산은 몇 개? : {aa} 개 ");
*/

            Dictionary<string, int> dics = new Dictionary<string, int>();
            dics["하나"] = 1;
            dics["둘"] = 2;
            dics["셋"] = 3;
            dics["넷"] = 4;
            dics["다섯"] = 5;

            Console.WriteLine(dics["하나"]);
            Console.WriteLine(dics["셋"]);
            Console.WriteLine(dics["다섯"]);

            foreach (var item in dics)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);

            }


        }
    }
}
