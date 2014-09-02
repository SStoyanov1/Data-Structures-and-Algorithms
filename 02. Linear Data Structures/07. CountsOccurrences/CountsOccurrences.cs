//Write a program that finds in given array of integers (all belonging to the range [0..1000])
//how many times each of them occurs.

namespace _07.CountsOccurrences
{
    using System;
    using System.Collections.Generic;

    public class CountsOccurrences
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 4, 8, 9, 1, 4, 5, 3, 3, 4, 2, 8, 1, 6, 6, 6, 6, 8, 6, 4, 1, 5, 9, 9 };
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (occurrences.ContainsKey(currentNumber))
                {
                    occurrences[currentNumber]++;
                }
                else
                {
                    occurrences.Add(currentNumber, 1);
                }
            }

            foreach (KeyValuePair<int, int> pair in occurrences)
            {
                Console.WriteLine("{0}: {1} times", pair.Key, pair.Value);
            }
        }
    }
}
