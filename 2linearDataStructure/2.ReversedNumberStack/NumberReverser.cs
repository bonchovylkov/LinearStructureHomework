using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NumberReverser
{
    static void Main()
    {
        Console.Write("Enter the count of numbers you will ");
        int countOfReadedNumbers = int.Parse(Console.ReadLine());
        Stack<int> stackNumbers = ReadTheNumbers(countOfReadedNumbers);
        PrintTheNumbers(stackNumbers);
    }

    private static void PrintTheNumbers(Stack<int> stackNumbers)
    {
        Console.WriteLine("Reversed numbers!");
        int count = stackNumbers.Count;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(stackNumbers.Pop());
        }
    }

    private static Stack<int> ReadTheNumbers(int count)
    {
        Stack<int> numbers = new Stack<int>();
        for (int i = 0; i < count; i++)
        {
            numbers.Push(int.Parse(Console.ReadLine()));
        }
        return numbers;
    }
}


