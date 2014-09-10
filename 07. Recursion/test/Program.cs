using System;

namespace _06.SubsetsOfKstrings
{
    class SubsetsOfKstrings
    {
        static void Main()
        {
            int k = 2;
            string[] setOfStrings = { "test", "rock", "fun" ,"daa"};
            string[] result = new string[k];
            GenerateSubsets(0, 0, result, setOfStrings);
        }

        static void GenerateSubsets(int startIndex, int index, string[] result, string[] setOfStrings)
        {
            if (index > result.Length - 1)
            {
                PrintArray(result);
            }
            else
            {
                for (int i = startIndex; i < setOfStrings.Length; i++)
                {
                    if (index < result.Length)
                    {
                        result[index] = setOfStrings[i];
                    }
                    GenerateSubsets(i + 1, index + 1, result, setOfStrings);
                }
            }
        }

        static void PrintArray(string[] result)
        {
            Console.WriteLine(String.Join(", ", result));
        }
    }
}