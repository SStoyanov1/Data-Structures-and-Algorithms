//05. Implement the data structure "set" in a class HashedSet<T> using your class HashTable<K,T>
//to hold the elements. Implement all standard set operations like Add(T), Find(T), Remove(T), Count,
//Clear(), union and intersect.

namespace _05.HashSet
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            var bulgarianTowns = new string[3]{ "Goce Delchev", "Pazardjik", "Belogradchik" };
            var englishTowns = new string[3] { "Newcastle", "Southamption", "Liverpool" };
            var towns = new HashedSet<string>(bulgarianTowns);
            var townsEngland = new HashedSet<string>(englishTowns);
            towns.Add("Balchik");
            towns.Union(townsEngland);

            foreach (var town in towns)
            {
                Console.WriteLine(town);
            }
        }
    }
}
