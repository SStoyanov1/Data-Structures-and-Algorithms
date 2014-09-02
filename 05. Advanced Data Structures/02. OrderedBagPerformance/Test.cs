namespace _02.OrderedBagPerformance
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;
    using System.Diagnostics;

    public class Test
    {
        public static void Main()
        {
            OrderedBag<Product> products = new OrderedBag<Product>();

            Random random = new Random();
            int range = 100;
            double randomDouble = random.NextDouble() * range;

            decimal lowBorder = 40;
            decimal highBorder = 41;

            for (int i = 0; i < 500000; i++)
            {
                Product product = new Product();
                product.Name = "Product" + i;
                product.Price = (decimal)random.NextDouble() * range;
                products.Add(product);
            }

            Stopwatch sw = new Stopwatch();

            sw.Start();
            var productsInRange = products.Range(new Product
                                                 {
                                                     Name = "Low",
                                                     Price = lowBorder
                                                 }, true,
                                                 new Product
                                                 {
                                                     Name = "High",
                                                     Price = highBorder
                                                 }, true);

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            Console.WriteLine("First 20 members in the range:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(productsInRange[i].Name + " " + productsInRange[i].Price);
            }
        }
    }

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product obj)
        {
            return (int)(this.Price - obj.Price);
        }
    }
}
