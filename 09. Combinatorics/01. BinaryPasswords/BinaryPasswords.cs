namespace _01.BinaryPasswords
{
    using System;

    internal class BinaryPasswords
    {
        //http://bgcoder.com/Contests/Practice/Index/132#0

        private static int possiblePasswords = 0;

        static void Main()
        {
            string input = Console.ReadLine();
            int count = 0;
            foreach (char element in input)
            {
                if (element == '*')
                {
                    count++;
                }
            }
            long result =  (long)Math.Pow(2.0, count);
            Console.WriteLine(result);
        }
    }
}
