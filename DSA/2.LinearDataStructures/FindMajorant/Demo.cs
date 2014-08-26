namespace FindMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        static void Main()
        {
            var sequence = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var majorant = sequence.First(el => sequence.Count(i => i == el) >= (sequence.Count / 2 + 1));

            Console.WriteLine("Majorant is: {0}", majorant);
        }
    }
}
