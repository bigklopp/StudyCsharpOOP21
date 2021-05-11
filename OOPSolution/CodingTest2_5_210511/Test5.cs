using System;

namespace CodingTest2_5_210511
{
    interface IAnimal
    {
        void Eat();
        void Sleep();
        void Sound();
    }
    
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Dog : Animal, IAnimal
    {
        public void Eat()
        {
            Console.WriteLine($"{this.Age}살 {this.Name}(이)가 냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{this.Age}살 {this.Name}(이)가 쿨쿨 잡니다.");
        }

        public void Sound()
        {
            Console.WriteLine($"{this.Name} : 왈왈 으릉르르릉르르크으르으르르크르릉르크르으 왈왈!!!");
        }
        class Cat : Animal, IAnimal
        {
            public void Eat()
            {
                Console.WriteLine($"{this.Age}살 {this.Name}(이)가 냥냠 먹습니다.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{this.Age}살 {this.Name}(이)가 쿨쿨 잡니다.");
            }

            public void Sound()
            {
                Console.WriteLine($"{this.Name} : 냥냥펀치");
            }
        }
        class Horse : Animal, IAnimal
        {
            public void Eat()
            {
                Console.WriteLine($"{this.Age}살 {this.Name}(이)가 히힝 먹습니다.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{this.Age}살 {this.Name}(이)가 쿨쿨 잡니다.");
            }

            public void Sound()
            {
                Console.WriteLine($"{this.Name} : 히히히히이이잉 히히히히히히이이잉");
            }
        }
        class Test5
        {
            static void Main(string[] args)
            {
                Dog dog = new Dog()
                { Age = 1, Name = "바둑" };

                Cat cat = new Cat() 
                { Age = 2, Name = "나비" };

                Horse horse = new Horse()
                { Age = 3, Name = "마마" };

                dog.Eat();
                dog.Sleep();
                dog.Sound(); 

                cat.Eat();
                cat.Sleep();
                cat.Sound();

                horse.Eat();
                horse.Sleep();
                horse.Sound();

            }
        }
    }
}
