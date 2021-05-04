using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔로거 사용합니다.");

            ILogger logger = new ConsoleLogger();
            logger.WriteLog("기본 콘솔 로그입니다.");

            logger.WriteError("에러메시지!!!!!!");

            ILogger clmLogger = new FileLogger();
            clmLogger.WriteLog("맑음");
            logger.WriteError("문제발생!");

            ILogger logger1 = new ClimateLogger();
            logger1.WriteLog("흐림");
            //logger1.WriteError("!!!!"); // 실행오류 (예외) 발생!!!!


        }
    }
}
