//* The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
//Write a program to find the majorant of given array (if exists). Example: {2, 2, 3, 3, 2, 3, 4, 3, 3}  3

namespace _08.FindsMajorantOfArray
{
    using System;
    using System.Collections.Generic;

    public class FindsMajorantOfArray
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            int majorant;

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

            Console.WriteLine("Sequence: {0}", String.Join(", ", numbers));

            foreach (KeyValuePair<int, int> pair in occurrences)
            {
                if (pair.Value >= numbers.Count / 2 + 1)
                {
                    Console.WriteLine("Majorant {0}: {1} times", pair.Key, pair.Value);
                    break;
                }
            }
        }
    }
}
