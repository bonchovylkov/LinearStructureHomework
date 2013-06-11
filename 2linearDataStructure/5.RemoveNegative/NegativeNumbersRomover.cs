using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
public class NegativeNumbersRomover
{
    static void Main()
    {
        List<int> listOfNumbers = NumberReader.ReadTheNumbers();
        List<int> positiveNumbers = GetPosiveteNumbers(listOfNumbers);
        Printer.PrintTheNumbers(positiveNumbers);
    }

    private static List<int> GetPosiveteNumbers(List<int> listOfNumbers)
    {
        List<int> positiveNumbers = new List<int>();
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i]>=0)
            {
                positiveNumbers.Add(listOfNumbers[i]);
            }
        }
        return positiveNumbers;
    }
}
