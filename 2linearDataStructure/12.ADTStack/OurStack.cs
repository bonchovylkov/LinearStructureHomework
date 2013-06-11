using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ADTStack
{
   public class OurStack<T>
    {
       private ResizebleArray<T> ourStack = new ResizebleArray<T>();
       public int Count { get; private set; }

       public OurStack()
       {
           this.Count = 0;
       }

       public void Push(T item)
       {
           this.ourStack.Push(item);
           Count++;
       }

       public T Peek()
       {
           return ourStack.Peek();
       }

       public T Pop()
       {
           Count--;
           return ourStack.Pop();
       }

    }
}
