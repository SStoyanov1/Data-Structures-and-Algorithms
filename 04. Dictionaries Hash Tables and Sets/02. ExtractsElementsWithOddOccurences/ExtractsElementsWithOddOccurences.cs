//02. Write a program that extracts from a given sequence of strings all elements
//that present in it odd number of times.
//Example:
//{C#, SQL, PHP, PHP, SQL, SQL }  {C#, SQL}

namespace _02.ExtractsElementsWithOddOccurences
{
    using System;
    using System.Collections.Generic;

    public class ExtractsElementsWithOddOccurences
    {
        public static void Main()
        {
            var elements = new List<string> { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var dict = new Dictionary<string, int>();
            var result = new List<string>();

            foreach (var value in elements)
            {
                if (!dict.ContainsKey(value))
                {
                    dict[value] = 0;
                }

                dict[value]++;
            }

            foreach (var value in dict)
            {
                if (value.Value % 2 != 0)
                {
                    result.Add(value.Key);
                }
            }
            
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
