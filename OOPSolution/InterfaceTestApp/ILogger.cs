namespace InterfaceTestApp
{
    // interface는 약속이다. 이 ILogger를 구현(상속)하면 아래의 액션을 무조건 구현해야 함
    interface ILogger
    {
        void WriteLog(string message); 
        
        //자식 클래스들은 무조건 하나의 메시지를 받아서 처리할 것.
        

        void WriteError(string error); 
        
        //자식 클래스들은 무조건 메서드 하나 더 추가해서 에러를 받아서 처리해야 한다.
        
    }
}
