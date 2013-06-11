using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class LinkedListExecutor
    {
        public static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddAtTheEnd(5);
            list.AddAtTheEnd(10);
            list.AddAtTheEnd(20);
            list.AddAtTheEnd(30);
            list.AddAtBeggining(1000);
            list.RemoveFirst();
            list.RemoveLast();
        }
    }
