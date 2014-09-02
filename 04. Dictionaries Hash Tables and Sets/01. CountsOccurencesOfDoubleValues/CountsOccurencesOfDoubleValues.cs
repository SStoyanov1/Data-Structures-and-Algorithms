//01. Write a program that counts in a given array of double values the number of occurrences of each value.
//Use Dictionary<TKey,TValue>.

namespace _01.CountsOccurencesOfDoubleValues
{
    using System;
    using System.Collections.Generic;

    public class CountsOccurencesOfDoubleValues
    {
        public static void Main()
        {
            var elements = new List<double> { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var dict = new Dictionary<double, int>();

            foreach (var value in elements)
            {
                if (!dict.ContainsKey(value))
                {
                    dict[value] = 0;
                }

                dict[value]++;
            }

            foreach (var occurence in dict)
            {
                Console.WriteLine("{0} -> {1} times", occurence.Key, occurence.Value);
            }
        }
    }
}
