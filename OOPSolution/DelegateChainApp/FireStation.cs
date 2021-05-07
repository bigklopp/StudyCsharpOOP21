using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChainApp
{
    delegate void ThereIsAFire(string location);
    delegate int Calculate(int a, int b);
    class FireStation
    {
        public void Call119(string location) { Console.WriteLine($"애앵애앵 : 주소는 {location}입니다."); }
        public void ShotOut(string location) { Console.WriteLine($"애앵애앵 : {location}에 불났어요"); }
        public void Escape(string location) { Console.WriteLine($"{location}에서 나가세요."); }
    }
}
