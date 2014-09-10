namespace _03.Dividers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    internal class Dividers
    {
        //http://bgcoder.com/Contests/Practice/Index/132#2
        private static List<int> permutations;

        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            var numbers = new int[numbersCount];
            for (int i = 0; i < numbersCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            permutations = new List<int>();
            int startingNum = 0;
            Permutation(numbers, startingNum);
            var currentNumberDividers = int.MaxValue;
            var minNumberDividers = int.MaxValue;
            var numbersWithMinDividers = new List<int>();
            
            foreach (var permutation in permutations)
            {
                var dividers = Factor(permutation);
                currentNumberDividers = dividers.Count;
                if (currentNumberDividers == minNumberDividers)
                {
                    numbersWithMinDividers.Add(permutation);
                }
                if (currentNumberDividers < minNumberDividers)
                {
                    minNumberDividers = currentNumberDividers;
                     numbersWithMinDividers = new List<int>() { permutation };
                }
            }

            Console.WriteLine(numbersWithMinDividers.Min());
        }

        private static void Permutation(int[] numbers, int startingNum)
        {
            if (startingNum >= numbers.Length)
            {
                var number = new StringBuilder();
                foreach (var element in numbers)
                {
                    number.Append(element);
                }
                permutations.Add(int.Parse(number.ToString()));
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

        private static List<int> Factor(int number)
        {
            List<int> factors = new List<int>();
            int max = (int)Math.Sqrt(number);
            for (int factor = 1; factor <= max; ++factor)
            {
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    {
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }
    }
}
