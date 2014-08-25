namespace LinkedList
{
    using System;

    class MyLinkedList<T>
    {
        private ListItem<T> firstelEment;

        public MyLinkedList(ListItem<T> firstelEment)
        {
            this.firstelEment = firstelEment;
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

        public void AddLast(T value)
        {
            var current = new ListItem<T>(value);
            if (this.firstelEment == null)
            {
                this.firstelEment = current;
            }
            else
            {
                var temp = this.firstelEment;
                while (temp.NextItem != null)
                {
                    temp = temp.NextItem;
                }

                temp.NextItem = current;
            }
        }

        public void AddFirst(T value)
        {
            var temp = this.firstelEment;
            this.firstelEment = new ListItem<T>(value);
            this.firstelEment.NextItem = temp;
        }
    }
}
