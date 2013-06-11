using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Majorant
    {
        static void Main()
        {
            List<int> listOfNumbers = NumberReader.ReadTheNumbers();
            Dictionary<int, int> countApperances = OddNumbersRemover.CountTheApperancesOfDifferentNumbers(listOfNumbers);
            CheckForMajorant(listOfNumbers.Count, countApperances);
        }

        private static void CheckForMajorant(int listCount, Dictionary<int, int> countApperances)
        {
            int mojorantNumber = listCount / 2 + 1;
            bool hasMajorant = false;
            int theMajorantNumber = 0;
            foreach (var keyValuePair  in countApperances)
            {
                if (keyValuePair.Value>=mojorantNumber)
                {
                    hasMajorant = true;
                    theMajorantNumber = keyValuePair.Key;
                }
            }
            PrintTheResult(hasMajorant, theMajorantNumber);
        }

        private static void PrintTheResult(bool hasMajorant, int theMajorantNumber)
        {
            if (hasMajorant)
            {
                Console.WriteLine("The array has majorant {0}!",theMajorantNumber);
            }
            else
            {
                Console.WriteLine("The array doen't have majorant!");
            }
        }
    }

