namespace CountDouble
{
    using System;
    using System.Collections.Generic;

    class Demo
    {
        static void Main()
        {
            var values = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var valuesCount = new Dictionary<double, int>();

            foreach (var item in values)
            {
                if (!valuesCount.ContainsKey(item))
                {
                    valuesCount.Add(item, 0);
                }

                valuesCount[item]++;
            }

            foreach (var group in valuesCount)
            {
                Console.WriteLine("{0} -> {1} times", group.Key, group.Value);
            }
        }
    }
}
