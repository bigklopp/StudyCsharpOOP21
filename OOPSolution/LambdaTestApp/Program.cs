using System;

namespace LambdaTestApp
{
    class Program
    {
        delegate void DoSomething(string name);
        delegate string Concatenate(string[] arr);
        static void Main(string[] args)
        {
            #region

            /*DoSomething DoIt = delegate (string name)
            {
                Console.WriteLine("Hello ");
                Console.WriteLine("John Doe~!");
                Console.WriteLine(name);
                return; // void이기 때문에 생략 가능
            };
            string name = "해르";
            DoIt(name);*/

            /*DoSomething dodo = (name) =>
            {
                Console.WriteLine("Hello");
                Console.WriteLine("John Doe~!");
            };
            string name = "Hugo";
            dodo(name);*/
            #endregion
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                }
                return result;
            };
            string[] strarr = { "아버지가", "방에", "들어가신다." };
            Console.WriteLine(concat(strarr));

            Func<int> func1 = () => 3;

            var val = func1();
            Console.WriteLine($"val의 값은 {val},");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3 + 5 = {plus(3, 5)}");

            Action<int> area = (r) =>
             {
                 Console.WriteLine((double)r*r*Math.PI);
             };
            area(4);
        }
    }
}
