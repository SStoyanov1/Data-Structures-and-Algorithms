namespace _05.VariationsWithDups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Variantons
    {
        static void Main()
        {
            //uncomment for Task condition 

            //Console.Write("Write the length of the initial set : ");
            //int initialLength = int.Parse(Console.ReadLine());
            //string[] initialSet = new string[initialLength];
            //for (int i = 0; i <initialSet.Length; i++)
            //{
            //    initialSet[i] = Console.ReadLine();
            //}
            string[] setOfWords = { "hi", "a", "b", "wf" }; // comment that after uncomment the top one
            Console.Write("Write the length of the current set:");
            int lengthOfTheCurrentSet = int.Parse(Console.ReadLine());
            string[] currentSet = new string[lengthOfTheCurrentSet];
            int index = 0;
            MakeVariantions(setOfWords, currentSet, index);
        }

        private static void MakeVariantions(string[] setOfWords, string[] currentSet, int index)
        {
            if (index >= currentSet.Length)
            {
                Print(currentSet);
            }
            else
            {
                for (int i = 0; i < setOfWords.Length; i++)
                {
                    currentSet[index] = setOfWords[i];
                    MakeVariantions(setOfWords, currentSet, index + 1);
                }
            }
        }

        private static void Print(string[] words)
        {
            Console.WriteLine("(" + String.Join(",", words) + ")");
        }
    }
}