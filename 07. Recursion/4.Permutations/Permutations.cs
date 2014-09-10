namespace _04.Permutations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    internal class Permutations
    {
        static void Main()
        {
            int[] numbers = new int[] { 9, 2, 5, 19 };
            //Console.Write("Write the length of the array: ");
            //int lengthOfTheArray = int.Parse(Console.ReadLine());
            //int[] numbers = new int[lengthOfTheArray];
            //for (int i = 0; i < lengthOfTheArray; i++)
            //{
            //    numbers[i] = i + 1;
            //}

            int startingNum = 0;
            Permutation(numbers, startingNum);
        }

        private static void Permutation(int[] numbers, int startingNum)
        {
            if (startingNum >= numbers.Length)
            {
                Print(numbers);
                return;
            }

            Permutation(numbers, startingNum + 1);
            for (int i = startingNum + 1; i < numbers.Length; i++)
            {
                Swap(ref numbers[startingNum], ref numbers[i]);
                Permutation(numbers, startingNum + 1);
                Swap(ref numbers[startingNum], ref numbers[i]);
            }
        }

        private static void Swap(ref int firstNumber, ref int secondNumber)
        {
            int oldValue = firstNumber;
            firstNumber = secondNumber;
            secondNumber = oldValue;
        }

        private static void Print(int[] numbers)
        {
            Console.WriteLine("(" + String.Join(",", numbers) + ")");
        }
    }
}
