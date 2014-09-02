namespace _02.OrderedMultiDictPerformance
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using Wintellect.PowerCollections;

    class TestOrderedMultiDictPerformance
    {
        static void Main()
        {
            OrderedMultiDictionary<decimal, Article> dict = new OrderedMultiDictionary<decimal, Article>(true);
            Random random = new Random();
            int range = 100;
            double randomDouble = random.NextDouble() * range;
            decimal lowBorder = 40;
            decimal highBorder = 41;
            for (int i = 0; i < 1000000; i++)
            {
                Article article = new Article();
                article.Barcode = i.ToString();
                article.Vendor = "Vendor" + i;
                article.Title = "Title" + 1;
                article.Price = (decimal)random.NextDouble() * range;
                dict.Add(article.Price, article);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            var selected = dict.Range(lowBorder, true, highBorder, false);
            sw.Stop();
            Console.WriteLine("Number of elements: {0}", dict.Count);
            Console.WriteLine("Number of selected elements in the range: {0}", selected.Count);
            Console.WriteLine("Time for selecting: {0}", sw.Elapsed);
        }

        public class Article : IComparable<Article>
        {
            public string Barcode { get; set; }
            public string Vendor { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }

            public int CompareTo(Article obj)
            {
                return (int)(this.Price - obj.Price);
            }
        }
    }
}
