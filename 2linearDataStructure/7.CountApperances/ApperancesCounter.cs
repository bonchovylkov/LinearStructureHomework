using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ApperancesCounter
{
    static void Main()
    {
        List<int> listOfNumbers = NumberReader.ReadTheNumbers();
        Dictionary<int, int> countApperances = OddNumbersRemover.CountTheApperancesOfDifferentNumbers(listOfNumbers);
        PrintApperanceses(countApperances);
    }

    private static void PrintApperanceses(Dictionary<int, int> countApperances)
    {
        foreach (var keyValuePair in countApperances)
        {
            if (keyValuePair.Value ==1)
            {
                Console.WriteLine(keyValuePair.Key + " --->" + keyValuePair.Value + " time!"); 
            }
            else
            {
                Console.WriteLine(keyValuePair.Key + " --->" + keyValuePair.Value + " times!"); 
            }
        }
    }
}

