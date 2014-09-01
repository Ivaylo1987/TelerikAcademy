namespace IHashSet
{
    using System;

    class Demo
    {
        static void Main()
        {
            var hasSet = new IHashSet<string>();

            hasSet.Add("first");
            hasSet.Add("second");

            var otherHasSet = new IHashSet<string>();
            otherHasSet.Add("third");
            otherHasSet.Add("fourth");

            var union = hasSet.Union(otherHasSet);

            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
        }
    }
}
