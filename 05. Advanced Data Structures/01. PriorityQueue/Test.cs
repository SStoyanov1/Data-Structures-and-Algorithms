//01. Implement a class PriorityQueue<T> based on the data structure "binary heap".
//
//I used the example of the presentation to test the queue.

namespace PriorityQueue
{
    using System;

    public class PriorityQueueExample
    {
        public static void Main()
        {
            PriorityQueue<Person> people = new PriorityQueue<Person>();
            people.Enqueue(new Person("George", 21));
            people.Enqueue(new Person("Little Lucho", 2));
            people.Enqueue(new Person("Doncho", 23));
            people.Enqueue(new Person("Niki", 22));
            people.Enqueue(new Person("Nakov", 28));
            people.Enqueue(new Person("Ina", 24));
            people.Enqueue(new Person("Asya", 22));
            while (people.Count > 0)
            {
                Console.WriteLine(people.Dequeue());
            }
        }
    }

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Name, this.Age);
        }
    }
}