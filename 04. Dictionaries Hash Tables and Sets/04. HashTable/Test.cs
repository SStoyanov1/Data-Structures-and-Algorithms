//04. Implement the data structure "hash table" in a class HashTable<K,T>. Keep the data in array
//of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16. When
//the hash table load runs over 75%, perform resizing to 2 times larger capacity. Implement the
//following methods and properties: Add(key, value), Find(key)value, Remove( key), Count, Clear(),
//this[], Keys. Try to make the hash table to support iterating over its elements with foreach.

namespace _04.HashTable
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main(string[] args)
        {
            HashTable<string, int> table = new HashTable<string, int>();

            table.Add("Marin", 6);
            table.Add("Gavaril", 2);
            table.Add("Dendi", 12);
            Console.WriteLine("Marin -> {0}", table["Marin"]);

            foreach (var people in table)
            {
                Console.WriteLine(people.Key + " -> " + people.Value);
            }

            Console.WriteLine("Keys: " + string.Join(", ", table.Keys));
            Console.WriteLine("Dendi -> " + table.Find("Dendi"));

            table.Remove("Dendi");

            foreach (var people in table)
            {
                Console.WriteLine(people.Key + " -> " + people.Value);
            }
        }
    }
}
