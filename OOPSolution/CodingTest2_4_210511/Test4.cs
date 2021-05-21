using System;
using System.Collections;

namespace CodingTest2_4_210511
{
    class Test4
    {
        static void Main(string[] args)
        {
            
            Dictionary<string,string> dic = new Dictionary();

            dic.Add("Red", "빨간색");
            dic.Add("Orange", "주황색");
            dic.Add("Yellow","노란색");
            dic.Add("Green", "초록색");
            dic.Add("Blue", "파란색");
            dic.Add("Navy", "남색");
            dic.Add("Purple", "보라색");

            Console.WriteLine($"무지개 색은 {dic["Red"]}, {dic["Orange"]}, {dic["Yellow"]}, {dic["Green"]}, {dic["Blue"]}, {dic["Navy"]}, {dic["Purple"]}, 입니다.\n");

            Console.Write($"무지개 색은 ");
            foreach (var item in dic)
            {
                Console.Write($"{item.value}");
            }

            Console.WriteLine($"입니다.");

            Console.WriteLine("Key와 Value 확인");
            

            //Console.WriteLine($"Purple은 {dic["Purple"]}입니다.");

        }
    }
}
