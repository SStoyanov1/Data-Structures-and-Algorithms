namespace _2.AllCombWithDuplicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class AllCombWithDup
    {
        static void Main()
        {
            Console.Write("Write the number of the nestedLoops:");
            int loopsLength = int.Parse(Console.ReadLine());
            Console.Write("Write the max number of the nestedLoops:");
            Console.WriteLine();
            int[] maxLoopNumber = new int[5] { 4, 8, 7, 9, 12 }; //int.Parse(Console.ReadLine());
            int[] currentLoop = new int[loopsLength];
            int index = 0;
            MakeTheCombinations(index, maxLoopNumber, loopsLength, currentLoop);
        }

        private static void MakeTheCombinations(int index, int[] maxLoopNumber, int loopsLength, int[] currentLoop)
        {
            if (index>loopsLength-1)
            {
                Console.WriteLine("(" +String.Join(",",currentLoop) + ")");
                return;
            }

            for (int i = 0; i < maxLoopNumber.Length; i++)
            {
                currentLoop[index] = maxLoopNumber[i];
                MakeTheCombinations(index + 1, maxLoopNumber, loopsLength, currentLoop);
            }
        }
    }
}
