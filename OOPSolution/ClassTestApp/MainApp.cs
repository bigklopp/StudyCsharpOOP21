using System;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat
            {
                Name = "네로",
                Age = 12,
                Color = "검은색"
            };
            nero.Meow();

            Cat mimi = new Cat("미미", "삼색", 3);
            mimi.Meow();

            Cat coco = new Cat("코코", "노랑");
            coco.Age = 2;
            coco.Meow();

            Cat nabi = new Cat("은색", 10);
            nabi.Name = "나비";
            nabi.Meow();

            nabi.Sleep();

            var list = (First : "Cat", Second : "Dog", Third : "Pig", Fourth : 55);
            Console.WriteLine($"튜플 첫번째 : {list.First}");
            Console.WriteLine($"튜플 두번째 : {list.Second}");
            Console.WriteLine($"튜플 세번째 : {list.Third}");
            Console.WriteLine($"튜플 네번째 : {list.Fourth}");



        }
    }
}
