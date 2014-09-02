//Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

namespace _02.ReversesInputIntegers
{
    using System;
    using System.Collections.Generic;

    public class ReversesInputIntegers
    {
        public static void Main()
        {
            Console.WriteLine("Please enter integers and press 'Enter' after each of them. Empty line for end.");

            Stack<int> numbers = new Stack<int>();
            int currentNumber;
            bool checkIfNumber = true;

            do
            {
                string userInput = Console.ReadLine();
                checkIfNumber = int.TryParse(userInput, out currentNumber);
                if (checkIfNumber && currentNumber > 0)
                {
                    numbers.Push(currentNumber);
                }
                else
                {
                    break;
                }
            }
            while (checkIfNumber);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
