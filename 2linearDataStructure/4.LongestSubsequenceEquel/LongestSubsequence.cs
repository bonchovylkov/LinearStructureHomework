using System;
using System.Collections.Generic;
using System.Linq;

public class LongestSubsequence
{
    static void Main()
    {
        List<int> listOfNumbers = NumberReader.ReadTheNumbers();
        listOfNumbers.Sort();
        List<int> theLongestSequence = FindTheLongestSequenceEqualNumbers(listOfNumbers);
        Printer.PrintTheNumbers(theLongestSequence);
    }

    public static List<int> FindTheLongestSequenceEqualNumbers(List<int> listOfNumbers)
    {
        if (listOfNumbers.Count==0)
        {
            return new List<int>();
        }
        else if (listOfNumbers.Count==1)
        {
            return new List<int>() {listOfNumbers[0]};
        }
        else
        {
            int outerLoopUpdater = 1;
            int longestSequnceCount = 0;
            int numberOfTheLongestSequence = 0;
            for (int i = 0; i < listOfNumbers.Count; i += outerLoopUpdater)
            {
                int countEqualNumbers = 1;
                int currentIndex = i + 1;

                while (currentIndex < listOfNumbers.Count && listOfNumbers[i] == listOfNumbers[currentIndex])
                {
                    countEqualNumbers++;
                    currentIndex++;
                }

                if (countEqualNumbers > longestSequnceCount)
                {
                    longestSequnceCount = countEqualNumbers;
                    numberOfTheLongestSequence = listOfNumbers[i];
                }

                outerLoopUpdater = countEqualNumbers;
            }

            List<int> longestSequenceList = GenerateLongestSequence(numberOfTheLongestSequence, longestSequnceCount);
            return longestSequenceList;
        }
      
    }

    public static List<int> GenerateLongestSequence(int numberOfTheLongestSequence, int longestSequnceCount)
    {
        List<int> longestList = new List<int>();
        for (int i = 0; i < longestSequnceCount; i++)
        {
            longestList.Add(numberOfTheLongestSequence);
        }
        return longestList;
    }
}

