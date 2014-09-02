//Write a program that removes from given sequence all numbers that occur odd number of times. Example:
//{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}

namespace _06.RemovesNumbersWIthOddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class RemovesNumbersWIthOddOccurrences
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 4, 4, 4, 3, 3, 3, 2, 2, 1, 6, 6, 6, 6, 6, 6, 5, 5, 5, 5, 5 };
            List<int> result = new List<int>();
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

            for (int i = 0; i < numbers.Count; i++)
            {
                if (occurrences[numbers[i]] % 2 == 0)
                {
                    result.Add(numbers[i]);
                } 
            }

            Console.WriteLine("Sequnce: {0}", String.Join(", ", numbers));
            Console.WriteLine("Sequence with no numbers occuring odd times: {0}", String.Join(", ", result));
        }
    }
}
