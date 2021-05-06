using System;
using System.Collections;

namespace StackTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 스택 로직 영역

            /*
            Stack stack = new Stack();
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Push(8);
            stack.Push(10);
            
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            */
            #endregion

            Hashtable dictionary = new Hashtable();
            dictionary["book"] = "책";
            dictionary["cook"] = "요리사";
            dictionary["tweet"] = "지저귀다";
            dictionary["whale"] = "고래";
            dictionary[5] = "고래";
            dictionary[6] = "ss";
            dictionary[7] = "dd";
            dictionary[8] = "ff";




            Console.WriteLine(dictionary["tweet"]);


            for(int i = 0; i<=8 ;i++)
            {
                Console.WriteLine(dictionary[i]);
            }

        }
    }
}
