using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class QueueSequance
{
    static void Main()
    {
        int startingNumber = int.Parse(Console.ReadLine());
        Queue<int> sequnceOfNumbers = new Queue<int>();
        int count = 0;
        sequnceOfNumbers.Enqueue(startingNumber);
        while (count<50)
        {
            int firstQueueMember = sequnceOfNumbers.Peek();
            sequnceOfNumbers.Enqueue(firstQueueMember + 1);
            sequnceOfNumbers.Enqueue(2 * firstQueueMember + 1);
            sequnceOfNumbers.Enqueue(firstQueueMember + 2);
            Console.Write(sequnceOfNumbers.Dequeue() + " ");
            count++;
        }

    }
}

