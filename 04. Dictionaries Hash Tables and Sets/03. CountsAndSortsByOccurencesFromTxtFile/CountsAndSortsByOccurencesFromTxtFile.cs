//03. Write a program that counts how many times each word from given text file words.txt appears in it.
//The character casing differences should be ignored. The result words should be ordered by their number
//of occurrences in the text.

namespace _03.CountsAndSortsByOccurencesFromTxtFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class CountsAndSortsByOccurencesFromTxtFile
    {
        public static void Main()
        {
            var text = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + "\\text.txt");
            var words = text[0].Split(new char[] { ' ', '.', ',', '!', '�', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var occurences = new Dictionary<string, int>();
            foreach (var word in words)
            {
                var currentWordToLower = word.ToLower();
                if (!occurences.ContainsKey(currentWordToLower))
                {
                    occurences[currentWordToLower] = 0;
                }

                occurences[currentWordToLower]++;
            }

            var sortedDict = from entry in occurences orderby entry.Value ascending select entry;

            foreach (var item in sortedDict)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
