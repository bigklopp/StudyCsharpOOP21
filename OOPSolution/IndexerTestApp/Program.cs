using System;

namespace IndexerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList list = new MyList();
            for (int i = 0; i< 4; i++)
            {
                list[i] = i; //
            }
            
            for (int i = 0; i<4;i++)
            {
                Console.WriteLine(list[i]);
            }


        }
    }
}
