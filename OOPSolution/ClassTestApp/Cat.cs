using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        // public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Cat() { /*아무 작업 없음*/ }
        public Cat(string name, string color, int age)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;

        }
        public Cat(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }
        public Cat(string color, int age)
        {
            this.Age = age;
            this.Color = color;
        }
        public void Meow() { Console.WriteLine($"{this.Color} {this.Name}, 야옹!"); }

        public override void Sleep()
        {
            //base.Sleep(); 부모의 Sleep()메서드 실행.
            //이후 자식 클래스의 sleep 내용 실행.
            Console.WriteLine($"{this.Color} 고양이 {this.Name}가 ZZ잡니다. ");
        }

        
    }
}
