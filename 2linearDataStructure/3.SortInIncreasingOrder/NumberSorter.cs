using System;
using System.Collections.Generic;
using System.Linq;

public class NumberSorter
{
    static void Main()
    {
        List<int> listOfNumbers = NumberReader.ReadTheNumbers();
        listOfNumbers.Sort();
        Printer.PrintTheNumbers(listOfNumbers);
    }
}


