namespace CompanyArticles
{
    using System;
    using Wintellect.PowerCollections;

    public class Demo
    {
        private const string CharsForRandomString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly Random GetRandomNumber = new Random();

        public static void Main()
        {
            var orderedDict = new OrderedMultiDictionary<double, Article>(false);

            for (int i = 0; i < 5000; i++)
            {
                var currentArticle = GenerateArticle();
                orderedDict.Add(currentArticle.Price, currentArticle);
            }

            var articlesInRange = orderedDict.Range(100.0, true, 200.0, true);

            foreach (var item in articlesInRange)
            {
                foreach (var article in item.Value)
                {
                    Console.WriteLine(
                        "Title: {0}, Vendor: {1}, Price: {2}, Barcode: {3}", 
                        article.Title, 
                        article.Vendor, 
                        article.Price, 
                        article.Barcode);
                }
            }
        }

        private static Article GenerateArticle()
        {
            string title = GenerateRandomString();
            string vendor = GenerateRandomString();
            double price = GetRandomPrice();
            int barcode = GetRandomNumber.Next(10000, 99999);

            var article = new Article()
            {
                Title = title,
                Vendor = vendor,
                Price = price,
                Barcode = barcode
            };

            return article;
        }

        private static string GenerateRandomString(int size = 7)
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

            return 0.99 + (numberGenerated * (999.99 - 0.99));
        }
    }
}
