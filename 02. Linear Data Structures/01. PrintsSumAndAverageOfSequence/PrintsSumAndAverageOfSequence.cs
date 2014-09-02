//Write a program that reads from the console a sequence of positive integer numbers.
//The sequence ends when empty line is entered. Calculate and print the sum and average
//of the elements of the sequence. Keep the sequence in List<int>.

namespace _01.PrintsSumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;

    public class PrintsSumAndAverageOfSequence
    {
        public static void Main()
        {
            Console.WriteLine("Please enter positive integers and press 'Enter' after each of them. Empty line for end.");

            List<int> numbers = new List<int>();
            int currentNumber;
            int sum = 0;
            bool checkIfNumber = true;

            do
            {
                string userInput = Console.ReadLine();
                checkIfNumber = int.TryParse(userInput, out currentNumber);
                if (checkIfNumber && currentNumber > 0)
                {
                    numbers.Add(currentNumber);
                    sum += currentNumber;
                }
                else
                {
                    break;
                }
            }
            while (checkIfNumber);

            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0}", (double)sum / numbers.Count);
        }
    }
}
