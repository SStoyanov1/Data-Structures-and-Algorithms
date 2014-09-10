namespace _06.VariationsNoDups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class KSets
    {
        private static List<SortedSet<string>> duplicatesCheker = new List<SortedSet<string>>();
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
            string[] setOfWords = { "1", "2", "3", "4", "5" }; // comment that after umcoment the top one
            bool[] used = new bool[setOfWords.Length];
            Console.Write("Write the length of the current set:");
            int lengthOfTheCurrentSet = int.Parse(Console.ReadLine());
            string[] currentSet = new string[lengthOfTheCurrentSet];
            int index = 0;
            MakeVariantions(setOfWords, currentSet, index, used);
            Print(duplicatesCheker);
        }

        private static void MakeVariantions(string[] setOfWords, string[] currentSet, int index, bool[] used)
        {
            if (index >= currentSet.Length)
            {
                SortedSet<string> words = ExtractTheCurrentWords(currentSet);

                if (duplicatesCheker.Count == 0)
                {
                    duplicatesCheker.Add(words);
                    return;
                }

                List<List<bool>> foundDup = new List<List<bool>>();


                FillTheFoundDupList(words, foundDup);

                bool hasWholeRowOfTrue = CheckForSameRow(foundDup);

                if (!hasWholeRowOfTrue)
                {
                    duplicatesCheker.Add(words);
                }


            }
            else
            {
                for (int i = 0; i < setOfWords.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        currentSet[index] = setOfWords[i];
                        MakeVariantions(setOfWords, currentSet, index + 1, used);
                        used[i] = false;
                    }

                }
            }
        }

        private static SortedSet<string> ExtractTheCurrentWords(string[] currentSet)
        {
            SortedSet<string> words = new SortedSet<string>();
            foreach (var word in currentSet)
            {
                words.Add(word);
            }
            return words;
        }

        private static bool CheckForSameRow(List<List<bool>> foundDup)
        {
            bool hasWholeRowOfTrue = false;

            for (int i = 0; i < foundDup.Count; i++)
            {

                if (!foundDup[i].Contains(false))
                {
                    hasWholeRowOfTrue = true;
                }

            }
            return hasWholeRowOfTrue;
        }

        private static void FillTheFoundDupList(SortedSet<string> words, List<List<bool>> foundDup)
        {
            for (int i = 0; i < duplicatesCheker.Count; i++)
            {
                foundDup.Add(new List<bool>());
                for (int j = 0; j < words.Count; j++)
                {
                    if (duplicatesCheker[i].ElementAt(j) == words.ElementAt(j))
                    {
                        foundDup[i].Add(true);
                    }
                    else
                    {
                        foundDup[i].Add(false);
                    }
                }
            }
        }

        private static void Print(List<SortedSet<string>> sets)
        {
            foreach (var set in sets)
            {
                Console.WriteLine("(" + String.Join(",", set) + ")");

            }
        }
    }
}