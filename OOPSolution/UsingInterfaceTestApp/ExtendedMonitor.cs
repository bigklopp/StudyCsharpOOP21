using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    //이 소스파일은 github에서 가져다가 쓴 것.
    //왜 굳이 가져다 쓰냐 => 갑의 요구에 수정을 용이하게 하기 위해..
    //Main에서 간단하게 조금만 고치면 콘솔로 출력할 것이냐 텍스트 파일로 출력할 것이냐 바꿀 수 있다.
    class ExtendedMonitor
    {
        //이 ExtendedMonitor 라는 클래스 안에서만 사용 가능한(private) ILogger 타입의
        //logger라는 인스턴스 변수를 생성. 뒤에 {get; set;} 붙인거나 안 붙인거나 같다.
        private ILogger logger;

        //ExtendedMonitor 클래스를 따르는 객체를 Main에서 생성할 때 ILogger 타입의 logger라는 매개변수를
        //입력받아 위에서 선언한 클래스 내의 logger라는 인스턴스 변수에 대입/저장한다.
        public ExtendedMonitor(ILogger logger)
        {
            this.logger = logger;

        }
        //문자열 타입의 message라는 매개변수를 입력받는 PrintLog라는 메서드를 생성
        //입력받은 message를 위에서 선언한 logger라는 변수의 WriteLog 메서드를 실행(?)
        //Main -> ConsoleLogger 클래스 객체(ILogger를 따름) -> ExtendedMonitor 클래스
        // -> ILogger 인터페이스 -> WriteLog 메서드(약속)
        //
        //
        public void PrintLog(string message)
        {
            this.logger.WriteLog(message);
        }
        
    }
}
