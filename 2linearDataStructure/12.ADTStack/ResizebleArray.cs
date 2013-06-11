using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ADTStack
{
    public class ResizebleArray<T>
    {
        private T[] helpingArray = new T[8];
        private int Count { get; set; }

        public ResizebleArray()
        {
            this.Count = 0;
        }

        public T[] ResizeTheArray(T[] oldArray)
        {
            T[] newArray = new T[oldArray.Length * 2];
            Array.Copy(oldArray, newArray, oldArray.Length);
            return newArray;
        }

        public void Push(T item)
        {
            if (Count<this.helpingArray.Length-1)
            {
                helpingArray[Count] = item;
            }
            else
            {
              this.helpingArray =  ResizeTheArray(this.helpingArray);
              helpingArray[Count] = item;
            }
            Count++;
        }

        public T Peek()
        {
            T itemToShow = this.helpingArray[Count-1];
            return itemToShow;
        }

        public T Pop()
        {
            T itemToReturn = helpingArray[Count-1];
            Count--;
            return itemToReturn;
        }

    }
}
