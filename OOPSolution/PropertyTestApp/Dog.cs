using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        public string name;

        public string Name 
        { get; set; }="고영희"; //초기화

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0) this.age = 1;
                else if (value > 15) this.age = 15;
                else this.age = value;
                
            }
        }
        /*
        public int GetAge() { return this.age; } // 값을 사용
        public void SetAge(int age) 
        {
            if (age < 0) this.age = 1;
            else if (age > 15) this.age = 15;
            else this.age = age; // 값을 설정
        } 
                */

    }
}
