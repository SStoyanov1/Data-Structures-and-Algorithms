namespace _02.ColourfulRabbits
{
    using System;
    using System.Collections.Generic;

    internal class ColourfulRabbits
    {
        //http://bgcoder.com/Contests/Practice/Index/132#1

        static void Main(string[] args)
        {
            int rabbitsAsked = int.Parse(Console.ReadLine());
            int result = 0;
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < rabbitsAsked; i++)
            {
                int sameColourRabbits = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(sameColourRabbits + 1))
                {
                    dict[sameColourRabbits + 1] = 0;
                }
                dict[sameColourRabbits + 1]++;
            }

            foreach (var answer in dict)
            {
                result += (int)Math.Ceiling((double)answer.Value / (double)answer.Key) * answer.Key;
            }
            Console.WriteLine(result);
        }
    }
}
