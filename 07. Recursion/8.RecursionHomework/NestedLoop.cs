//01. Write a recursive program that simulates the execution of n nested loops from 1 to n.
namespace _01.NestedLoops
{
    using System;

    public class NestedLoops
    {
        public static void NestedLoopsRec(int n, int[] current)
        {
            if (n == 0)
            {
                Console.WriteLine(string.Join(" ", current));
                return;
            }

            for (int i = 1; i <= current.Length; i++)
            {
                current[n - 1] = i;
                NestedLoopsRec(n - 1, current);
            }
        }

        public static void Main()
        {
            int loopsNumber = 4;
            NestedLoopsRec(loopsNumber, new int[loopsNumber]);
        }
    }
}