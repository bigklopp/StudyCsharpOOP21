using System;
using System.Threading;

namespace UsingInterfaceTestApp
{
    class MainApp
    {
        // 혼자 독학하는게 시간 낭비가 아니겠다. 하나도 못 알아 듣잖아.
        static void Main(string[] args)
        {
            
            var monitor1 = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
            monitor1.PrintLog("콘솔로그입니다.");
            
            var monitor = new ExtendedMonitor(new FileLogger("210504.log"));
            monitor.PrintLog("로그내용입니다.");

            Thread.Sleep(1000); //시간 딜레이
            monitor.PrintLog("이하 오류가 발생했습니다.");

            Console.WriteLine("프로그램 종료");
        }
    }
}
