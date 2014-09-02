//Implement the ADT stack as auto-resizable array. Resize the capacity on demand
//(when no space is available to add / insert a new element).

namespace _12.StackT
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        static void Main(string[] args)
        {
            StackT<int> stack = new StackT<int>();
            stack.Push(2);
            stack.Push(32);
            stack.Push(43);
            stack.Push(12);
            stack.Push(67);
            stack.Push(18);

            Console.WriteLine("Count: {0}", stack.Count);
            Console.WriteLine("Last item: {0}", stack.Peek());

            while (stack.Count != 0)
            {
                Console.Write(stack.Count == 1 ? stack.Pop().ToString() : stack.Pop() + ", ");
            }

            Console.WriteLine();
        }
    }
}
