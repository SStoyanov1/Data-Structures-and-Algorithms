//Write a program that reads a sequence of integers (List<int>) ending with an empty
//line and sorts them in an increasing order.

namespace _03.SortsInputIntegers
{
    using System;
    using System.Collections.Generic;

    public class SortsInputIntegers
    {
        public static void Main()
        {
            Console.WriteLine("Please enter positive integers and press 'Enter' after each of them. Empty line for end.");

            List<int> numbers = new List<int>();
            int currentNumber;
            bool checkIfNumber = true;

            do
            {
                string userInput = Console.ReadLine();
                checkIfNumber = int.TryParse(userInput, out currentNumber);
                if (checkIfNumber && currentNumber > 0)
                {
                    numbers.Add(currentNumber);
                }
                else
                {
                    break;
                }
            }
            while (checkIfNumber);

            numbers.Sort();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
