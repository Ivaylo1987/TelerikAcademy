namespace LinkedQueue
{
    using System;
    using LinkedList;

    class MyQueue<T>
    {
        private MyLinkedList<T> elements;

        public MyQueue()
        {
            this.elements = new MyLinkedList<T>();
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Enqueque(T value)
        {
            this.elements.AddLast(value);
            this.Count++;
        }

        public T Dequeue()
        {
            var result = this.elements.FirstelEment;
            this.elements.RemoveFirst();
            this.Count--;

            return result.Value;
        }
    }
}
