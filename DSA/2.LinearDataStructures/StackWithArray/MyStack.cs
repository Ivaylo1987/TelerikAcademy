namespace StackWithArray
{
    using System;

    class MyStack<T>
    {
        private T[] elements;
        private int size;

        public MyStack()
        {
            this.elements = new T[4];
            this.size = 0;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public void Push(T element)
        {
            if (size >= this.elements.Length - 1)
            {
                this.Resize();
            }

            this.elements[size] = element;
            size++;
        }

        public T Pop()
        {
            var result = this.elements[size - 1];
            this.elements[size] = default(T);
            size--;
            return result;
        }

        private void Resize()
        {
            var newArr = new T[this.elements.Length * 2];
            Array.Copy(this.elements, newArr, elements.Length);

            this.elements = newArr;
        }
    }
}
