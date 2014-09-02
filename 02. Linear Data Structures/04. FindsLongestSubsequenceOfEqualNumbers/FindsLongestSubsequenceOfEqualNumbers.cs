//Write a method that finds the longest subsequence of equal numbers in given
//List<int> and returns the result as new List<int>. Write a program to test
//whether the method works correctly.

namespace _04.FindsLongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    public class FindsLongestSubsequenceOfEqualNumbers
    {
        public static List<int> FindsLongestSeq(List<int> numbers)
        {
            List<int> result = new List<int>();

            int startIndex = 0;
            int length = 1;
            int bestStartIndex = 0;
            int bestLength = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStartIndex = startIndex;
                    }
                }

                else
                {
                    length = 1;
                    startIndex = i + 1;
                }
            }

            result.AddRange(numbers.GetRange(bestStartIndex, bestLength));

            return result;
        }

        public static void Main()
        {
            List<int> numbers = new List<int> { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 4, 4, 4, 4, 2, 2 };

            List<int> longestEqualSeq = new List<int>();
            
            longestEqualSeq = FindsLongestSeq(numbers);

            Console.WriteLine("Sequnce: {0}", String.Join(", ", numbers));
            Console.WriteLine("Longest equal subsequence: {0}", String.Join(", ", longestEqualSeq));
        }
    }
}
