namespace DotNetExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestExtensions
    {
        static void Main()
        {
            //Testing substring extension method
            StringBuilder builder = new StringBuilder();

            builder.Append("Some str@nge text for testing!");
            string subStr = builder.SubString(4, 8);

            Console.WriteLine("Substring from StringBuilder:{0}", subStr);

            // Testing IEnumerable extensions
            List<int> intEnum = new List<int>();

            for (int i = 1; i < 11; i++)
            {
                intEnum.Add(i);
            }

            // Sum
            var sumOfEnum = intEnum.SumExt();
            Console.WriteLine("Sum: {0}", sumOfEnum);

            // Product
            var productOfEnum = intEnum.Product();
            Console.WriteLine("Product: {0}", productOfEnum);

            // Average
            var averageOfEnum = intEnum.AverageExt();
            Console.WriteLine("Average: {0}", averageOfEnum);

            // Min
            var minOfEnum = intEnum.MinExt();
            Console.WriteLine("Min: {0}", minOfEnum);

            // Max
            var maxOfEnum = intEnum.MaxExt();
            Console.WriteLine("Max: {0}", maxOfEnum);
        }
    }
}
