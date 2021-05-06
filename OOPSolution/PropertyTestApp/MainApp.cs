using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지객체 생성");
            Dog baekgoo = new Dog();
            baekgoo.Age = 123; //
            Console.WriteLine($"{baekgoo.Age}살 입니다.");
            //baekgoo.name ="백구";
            Console.WriteLine($"{baekgoo.Name} : 왈왈 으르럴으르르크릉르ㅡㅡ를르으르크르으르 왈왈");

            Dog dog1 = new Dog();
            dog1.name = "초코";
            dog1.Age = 3;
            Dog dog2 = new Dog() { name = "까미", Age = 2 };

            var myInstance = new { name = "성명건", Age = 44 };
            Console.WriteLine(myInstance.Age + myInstance.name);
        }
    }
}
