using _12.ADTStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExecuteStack
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        OurStack<int> stack = new OurStack<int>();
        for (int i = 0; i < 10; i++)
        {
            stack.Push(rnd.Next(100));
        }
        int initialCount = stack.Count;
        Console.Write("origin numbers:"); 
        for (int i = 0; i < initialCount; i++)
        {
            Console.Write( stack.Pop() + " ");

        }

        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            stack.Push(rnd.Next(100));
        }

        Console.WriteLine("Show last(peek) : " + stack.Peek());
        Console.WriteLine("Show and remove last :" + stack.Pop() + "\nafter removing tha last one the last is :" + stack.Peek());
    }
}

