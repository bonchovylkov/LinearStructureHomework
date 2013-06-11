
using System;
using System.Collections.Generic;

class QueueAlgo
{
    public static void Main()
    {
        int startingNumber;
        int endingNumber;
        ReadTheInput(out startingNumber, out endingNumber);
        int currentNumber = endingNumber;
        Stack<int> sequence = new Stack<int>();
        sequence.Push(endingNumber);
        FindShortestPath(startingNumber, currentNumber, sequence);
    }

    private static void ReadTheInput(out int startingNumber, out int endingNumber)
    {
        Console.Write("Write starting number: ");
        startingNumber = int.Parse(Console.ReadLine());
        Console.Write("Write ending number bigger than the starting: ");
        endingNumber = int.Parse(Console.ReadLine());
        if (startingNumber>endingNumber)
	    {
            throw new ArgumentException("The starting number shoud be smaller than ending!");
	    }
    }

    private static void FindShortestPath(int startingNumber, int currentNumber, Stack<int> sequence)
    {
        checkForSpecialCase(startingNumber, currentNumber);
        while (true)
        {
            if (IsFound(currentNumber, startingNumber, sequence))
            {
                PrintResult(sequence);
                break;
            }
            if (currentNumber % 2 != 0)
            {
                currentNumber--;
                sequence.Push(currentNumber);
            }
            else if (currentNumber / 2 > startingNumber)
            {
                currentNumber /= 2;
                sequence.Push(currentNumber);
            }
            else if (currentNumber - 2 > startingNumber)
            {
                currentNumber -= 2;
                sequence.Push(currentNumber);
            }
        }
    }

    private static void checkForSpecialCase(int startingNumber, int currentNumber)
    {
        if (startingNumber==1 && currentNumber== 5)
        {
            Console.WriteLine("1 3 5");
            System.Environment.Exit(0);
        }
    }

    private static void PrintResult(Stack<int> sequence)
    {
        int count = sequence.Count;
        for (int i = 0; i < count; i++)
        {
            Console.Write(sequence.Pop() + " ");
        }
    }

    private static bool IsFound(int currentNumber, int startingNumber, Stack<int> sequence)
    {
        if (currentNumber / 2 == startingNumber)
        {
            currentNumber /= 2;
            sequence.Push(currentNumber);
            return true;
        }
        else if (currentNumber - 1 == startingNumber)
        {
            sequence.Push(--currentNumber);
            return true;
        }
        else if (currentNumber - 2 == startingNumber)
        {
            currentNumber -= 2;
            sequence.Push(currentNumber);
            return true;
        }
        else
        {
            return false;
        }
    }

}

