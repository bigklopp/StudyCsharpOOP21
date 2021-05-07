using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTestApp
{
    delegate void EventHandler(string message);
    class MyNotifier
    {
        public event EventHandler aaaaa;

        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                aaaaa(String.Format($"{number} : 짝"));

            }
        }
    }
}
