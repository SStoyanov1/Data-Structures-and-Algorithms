//Using the Queue<T> class write a program to print its first 50 members for given N.
//Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

namespace _09.FindsFirst50MembersOfSequence
{
    using System;
    using System.Collections.Generic;

    public class FindsFirst50MembersOfSequence
    {
        public static void Main()
        {
            Console.WriteLine("Enter n:");
            int firstMember = int.Parse(Console.ReadLine());

            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(firstMember);

            for (int i = 0; i < 50; i++)
            {
                int currentNumber = sequence.Dequeue();

                Console.Write(currentNumber + ", ");

                sequence.Enqueue(currentNumber + 1);
                sequence.Enqueue(2 * currentNumber + 1);
                sequence.Enqueue(currentNumber + 2);
            }
        }
    }
}
