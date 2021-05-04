using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    //ConsoleLogger라는 클래스는 ILogger라는 인터페이스를 상속한다.
    //ILogger는 문자열 message라는 매개변수를 입력받는 WriteLog 라는 메서드를 만들기를 강제한다.
    class ConsoleLogger : ILogger
    {
        // DateTime이라는 데이터 형식이 있다. 이 DateTime 형식을 갖는 currentDate라는 인스턴스 변수 생성
        public DateTime currentDate { get; set; }
        
        // Main에서 클래스 객체를 생성할 때 입력받은 변수를 바로 currentDate라는 인스턴스 변수에 입력
       
        public ConsoleLogger(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }
        
        // WriteLog라는 이름의 메서드 생성 메서드 매개변수는 문자열 타입의 message
        // 이 메서드를 실행하면 입력받은 매개변수 메세지와 currentDate 인스턴스 변수를
        // 포함한 해당 문자열을 콘솔창에 출력한다.
        public void WriteLog(string message)
        {
            Console.WriteLine($"콘솔로그 : {this.currentDate} --> {message}");
        }
    }
}
