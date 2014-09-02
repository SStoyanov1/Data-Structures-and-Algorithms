//Write a program that removes from given sequence all negative numbers.

namespace _05.RemovesAllNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class RemovesAllNegativeNumbers
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { -2, 1, -1, 2, 3, -3, 2, 2, -2, 1, 1, 4, -4, 4, -4, 2, 2 };
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > -1)
                {
                    result.Add(numbers[i]);
                }
            }

            Console.WriteLine("Sequnce: {0}", String.Join(", ", numbers));
            Console.WriteLine("Sequence with no negative numbers: {0}", String.Join(", ", result));
        }
    }
}
