namespace LinkedQueue
{
    using System;

    class Demo
    {
        static void Main()
        {
            var myQueue = new MyQueue<int>();

            myQueue.Enqueque(1);
            myQueue.Enqueque(2);
            myQueue.Enqueque(3);

            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }
    }
}
