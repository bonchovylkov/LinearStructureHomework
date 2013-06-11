using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Printer
{
    public static void PrintTheNumbers(List<int> listOfNumbers)
    {
        if (listOfNumbers.Count == 1)
        {
            Console.WriteLine("(" + listOfNumbers[0] + ")");
        }
        else if (listOfNumbers.Count == 0)
        {
            Console.WriteLine("The list is empty!");
        }
        else
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write("(" + listOfNumbers[i] + ",");
                }
                else if (i == listOfNumbers.Count - 1)
                {
                    Console.Write(listOfNumbers[i] + ")");
                }
                else
                {
                    Console.Write(listOfNumbers[i] + ",");
                }
            }
            Console.WriteLine();
        }

    }
}