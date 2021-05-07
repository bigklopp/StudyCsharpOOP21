using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestApp
{
    class Array_Generic<T>
    {
        private T[] array;

        public T[] array_drive
        {
            get { return this.array; }
            set
            {
                this.array = value;
            }
        }


        public T Array_index(int index) => array[index];

    }
}
