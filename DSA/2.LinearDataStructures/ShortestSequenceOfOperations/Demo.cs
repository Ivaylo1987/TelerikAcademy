namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        private static int GetNumberOfOperations(int seed, int final)
        {
            var numberQueue = new Queue<int>();
            var count = 0;

            numberQueue.Enqueue(seed);

            while (true)
            {
                if (numberQueue.Contains(final))
                {
                    break;
                }

                var len = numberQueue.Count;
                
                for (int i = 0; i < len; i++)
                {
                    var current = numberQueue.Dequeue();
                    numberQueue.Enqueue(current + 1);
                    numberQueue.Enqueue(current + 2);
                    numberQueue.Enqueue(current * 2);
                }

                count++;
            }

            return count;
        }

        static void Main()
        {
            Console.Write("Please, enter seed: ");
            var seed = int.Parse(Console.ReadLine());
            Console.Write("Please, enter final: ");
            var final = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetNumberOfOperations(seed, final));
        }
    }
}
