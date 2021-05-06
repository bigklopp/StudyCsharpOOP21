using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList
    {
        private int[] array;
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
                    Console.WriteLine("시발아");
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
        public MyList()
        {
            array = new int[3];
        }

    }
}
