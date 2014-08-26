namespace FirstFiftyMembers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        private static void PrintFirstFiftyMembers(int seed)
        {
            var numberQueue = new Queue<int>();
            var result = new List<int>();
            var count = 0;

            numberQueue.Enqueue(seed);
            while(true)
            {
                if (count == 50)
                {
                    break;
                }

                var current = numberQueue.Dequeue();
                numberQueue.Enqueue(current + 1);
                numberQueue.Enqueue(2 * current + 1);
                numberQueue.Enqueue(current + 2);

                result.Add(current);
                count++;
            }

            Console.WriteLine(string.Join(", ", result));
        }

        static void Main()
        {
            Console.Write("Please, enter seed for the sequence: ");
            var input = int.Parse(Console.ReadLine());

            PrintFirstFiftyMembers(input);
        }
    }
}
