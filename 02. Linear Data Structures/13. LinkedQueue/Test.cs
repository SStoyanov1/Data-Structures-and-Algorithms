//Implement the ADT queue as dynamic linked list. Use generics (LinkedQueue<T>)
//to allow storing different data types in the queue.


namespace _13.LinkedQueue
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        static void Main()
        {
            LinkedQueue<string> students = new LinkedQueue<string>();

            students.Enqueue("Gosho");
            students.Enqueue("Misho");
            students.Enqueue("Pesho");
            students.Enqueue("Dicho");

            Console.WriteLine("Count: {0}", students.Count);
            Console.WriteLine("First student: {0}", students.Peek());

            students.Dequeue();
            students.Dequeue();

            Console.WriteLine("Count: {0}", students.Count);
            Console.WriteLine("First student: {0}", students.Peek());
        }
    }
}
