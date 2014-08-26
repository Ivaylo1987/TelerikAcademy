namespace LinkedList
{
    using System;

    public class MyLinkedList<T>
    {
        private ListItem<T> firstelEment;
        private ListItem<T> lastElement;

        public MyLinkedList(ListItem<T> firstelEment)
        {
            this.firstelEment = firstelEment;
            this.lastElement = firstelEment;
        }

        public MyLinkedList()
        {
        }

        public ListItem<T> FirstelEment 
        {
            get
            {
                return this.firstelEment;
            }
        }

        public ListItem<T> LastElement
        {
            get
            {
                return this.lastElement;
            }
        }

        public void AddLast(T value)
        {
            var current = new ListItem<T>(value);
            if (this.firstelEment == null)
            {
                this.firstelEment = current;
                this.lastElement = current;
            }
            else
            {
                this.lastElement.NextItem = current;
                this.lastElement = current;
            }
        }

        public void AddFirst(T value)
        {
            var temp = this.firstelEment;
            this.firstelEment = new ListItem<T>(value);
            this.firstelEment.NextItem = temp;
        }

        public void RemoveFirst()
        {
            if (this.firstelEment == null)
            {
                throw new NullReferenceException("The list is empty");
            }

            this.firstelEment = this.firstelEment.NextItem;
        }
    }
}
