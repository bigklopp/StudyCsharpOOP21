using System;
using System.Collections;

namespace CodingTest2_4_210511
{
    class Test4
    {
        static void Main(string[] args)
        {
            
            Hashtable dic = new Hashtable();

            dic["Red"] = "빨간색";
            dic["Orange"] = "주황색";
            dic["Yellow"] = "노란색";
            dic["Green"] = "초록색";
            dic["Blue"] = "파란색";
            dic["Navy"] = "남색";
            dic["Purple"] = "보라색";

            Console.WriteLine($"무지개 색은 {dic["Red"]}, {dic["Orange"]}, {dic["Yellow"]}, {dic["Green"]}, {dic["Blue"]}, {dic["Navy"]}, {dic["Purple"]}, 입니다.\n");
            
            Console.WriteLine("Key와 Value 확인");
            
            Console.WriteLine($"Purple은 {dic["Purple"]}입니다.");

        }
    }
}
