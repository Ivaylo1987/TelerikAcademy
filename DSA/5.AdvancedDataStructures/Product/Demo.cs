namespace OrderedBagDemo
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Wintellect.PowerCollections;

    public class EntryPoint
    {
        private const string CharsForRandomString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static readonly Random GetRandomNumber = new Random();
        private static readonly Stopwatch Timer = new Stopwatch();

        private static OrderedBag<Product> bagOfProducts;

        public static void Main()
        {
            bagOfProducts = new OrderedBag<Product>();

            // Populating the bag with products.
            Timer.Start();
            PopulateBag();
            Timer.Stop();
            Console.WriteLine("Adding products timer: {0}", Timer.Elapsed);
            Console.WriteLine("Items in the bag: {0}", bagOfProducts.Count);

            // Perform 10 000 random searches.
            Timer.Start();

            for (int i = 0; i < 10000; i++)
            {
                PerformRandomSearch();
            }

            Timer.Stop();
            Console.WriteLine("10 000 searches took: {0}", Timer.Elapsed);
        }

        private static IList<Product> PerformRandomSearch()
        {
            double minRange = GetRandomPrice();
            double maxRange = GetRandomPrice();

            while (true)
            {
                if (maxRange > minRange)
                {
                    break;
                }

                maxRange = GetRandomPrice();
            }

            return SearchInRange(minRange, maxRange);
        }

        private static IList<Product> SearchInRange(double minimalPrice, double maximalPrice)
        {
            var result = new List<Product>();
            var minProduct = new Product("minProduct", minimalPrice);
            var maxProduct = new Product("maxProduct", maximalPrice);

            var itemsFound = bagOfProducts.Range(minProduct, true, maxProduct, true);

            if (itemsFound.Count > 0)
            {
                for (int i = 0; i < 20 && i < itemsFound.Count; i++)
                {
                    result.Add(itemsFound[i]);
                }
            }

            return result;
        }

        private static void PopulateBag()
        {
            for (int i = 0; i < 500000; i++)
            {
                bagOfProducts.Add(GenerateProduct());
            }
        }

        private static Product GenerateProduct()
        {
            string name = GenerateRandomString();
            double price = GetRandomPrice();
            var product = new Product(name, price);

            return product;
        }

        private static string GenerateRandomString(int size = 5)
        {
            char[] charsSelected = new char[size];

            for (int i = 0; i < size; i++)
            {
                charsSelected[i] = CharsForRandomString[GetRandomNumber.Next(CharsForRandomString.Length)];
            }

            return new string(charsSelected);
        }

        private static double GetRandomPrice()
        {
            var numberGenerated = GetRandomNumber.NextDouble();

            return 0.99 + (numberGenerated * (99.99 - 0.99));
        }
    }
}
