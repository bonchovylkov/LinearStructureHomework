using System;
using System.Collections.Generic;
using System.Linq;

public class NumberReader
{
    static void Main()
    {
        List<int> listOfNumbers = ReadTheNumbers();
        Console.WriteLine(listOfNumbers.Sum());
        Console.WriteLine(listOfNumbers.Average());
    }

    public static List<int> ReadTheNumbers()
    {
        Console.WriteLine("To stop enter numbers write empry string \"\"");
        List<int> numbers = new List<int>();
        string line = Console.ReadLine();
        int numberToAdd=0;
        while (line != "")
        {
            if (int.TryParse(line, out numberToAdd))
            {
                numbers.Add(numberToAdd);
                line = Console.ReadLine();
            }
            else
            {
                throw new ArgumentException("Enter only numbers");
            }
        }
        return numbers;
        
    }
}

