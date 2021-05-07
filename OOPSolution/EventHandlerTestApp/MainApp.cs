using System;

namespace EventHandlerTestApp
{
    
    class MainApp
    {
       
        static public void Myhandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.aaaaa += new EventHandler(Myhandler);
            for (int i = 1; i< 30; i++)
            {
                notifier.DoSomething(i);
            }
        }

        private static void MyHandler(string message)
        {
            Console.Write(message);
        }
    }
}
