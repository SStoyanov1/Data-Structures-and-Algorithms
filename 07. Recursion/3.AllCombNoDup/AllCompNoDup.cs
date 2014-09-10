namespace _3.AllCombNoDup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class AllCompNoDup
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int[] arr = new int[5] { 4, 3, 9, 7, 8 };
            int k = int.Parse(Console.ReadLine());

            int[] combination = new int[k];

            GetCombinations(combination, arr, 0, 0);
        }

        private static void GetCombinations(int[] combination, int[] arr, int index, int number)
        {
            if (index == combination.Length)
            {
                Console.WriteLine(string.Join(" ", combination));
            }
            else
            {
                for (int i = number; i < arr.Length; i++)
                {
                    combination[index] = arr[i];
                    GetCombinations(combination, arr, index + 1, ++number);
                }
            }
        }
    }
}
