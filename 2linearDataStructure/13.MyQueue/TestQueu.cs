using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.MyQueue
{
    class TestQueu
    {
        static void Main()
        {
            MyQueue<int> test = new MyQueue<int>();
            test.Enqueue(1);
            test.Enqueue(9);
            test.Enqueue(3);
            test.Enqueue(999);
            Console.WriteLine(test.Count);
            Console.WriteLine(test.Dequeue());
            Console.WriteLine(test.Dequeue());
            Console.WriteLine(test.Count);
        }
    }
}
