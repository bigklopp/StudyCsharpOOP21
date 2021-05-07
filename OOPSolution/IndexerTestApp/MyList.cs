using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList : IEnumerator, IEnumerable
    {
        private int[] array;
        private int position = -1; // 배열의 현재 위치값.?
        public int this[int inde2x] // MyList[i] == array[i] 

        {
            get
            {
                return array[inde2x];  // MyList[3] 하면 array[3]에 접근(출력)
            }
            set
            {
                if (inde2x >= array.Length)
                {
                    System.Array.Resize(ref array, inde2x + 1);
                    Console.WriteLine("이소룡 : 니랑 라박이랑 외나무다리에서 부비부비하고 있는데 텐션을 어떻게 올려 시발아!");
                }
                array[inde2x] = value; // value는 입력받은 값. 그걸 array[i]에 입력
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public object Current 
        {
            get { return array[position];}
        }

        public MyList() 
        {
            
            array = new int[3];
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();

        }

        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }
        
        public void Reset()
        {
            position = -1; // 초기화
        }
    }
}
