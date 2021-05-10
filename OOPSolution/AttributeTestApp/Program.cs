using System;

namespace AttributeTestApp
{
    public class MyClass
    {
        [Obsolete("이 메서드는 폐기되었습니다. NewMethod()를 대신 사용하세요.")]
        
        public void OldMethod() { Console.WriteLine("뭔가를 한다."); }
        public void NewMethod() { Console.WriteLine("새로운 무언가를 한다."); }
        public int Plus(int a, int b) { return a + b; }

        public double Divide(int a, int b) { return (double) a / b;  }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mine = new MyClass();
            mine.OldMethod();

            mine.NewMethod();

            var result = mine.Plus(3, 5);
            Console.WriteLine(result);
        }
    }
}
