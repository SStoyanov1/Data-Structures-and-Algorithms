//* We are given numbers N and M and the following operations:
//N = N+1
//N = N+2
//N = N*2
//Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M. Hint: use a queue.
//Example: N = 5, M = 16
//Sequence: 5  7  8  16

namespace _10.FindsShortestSeqOfOperations
{
    using System;
    using System.Collections.Generic;

    public class FindsShortestSeqOfOperations
    {
        static void Main()
        {
            Console.WriteLine("Enter n: (ex. 5)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m: (ex. 16)");
            int m = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            stack.Push(m);
            while (m / 2 >= n)
            {
                m = m / 2;
                stack.Push(m);
            }

            while (m - 2 >= n)
            {
                m = m - 2;
                stack.Push(m);
            }

            while (m - 1 >= n)
            {
                m = m - 1;
                stack.Push(m);
            }

            PrintNumbers(stack);
        }

        private static void PrintNumbers(Stack<int> numbers)
        {
            Console.WriteLine("Print numbers.");
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}