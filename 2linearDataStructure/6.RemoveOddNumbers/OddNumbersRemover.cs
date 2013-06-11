using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class OddNumbersRemover
{
    static void Main()
    {
        List<int> listOfNumbers = NumberReader.ReadTheNumbers();
        Dictionary<int, int> appearancesOfNumbersCount = CountTheApperancesOfDifferentNumbers(listOfNumbers);
        List<int> listOfEvenCountNumbers = FindEventCountNumbers(appearancesOfNumbersCount);
        Printer.PrintTheNumbers(listOfEvenCountNumbers);

    }

    private static List<int> FindEventCountNumbers(Dictionary<int, int> appearancesOfNumbersCount)
    {
        List<int> listOfCountNumbers = new List<int>();
        foreach (var keyValuePair in appearancesOfNumbersCount)
        {
            if (keyValuePair.Value%2==0)
            {
                for (int i = 0; i < keyValuePair.Value; i++)
                {
                    listOfCountNumbers.Add(keyValuePair.Key);
                }
            }
        }

        return listOfCountNumbers;
        
    }

    public static Dictionary<int, int> CountTheApperancesOfDifferentNumbers(List<int> listOfNumbers)
    {
        Dictionary<int,int> countApperances = new Dictionary<int, int>();
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (countApperances.ContainsKey(listOfNumbers[i]))
            {
                countApperances[listOfNumbers[i]]++;
            }
            else
            {
                countApperances.Add(listOfNumbers[i], 1);
            }
        }
        return countApperances;
    }
}

