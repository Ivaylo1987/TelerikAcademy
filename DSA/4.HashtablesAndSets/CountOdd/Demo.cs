namespace CountOdd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        static void Main()
        {
            var values = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            // short solution
            Console.WriteLine("Short solution");
            var oddNumberOfOccurances = values.Where(v => values.Count(e => e == v) % 2 != 0).Distinct();
            Console.WriteLine(string.Join(", ", oddNumberOfOccurances));

            // long solution
            var valuesCount = new Dictionary<string, int>();
            foreach (var item in values)
            {
                if (!valuesCount.ContainsKey(item))
                {
                    valuesCount.Add(item, 0);
                }

                valuesCount[item]++;
            }

            Console.WriteLine("Long solution");
            foreach (var group in valuesCount)
            {
                if (group.Value % 2 != 0)
                {
                    Console.WriteLine(group.Key);
                }
            }
        }
    }
}
