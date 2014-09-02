namespace _03.BiDictionary
{
    using System;

    public class Test
    {
        static void Main()
        {
            BiDictionary<string, string, string> dictionary = new BiDictionary<string, string, string>();
            dictionary.Add("Varna", "female", "Gabriela Petrova");
            dictionary.Add("Burgas", "female", "Margarita Sizova");
            dictionary.Add("Sofia", "male", "Marin Marinov");
            dictionary.Add("Plovdiv", "female", "Paisii Petrov");


            var fromPlovdiv = dictionary.FindByFistKey("Plovdiv");
            foreach (var person in fromPlovdiv)
            {
                Console.WriteLine(person);
            }

            var females = dictionary.FindBySecondKey("female");
            foreach (var persons in females)
            {
                Console.WriteLine(persons);
            }

            var femaleFromPlovdiv = dictionary.FindByBothKeys("Plovdiv", "female");
            foreach (var person in femaleFromPlovdiv)
            {
                Console.WriteLine(person);
            }
        }
    }
}
